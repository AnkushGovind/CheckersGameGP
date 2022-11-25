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
    public partial class CheckersMain : Form
    {
        public CheckersMain()
        {
            InitializeComponent();

        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckersGameForm checkersGameForm = CheckersGameForm.CheckersGameFormInstance();
            checkersGameForm.MdiParent = this;
            checkersGameForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = AboutBox1.AboutBoxFormInstance();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();
        }
    }
}
