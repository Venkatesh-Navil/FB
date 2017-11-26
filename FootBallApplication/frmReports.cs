using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallApplication
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation nv = new frmNavigation();
            nv.Show();
        }

        private void btnbackk_Click(object sender, EventArgs e)
        {
            this.Close();
           // frmNavigation nv = new frmNavigation();
            //nv.Show();
        }

        private void lblgoalanalysis_Click(object sender, EventArgs e)
        {
           Reports.GoalAnalysis ga = new Reports.GoalAnalysis();
            ga.Show();
        }
    }
}
