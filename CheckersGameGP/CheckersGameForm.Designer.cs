namespace CheckersGameGP
{
    partial class CheckersGameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionsLabel = new System.Windows.Forms.Label();
            this.OptionALabel = new System.Windows.Forms.Label();
            this.OptionBLabel = new System.Windows.Forms.Label();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1ScoreLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2NameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.P2ScoreLabel = new System.Windows.Forms.Label();
            this.P1NameLabel = new System.Windows.Forms.Label();
            this.WinPanel = new System.Windows.Forms.Panel();
            this.WinLabel = new System.Windows.Forms.Label();
            this.PlayAgainLabel = new System.Windows.Forms.Label();
            this.PlayPanel.SuspendLayout();
            this.WinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 593);
            this.panel1.TabIndex = 0;
            // 
            // QuestionsLabel
            // 
            this.QuestionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionsLabel.Location = new System.Drawing.Point(675, 189);
            this.QuestionsLabel.Name = "QuestionsLabel";
            this.QuestionsLabel.Size = new System.Drawing.Size(387, 77);
            this.QuestionsLabel.TabIndex = 1;
            // 
            // OptionALabel
            // 
            this.OptionALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionALabel.Location = new System.Drawing.Point(724, 288);
            this.OptionALabel.Name = "OptionALabel";
            this.OptionALabel.Size = new System.Drawing.Size(100, 23);
            this.OptionALabel.TabIndex = 2;
            // 
            // OptionBLabel
            // 
            this.OptionBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionBLabel.Location = new System.Drawing.Point(921, 288);
            this.OptionBLabel.Name = "OptionBLabel";
            this.OptionBLabel.Size = new System.Drawing.Size(100, 23);
            this.OptionBLabel.TabIndex = 3;
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayPanel.Controls.Add(this.label2);
            this.PlayPanel.Controls.Add(this.label1);
            this.PlayPanel.Controls.Add(this.startLabel);
            this.PlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlayPanel.Location = new System.Drawing.Point(0, 0);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(1074, 624);
            this.PlayPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(361, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "WELCOME PLAYERS";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(41, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // startLabel
            // 
            this.startLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startLabel.Location = new System.Drawing.Point(452, 502);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(146, 41);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(675, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.Image = global::CheckersGameGP.Properties.Resources.BlackPiece;
            this.label4.Location = new System.Drawing.Point(672, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 63);
            this.label4.TabIndex = 7;
            // 
            // P1ScoreLabel
            // 
            this.P1ScoreLabel.AutoSize = true;
            this.P1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1ScoreLabel.Location = new System.Drawing.Point(758, 27);
            this.P1ScoreLabel.Name = "P1ScoreLabel";
            this.P1ScoreLabel.Size = new System.Drawing.Size(27, 29);
            this.P1ScoreLabel.TabIndex = 8;
            this.P1ScoreLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(681, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Player 2";
            // 
            // P2NameLabel
            // 
            this.P2NameLabel.AutoSize = true;
            this.P2NameLabel.Location = new System.Drawing.Point(768, 453);
            this.P2NameLabel.Name = "P2NameLabel";
            this.P2NameLabel.Size = new System.Drawing.Size(56, 16);
            this.P2NameLabel.TabIndex = 10;
            this.P2NameLabel.Text = "p2name";
            // 
            // label8
            // 
            this.label8.Image = global::CheckersGameGP.Properties.Resources.WhitePiece;
            this.label8.Location = new System.Drawing.Point(681, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 61);
            this.label8.TabIndex = 11;
            // 
            // P2ScoreLabel
            // 
            this.P2ScoreLabel.AutoSize = true;
            this.P2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2ScoreLabel.Location = new System.Drawing.Point(758, 520);
            this.P2ScoreLabel.Name = "P2ScoreLabel";
            this.P2ScoreLabel.Size = new System.Drawing.Size(27, 29);
            this.P2ScoreLabel.TabIndex = 12;
            this.P2ScoreLabel.Text = "0";
            // 
            // P1NameLabel
            // 
            this.P1NameLabel.AutoSize = true;
            this.P1NameLabel.Location = new System.Drawing.Point(768, 83);
            this.P1NameLabel.Name = "P1NameLabel";
            this.P1NameLabel.Size = new System.Drawing.Size(56, 16);
            this.P1NameLabel.TabIndex = 13;
            this.P1NameLabel.Text = "p1name";
            // 
            // WinPanel
            // 
            this.WinPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WinPanel.Controls.Add(this.PlayAgainLabel);
            this.WinPanel.Controls.Add(this.WinLabel);
            this.WinPanel.Controls.Add(this.PlayPanel);
            this.WinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinPanel.Location = new System.Drawing.Point(0, 0);
            this.WinPanel.Name = "WinPanel";
            this.WinPanel.Size = new System.Drawing.Size(1074, 624);
            this.WinPanel.TabIndex = 0;
            this.WinPanel.Visible = false;
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WinLabel.Location = new System.Drawing.Point(467, 244);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(2, 18);
            this.WinLabel.TabIndex = 0;
            // 
            // PlayAgainLabel
            // 
            this.PlayAgainLabel.AutoSize = true;
            this.PlayAgainLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PlayAgainLabel.Location = new System.Drawing.Point(464, 380);
            this.PlayAgainLabel.Name = "PlayAgainLabel";
            this.PlayAgainLabel.Size = new System.Drawing.Size(72, 16);
            this.PlayAgainLabel.TabIndex = 1;
            this.PlayAgainLabel.Text = "Play Again";
            this.PlayAgainLabel.Click += new System.EventHandler(this.PlayAgainLabel_Click);
            // 
            // CheckersGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.WinPanel);
            this.Controls.Add(this.P1NameLabel);
            this.Controls.Add(this.P2ScoreLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.P2NameLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.P1ScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OptionBLabel);
            this.Controls.Add(this.OptionALabel);
            this.Controls.Add(this.QuestionsLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "CheckersGameForm";
            this.ShowIcon = false;
            this.Text = "CheckersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckersGameForm_FormClosing);
            this.Load += new System.EventHandler(this.CheckersGameForm_Load);
            this.PlayPanel.ResumeLayout(false);
            this.WinPanel.ResumeLayout(false);
            this.WinPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuestionsLabel;
        private System.Windows.Forms.Label OptionALabel;
        private System.Windows.Forms.Label OptionBLabel;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label P1ScoreLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label P2NameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label P2ScoreLabel;
        private System.Windows.Forms.Label P1NameLabel;
        private System.Windows.Forms.Panel WinPanel;
        private System.Windows.Forms.Label PlayAgainLabel;
        private System.Windows.Forms.Label WinLabel;
    }
}