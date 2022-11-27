namespace CheckersGameGP
{
    partial class Instructiosform
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
            this.label1 = new System.Windows.Forms.Label();
            this.insLabel = new System.Windows.Forms.Label();
            this.FirstInsButton = new System.Windows.Forms.Button();
            this.SecondInsButton = new System.Windows.Forms.Button();
            this.ThirdInsButton = new System.Windows.Forms.Button();
            this.FourthInsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructions";
            // 
            // insLabel
            // 
            this.insLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insLabel.Location = new System.Drawing.Point(112, 238);
            this.insLabel.Name = "insLabel";
            this.insLabel.Size = new System.Drawing.Size(561, 131);
            this.insLabel.TabIndex = 1;
            // 
            // FirstInsButton
            // 
            this.FirstInsButton.Location = new System.Drawing.Point(112, 116);
            this.FirstInsButton.Name = "FirstInsButton";
            this.FirstInsButton.Size = new System.Drawing.Size(121, 50);
            this.FirstInsButton.TabIndex = 3;
            this.FirstInsButton.Text = "First Instruction";
            this.FirstInsButton.UseVisualStyleBackColor = true;
            this.FirstInsButton.Click += new System.EventHandler(this.FirstInsButton_Click_1);
            // 
            // SecondInsButton
            // 
            this.SecondInsButton.Location = new System.Drawing.Point(256, 116);
            this.SecondInsButton.Name = "SecondInsButton";
            this.SecondInsButton.Size = new System.Drawing.Size(125, 50);
            this.SecondInsButton.TabIndex = 3;
            this.SecondInsButton.Text = "Second Instruction";
            this.SecondInsButton.UseVisualStyleBackColor = true;
            this.SecondInsButton.Click += new System.EventHandler(this.SecondInsButton_Click_1);
            // 
            // ThirdInsButton
            // 
            this.ThirdInsButton.Location = new System.Drawing.Point(405, 116);
            this.ThirdInsButton.Name = "ThirdInsButton";
            this.ThirdInsButton.Size = new System.Drawing.Size(121, 50);
            this.ThirdInsButton.TabIndex = 3;
            this.ThirdInsButton.Text = "Third Instruction";
            this.ThirdInsButton.UseVisualStyleBackColor = true;
            this.ThirdInsButton.Click += new System.EventHandler(this.ThirdInsButton_Click_1);
            // 
            // FourthInsButton
            // 
            this.FourthInsButton.Location = new System.Drawing.Point(552, 116);
            this.FourthInsButton.Name = "FourthInsButton";
            this.FourthInsButton.Size = new System.Drawing.Size(121, 50);
            this.FourthInsButton.TabIndex = 3;
            this.FourthInsButton.Text = "Fourth Insrtuction";
            this.FourthInsButton.UseVisualStyleBackColor = true;
            this.FourthInsButton.Click += new System.EventHandler(this.FourthInsButton_Click_1);
            // 
            // Instructiosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FourthInsButton);
            this.Controls.Add(this.ThirdInsButton);
            this.Controls.Add(this.SecondInsButton);
            this.Controls.Add(this.FirstInsButton);
            this.Controls.Add(this.insLabel);
            this.Controls.Add(this.label1);
            this.Name = "Instructiosform";
            this.Text = "Instructions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Instructiosform_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insLabel;
        private System.Windows.Forms.Button FirstInsButton;
        private System.Windows.Forms.Button SecondInsButton;
        private System.Windows.Forms.Button ThirdInsButton;
        private System.Windows.Forms.Button FourthInsButton;
    }
}