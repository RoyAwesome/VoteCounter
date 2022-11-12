using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    internal class RankedChoiceVotingTabulator
    {

        internal class RCVBallot
        {
            public List<string> Rankings
            {
                get;
            } = new List<string>();
        }

        internal class RCVRound
        {
            public int Round
            {
                get;
                set;
            }

            public RCVRound PreviousRound
            {
                get;
                internal set;
            } = null;

            public IEnumerable<string> EliminatedCandidates
            {
                get
                {                   
                    if(PreviousRound == null)
                    {
                        if(HasWinner || HasTie)
                        {
                            return Enumerable.Empty<string>();
                        }
                        else
                        {
                            return new string[] { GetElimatedCandidate() };
                        }
                        
                    }
                    else
                    {                       
                        if (HasWinner || HasTie)
                        {
                            return PreviousRound.EliminatedCandidates;
                        }
                        else
                        {
                            return PreviousRound.EliminatedCandidates.Append(GetElimatedCandidate());
                        }
                       
                    }
                }
            } 

            internal Dictionary<string, int> VoteCounts
            {
                get;
            } = new Dictionary<string, int>();

            internal List<(string, int, float)> Results
            {
                get;
            } = new List<(string, int, float)>();

            public int ExhaustedBallots
            {
                get;
                private set;
            }

            public bool HasWinner
            {
                get
                {
                    return Results.Any(x => x.Item3 > 0.5f);
                }
            }

            public string Winner
            {
                get
                {
                    if(HasWinner)
                    {
                        return VoteCounts.OrderByDescending(x => x.Value).DefaultIfEmpty(new KeyValuePair<string, int>("", 0)).FirstOrDefault().Key;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            public bool HasTie
            {
                get
                {
                    //We can only have a tie if we have 2 results
                    if(Results.Count == 2)
                    {
                        if(Results[0].Item2 == Results[1].Item2)
                        {
                            return true;
                        }

                        return false;
                    }

                    return false;
                }
            }
          
            public override string ToString()
            {
                var sb = new StringBuilder().AppendFormat("====== Round {0} =====", Round + 1);
                if (HasTie)
                {
                    sb.AppendLine()
                   .Append("Winner: TIE");
                }
                else
                {
                    sb.AppendLine()
                    .AppendFormat("Winner: {0}", Winner ?? "None");
                }
              
                    
                     sb.AppendLine()
                     .AppendFormat("Exhausted Ballots: {0}", ExhaustedBallots)
                     .AppendLine()
                     .AppendLine()
                     .AppendLine("-------- Detailed Results --------");
                     
                foreach(var result in Results.OrderByDescending(x => x.Item3))
                {
                    sb.AppendFormat("{0}:\t\tVotes: {1} - {2}%", result.Item1, result.Item2, (result.Item3 * 100).ToString("0.00"))
                        .AppendLine();
                }
                sb.AppendLine();
                if(!HasWinner && !HasTie)
                {
                    sb.AppendFormat("Eliminated Candidate: {0}", GetElimatedCandidate())
                    .AppendLine();
                }

                return sb.ToString();
            }

            public string GetElimatedCandidate()
            {
                //Find the candidate with the least number of votes
                return VoteCounts.OrderByDescending(x => x.Value).DefaultIfEmpty(new KeyValuePair<string, int>("", 0)).LastOrDefault().Key;
            }

            public void Tabulate(List<RCVBallot> Ballots)
            {
                string[] CachedEliminations = EliminatedCandidates.ToArray();

                Func<string, bool> IsEliminated = (string candidate) =>
                {
                    if(CachedEliminations.Contains(candidate))
                    {
                        return true;
                    }
                    return false;
                };


                foreach(RCVBallot ballot in Ballots)
                {
                    bool exhaustedBallot = true;
                    for(int i = 0; i < ballot.Rankings.Count; i++)
                    {
                        string candidate = ballot.Rankings[i];

                        if(IsAbstention(candidate))
                        {
                            //This is a ballot exhaustion.  We don't count anything after "abstain"
                            break;
                        }


                        if(!IsEliminated(candidate))
                        {
                            if(!VoteCounts.ContainsKey(candidate))
                            {
                                VoteCounts[candidate] = 0;
                            }
                            VoteCounts[candidate] += 1;

                            exhaustedBallot = false;
                            break;
                        }
                    }

                    if(exhaustedBallot)
                    {
                        ExhaustedBallots++;
                    }
                }

                float TotalVotes = VoteCounts.Sum(x => x.Value);

                foreach (var values in VoteCounts)
                {
                    float percentage = values.Value / TotalVotes;

                    Results.Add(new(values.Key, values.Value, percentage));
                }
            }
                     
            bool IsAbstention(string candidate)
            {
                return candidate.ToLower() == "abstain";
            }
                      
        }

        public static string TabulateVotes(string[] Ballots)
        {
            RankedChoiceVotingTabulator Tabulator = new RankedChoiceVotingTabulator(Ballots);

            Tabulator.TabulateRounds();

            StringBuilder sb = new();

            sb.AppendLine("Candidates: ")
                .AppendJoin(", ", Tabulator.Candidates)
                .AppendLine()
                .AppendLine();

  

            sb.AppendLine("Results: ");
            foreach(var round in Tabulator.Rounds)
            {
                sb.AppendLine(round.ToString());
            }

            return sb.ToString();
        }

        static List<string> ValidPlacementWords = new()
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "nineth",
            "tenth"
        };

        public static string[] ConvertFormatTwo(string[] Candidates, string[] Ballots, out List<string> InvalidBallots)
        {
            InvalidBallots = new();
            List<string> result = new();

            foreach(string ballot in Ballots)
            {
                var Choices = ballot.Split(null).Select(x => x.Trim().ToLower()).Where(x => !string.IsNullOrEmpty(x)); //Split by whitespace

                if (!Choices.All(x => ValidPlacementWords.Contains(x)))
                {
                    throw new InvalidOperationException("Unable to parse ballot entry that isn't a valid word");
                }


                IEnumerable<(string candidate, int choice)> CandidateChoices = Choices
                    .Take(Candidates.Length)
                    .Select((choice, i) =>
                {
                    int candidatePreference = ValidPlacementWords.IndexOf(choice.ToLower().Trim());
                    return (Candidates[i], candidatePreference);
                });
                            

              
                IEnumerable<(string candidate, int choice)> ordered = CandidateChoices.SkipWhile(x => x.choice < 0).OrderBy(x => x.choice);

                var endOfSequence = ordered.Zip(ordered.Skip(1), (a, b) => (a.choice + 1) == b.choice).ToList().FindIndex(x => !x);

                if(endOfSequence >= 0)
                {
                    ordered = ordered.Take(endOfSequence + 1);
                }
                else if (ordered.Count() != 0 && ordered.First().choice != 0)
                {
                    ordered = Enumerable.Empty<(string candidate, int choice)>();                  
                }

                if(ordered.Count() > 0)
                {
                    result.Add(string.Join(',', ordered.Select(x => x.candidate)));
                }     
                else
                {
                    InvalidBallots.Add(ballot);
                }

            }

            return result.ToArray();
        }

        public List<string> Candidates
        {
            get;
        } = new List<string>();

        internal List<RCVBallot> Ballots
        {
            get;
        } = new List<RCVBallot>();

        internal List<RCVRound> Rounds
        {
            get;
        } = new List<RCVRound>();

        internal RankedChoiceVotingTabulator(string[] Ballots)
        {
            ParseBallots(Ballots);
        }


        void ParseBallots(string[] BallotStrings)
        {          

            foreach(string ballotstr in BallotStrings)
            {
                string[] Splits = ballotstr.ToLower().Split(',').Select(x => x.Trim()).ToArray();

                RCVBallot b = new RCVBallot();
                b.Rankings.AddRange(Splits);
                Ballots.Add(b);



                foreach(string candidate in Splits)
                {
                    if (!Candidates.Contains(candidate))
                    {
                        Candidates.Add(candidate);
                    }
                }
            }    
        }

        internal RCVRound CalculateSingleRound(int RoundNum, RCVRound PreviousRound = null)
        {
            RCVRound round = new();
            round.Round = RoundNum;
            round.PreviousRound = PreviousRound;

            round.Tabulate(Ballots);

            return round;
        }

        public void TabulateRounds()
        {
            bool hasWinner = false;

            int roundnum = 0;
            RCVRound LastRound = null;
            do
            {

                RCVRound round = CalculateSingleRound(roundnum, LastRound);
                Rounds.Add(round);
                
                hasWinner = round.HasWinner;

                if(!hasWinner)
                {
                    LastRound = round;
                    roundnum++;
                }
                //If we have a tie, just eject
                if(round.HasTie)
                {
                    break;
                }


              
            } while (!hasWinner);

           
        }
    }
}
