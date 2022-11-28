namespace CheckersGameGP
{
    partial class FeedBackForm
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
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.notGoodRadioButton = new System.Windows.Forms.RadioButton();
            this.goodRadioButton = new System.Windows.Forms.RadioButton();
            this.excellentRadioButton = new System.Windows.Forms.RadioButton();
            this.cmtTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorcmtlabel = new System.Windows.Forms.Label();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.notGoodRadioButton);
            this.grpStatus.Controls.Add(this.goodRadioButton);
            this.grpStatus.Controls.Add(this.excellentRadioButton);
            this.grpStatus.Location = new System.Drawing.Point(316, 207);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(220, 121);
            this.grpStatus.TabIndex = 0;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // notGoodRadioButton
            // 
            this.notGoodRadioButton.AutoSize = true;
            this.notGoodRadioButton.Location = new System.Drawing.Point(39, 73);
            this.notGoodRadioButton.Name = "notGoodRadioButton";
            this.notGoodRadioButton.Size = new System.Drawing.Size(83, 20);
            this.notGoodRadioButton.TabIndex = 2;
            this.notGoodRadioButton.TabStop = true;
            this.notGoodRadioButton.Text = "NotGood";
            this.notGoodRadioButton.UseVisualStyleBackColor = true;
            // 
            // goodRadioButton
            // 
            this.goodRadioButton.AutoSize = true;
            this.goodRadioButton.Location = new System.Drawing.Point(39, 47);
            this.goodRadioButton.Name = "goodRadioButton";
            this.goodRadioButton.Size = new System.Drawing.Size(62, 20);
            this.goodRadioButton.TabIndex = 1;
            this.goodRadioButton.TabStop = true;
            this.goodRadioButton.Text = "Good";
            this.goodRadioButton.UseVisualStyleBackColor = true;
            // 
            // excellentRadioButton
            // 
            this.excellentRadioButton.AutoSize = true;
            this.excellentRadioButton.Location = new System.Drawing.Point(39, 24);
            this.excellentRadioButton.Name = "excellentRadioButton";
            this.excellentRadioButton.Size = new System.Drawing.Size(82, 20);
            this.excellentRadioButton.TabIndex = 0;
            this.excellentRadioButton.TabStop = true;
            this.excellentRadioButton.Text = "Excellent";
            this.excellentRadioButton.UseVisualStyleBackColor = true;
            // 
            // cmtTextBox
            // 
            this.cmtTextBox.Location = new System.Drawing.Point(316, 84);
            this.cmtTextBox.Multiline = true;
            this.cmtTextBox.Name = "cmtTextBox";
            this.cmtTextBox.Size = new System.Drawing.Size(245, 78);
            this.cmtTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comment About Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(343, 361);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // errorcmtlabel
            // 
            this.errorcmtlabel.AutoSize = true;
            this.errorcmtlabel.ForeColor = System.Drawing.Color.Red;
            this.errorcmtlabel.Location = new System.Drawing.Point(107, 28);
            this.errorcmtlabel.Name = "errorcmtlabel";
            this.errorcmtlabel.Size = new System.Drawing.Size(0, 16);
            this.errorcmtlabel.TabIndex = 4;
            // 
            // FeedBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorcmtlabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmtTextBox);
            this.Controls.Add(this.grpStatus);
            this.Name = "FeedBackForm";
            this.Text = "FeedBackForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedBackForm_FormClosing);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton notGoodRadioButton;
        private System.Windows.Forms.RadioButton goodRadioButton;
        private System.Windows.Forms.RadioButton excellentRadioButton;
        private System.Windows.Forms.TextBox cmtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorcmtlabel;
    }
}