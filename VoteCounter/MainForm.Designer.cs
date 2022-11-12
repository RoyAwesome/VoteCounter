
namespace VoteCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.multiseatVoteCount = new System.Windows.Forms.TextBox();
            this.multiseat_ballot_input = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.multiseat_output = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RCVModeTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rcv_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rcv2_candidates = new System.Windows.Forms.TextBox();
            this.rcv2_ballots = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rcv_output = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.RCVModeTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multi Seat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.multiseatVoteCount);
            this.splitContainer2.Panel1.Controls.Add(this.multiseat_ballot_input);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.multiseat_output);
            this.splitContainer2.Size = new System.Drawing.Size(1042, 629);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 75);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ballots:\r\n\r\nPlace each ballot on a seperate line. \r\nUse a comma to seperate votes" +
    "\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum Votes:";
            // 
            // multiseatVoteCount
            // 
            this.multiseatVoteCount.Location = new System.Drawing.Point(170, 108);
            this.multiseatVoteCount.Name = "multiseatVoteCount";
            this.multiseatVoteCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.multiseatVoteCount.Size = new System.Drawing.Size(89, 23);
            this.multiseatVoteCount.TabIndex = 0;
            this.multiseatVoteCount.Text = "3";
            this.multiseatVoteCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // multiseat_ballot_input
            // 
            this.multiseat_ballot_input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.multiseat_ballot_input.Location = new System.Drawing.Point(0, 366);
            this.multiseat_ballot_input.Multiline = true;
            this.multiseat_ballot_input.Name = "multiseat_ballot_input";
            this.multiseat_ballot_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.multiseat_ballot_input.Size = new System.Drawing.Size(347, 263);
            this.multiseat_ballot_input.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tabulate!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Tabulate_Multiseat);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Results:";
            // 
            // multiseat_output
            // 
            this.multiseat_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.multiseat_output.Location = new System.Drawing.Point(0, 143);
            this.multiseat_output.Multiline = true;
            this.multiseat_output.Name = "multiseat_output";
            this.multiseat_output.ReadOnly = true;
            this.multiseat_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.multiseat_output.Size = new System.Drawing.Size(691, 486);
            this.multiseat_output.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ranked Choice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RCVModeTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 629);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 0;
            // 
            // RCVModeTabs
            // 
            this.RCVModeTabs.Controls.Add(this.tabPage3);
            this.RCVModeTabs.Controls.Add(this.tabPage4);
            this.RCVModeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RCVModeTabs.Location = new System.Drawing.Point(0, 0);
            this.RCVModeTabs.Name = "RCVModeTabs";
            this.RCVModeTabs.SelectedIndex = 0;
            this.RCVModeTabs.Size = new System.Drawing.Size(347, 629);
            this.RCVModeTabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rcv_input);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(339, 601);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "CommaFormat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rcv_input
            // 
            this.rcv_input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rcv_input.Location = new System.Drawing.Point(3, 146);
            this.rcv_input.Multiline = true;
            this.rcv_input.Name = "rcv_input";
            this.rcv_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rcv_input.Size = new System.Drawing.Size(333, 452);
            this.rcv_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 157);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ballots:\r\n\r\nThis is the comma format\r\nFormat is \"Candidate1,Candidate2,Candidate3" +
    "\"\r\n\r\nPlace each ballot on a seperate line. \r\nUse a comma to seperate votes\r\n";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rcv2_candidates);
            this.tabPage4.Controls.Add(this.rcv2_ballots);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(339, 601);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "PreferenceFormat (new)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rcv2_candidates
            // 
            this.rcv2_candidates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rcv2_candidates.Location = new System.Drawing.Point(3, 186);
            this.rcv2_candidates.Multiline = true;
            this.rcv2_candidates.Name = "rcv2_candidates";
            this.rcv2_candidates.Size = new System.Drawing.Size(333, 141);
            this.rcv2_candidates.TabIndex = 2;
            this.rcv2_candidates.Text = "Candidates:";
            // 
            // rcv2_ballots
            // 
            this.rcv2_ballots.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rcv2_ballots.Location = new System.Drawing.Point(3, 327);
            this.rcv2_ballots.Multiline = true;
            this.rcv2_ballots.Name = "rcv2_ballots";
            this.rcv2_ballots.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rcv2_ballots.Size = new System.Drawing.Size(333, 271);
            this.rcv2_ballots.TabIndex = 1;
            this.rcv2_ballots.Text = "Ballots:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 180);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rcv_output);
            this.splitContainer3.Size = new System.Drawing.Size(691, 629);
            this.splitContainer3.SplitterDistance = 100;
            this.splitContainer3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 100);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tabulate Votes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TabulateVotes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results:";
            // 
            // rcv_output
            // 
            this.rcv_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcv_output.Location = new System.Drawing.Point(0, 0);
            this.rcv_output.Multiline = true;
            this.rcv_output.Name = "rcv_output";
            this.rcv_output.ReadOnly = true;
            this.rcv_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rcv_output.Size = new System.Drawing.Size(691, 525);
            this.rcv_output.TabIndex = 0;
            this.rcv_output.Text = "Hit the Tabulate Button!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 663);
            this.tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 687);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Vote Counter";
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RCVModeTabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox multiseatVoteCount;
        private System.Windows.Forms.TextBox multiseat_ballot_input;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox multiseat_output;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rcv_input;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rcv_output;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl RCVModeTabs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox rcv2_candidates;
        private System.Windows.Forms.TextBox rcv2_ballots;
        private System.Windows.Forms.Label label6;
    }
}