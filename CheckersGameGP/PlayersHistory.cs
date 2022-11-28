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
    public partial class PlayersHistoryForm : Form
    {
        private static PlayersHistoryForm PlayersHistoryInstance;
        CheckerIntermediaryClass checkerIntermediaryClass;
        public PlayersHistoryForm()
        {
            InitializeComponent();
        }

        internal static PlayersHistoryForm PlayersHistoryFormInstance()
        {
            if(PlayersHistoryInstance == null)
            PlayersHistoryInstance = new PlayersHistoryForm();
            return PlayersHistoryInstance;
        }

        private void PlayersHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayersHistoryInstance = null;
        }

        private void PlayersHistoryForm_Load(object sender, EventArgs e)
        {
            
            checkerIntermediaryClass= new CheckerIntermediaryClass();
            DataTable dt=checkerIntermediaryClass.PlayersHistory();
            DataView dv = (from myrow in dt.AsEnumerable() where myrow.Field<int>("Age") > 20 select myrow).CopyToDataTable<DataRow>().AsDataView();
         //   foreach (DataRow row in dr)
         //   {
         ////       dt2.ImportRow(row);
         //   }
            dataGridView1.DataSource =dv;
            dataGridView1.Show();
        }
    }
}
