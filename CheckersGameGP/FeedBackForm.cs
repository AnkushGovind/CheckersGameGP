using IntermediaryLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGameGP
{
    public partial class FeedBackForm : Form 
    {
        private static FeedBackForm FeedBackInstance;
        public FeedBackForm()
        {
            InitializeComponent();
        }
        string winnerName;
        public FeedBackForm(string WinName)
        {
            winnerName = WinName;
        }
        internal static FeedBackForm FeedBackFormInstance()
        {//Singleton FOrm
            if (FeedBackInstance == null)
                FeedBackInstance = new FeedBackForm();

            return FeedBackInstance;
        }
        

        private void FeedBackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FeedBackInstance = null;
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            //Validations
            if (cmtTextBox.Text == "")
            {
                errorcmtlabel.Text = "Comments is Required";
                return;
            }

            if (!excellentRadioButton.Checked && !goodRadioButton.Checked && !notGoodRadioButton.Checked)
            {
                errorcmtlabel.Text = "Atleast 1 Status should select";
                return;
            }


            string status = string.Empty;

            if (excellentRadioButton.Checked)
            {
                status = "excellent";
            }

            if (goodRadioButton.Checked) 8
            {
                status = "good";
            }

            if (notGoodRadioButton.Checked)
            {
                status = "not good";
            }

         //   string ss = winnerName;
           CheckerIntermediaryClass checkerIntermediaryClass = new CheckerIntermediaryClass();
            //Saving the details to DB
            int result = checkerIntermediaryClass.AddFeedBack(1, cmtTextBox.Text, status);

            if (result > 0)
            {
                errorcmtlabel.Text = "FeedBack Added Successfully";
            }

        }
    }
}
