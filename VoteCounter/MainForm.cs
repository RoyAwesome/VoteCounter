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
            string[] ballots = rcv_input.Text.Split('\n');
            string output = RankedChoiceVotingTabulator.TabulateVotes(ballots);
            rcv_output.Text = output;
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
