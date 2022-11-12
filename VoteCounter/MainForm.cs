using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteCounter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TabulateVotes_Click(object sender, EventArgs e)
        {
            if(RCVModeTabs.SelectedIndex == 0)
            {
                string[] ballots = rcv_input.Text.Split('\n');
                string output = RankedChoiceVotingTabulator.TabulateVotes(ballots);
                rcv_output.Text = output;
            }
            else if(RCVModeTabs.SelectedIndex == 1)
            {
                string[] Candidates = rcv2_candidates.Text.Split(Environment.NewLine);
                string[] ballots = rcv2_ballots.Text.Split(Environment.NewLine);

                var converted = RankedChoiceVotingTabulator.ConvertFormatTwo(Candidates, ballots, out var InvalidBallots);

                string output = RankedChoiceVotingTabulator.TabulateVotes(converted);
                StringBuilder sb = new();
                sb.AppendLine(output);
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine("-------------");
                sb.AppendLine("Invalid Ballots:");
                sb.Append(Environment.NewLine + "\t* ");
                sb.AppendLine(string.Join(Environment.NewLine + "\t* ", InvalidBallots));

                rcv_output.Text = sb.ToString();

            }

        }

        private void Tabulate_Multiseat(object sender, EventArgs e)
        {
            string[] ballots = multiseat_ballot_input.Text.Split('\n');
            int maxVotes = 0;
            int.TryParse(multiseatVoteCount.Text, out maxVotes);
            string Output = MultiseatVotingTabulator.TabulateVotes(ballots, maxVotes);
            multiseat_output.Text = Output;
        }
    }
}
