using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    public class MultiseatVotingTabulator
    {
        public static string TabulateVotes(string[] Ballots, int MaxVotes)
        {
            StringBuilder sb = new();

            Dictionary<string, int> Votes = new();

            int TooManyVotesDiscardedBallots = 0;

            foreach(string Ballot in Ballots)
            {
                string[] RawVotes = Ballot.Split(",").Select(x => x.ToLower().Trim()).ToArray();

                if(RawVotes.Length > MaxVotes)
                {
                    TooManyVotesDiscardedBallots++;
                    continue;
                }

                foreach(string rawVote in RawVotes)
                {
                    if(!Votes.ContainsKey(rawVote))
                    {
                        Votes[rawVote] = 0;
                    }
                    Votes[rawVote]++;
                }

            }

            sb.AppendLine("======= Results ======")
                .AppendFormat("Discarded Ballots due to Too Many Votes: {0}", TooManyVotesDiscardedBallots)
                .AppendLine()
                .AppendLine();

            foreach (var KVP in Votes.OrderByDescending(x => x.Value))
            {
                sb.AppendFormat("{0} \t\t\t\t - \t {1}", KVP.Key, KVP.Value)
                    .AppendLine();
            }

            return sb.ToString();


        }


    }
}
