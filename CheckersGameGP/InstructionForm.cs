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
    public partial class Instructiosform : Form
    {
        private static Instructiosform InstructionBox;
        public Instructiosform()
        {
            InitializeComponent();
        }

        internal static Instructiosform InstructiosformInstance()
        {
            if (InstructionBox == null)
                InstructionBox = new Instructiosform();
            return InstructionBox;
        }
              

        private void Instructiosform_FormClosing(object sender, FormClosingEventArgs e)
        {
            InstructionBox = null;
        }

        private void FirstInsButton_Click_1(object sender, EventArgs e)
        {
            InstructionsClass ins = new InstructionsClass();
            insLabel.Text = ins.GetInstruction();

        }

        private void SecondInsButton_Click_1(object sender, EventArgs e)
        {
            InstructionChild insChild = new InstructionChild();
            insLabel.Text = insChild.GetInstruction();
        }

        private void ThirdInsButton_Click_1(object sender, EventArgs e)
        {
            InstructionChild insChild = new InstructionChild();
            insLabel.Text = insChild.GetNextInstruction();
        }

        private void FourthInsButton_Click_1(object sender, EventArgs e)
        {
            InstructionChild insChild = new InstructionChild();
            insLabel.Text = insChild.GetNextInstruction("Overload the GetNextInstruction method");

        }
    }
}
