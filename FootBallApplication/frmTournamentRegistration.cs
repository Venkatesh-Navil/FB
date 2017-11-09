using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace FootBallApplication
{
    public partial class frmTournamentRegistration : Form
    {
        public frmTournamentRegistration()
        {
            InitializeComponent();
        }
        DataTable dts = new DataTable();
        clsTourRegistration objTour = new clsTourRegistration();
        private void btnDateBrowse_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            btnEndDateBrowseClick.Visible = false;
        }

        private void btnDBBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmFolder = new FolderBrowserDialog();
            frmFolder.ShowDialog();
            txtDBPath.Text = frmFolder.SelectedPath;
        }

        private void btnVideoBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmFolder = new FolderBrowserDialog();
            frmFolder.ShowDialog();
            txtVideoPath.Text = frmFolder.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTourName.Text != "" && txtDate.Text != "" && txtCountry.Text != ""  && txtVideoPath.Text != "")
            {

                objTour.CreateTournament(txtTourName.Text, txtDate.Text,txtEnd.Text, txtCountry.Text, txtDBPath.Text, txtVideoPath.Text);
                MessageBox.Show("Tournament has been registered and Database have been created successfully", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                MessageBox.Show("Please Enter All Details");
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtEnd.Text = monthCalendar2.SelectionStart.ToShortDateString();
            monthCalendar2.Visible = false;
            btnEndDateBrowseClick.Visible = true;
            lblchoose1.Visible = true;
            lblchoose2.Visible = true;
           // lblchoose3.Visible = true;
            lblchoose4.Visible = true;
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
            btnEndDateBrowseClick.Visible = true;

            lblchoose1.Visible = true;
            lblchoose2.Visible = true;
            //lblchoose3.Visible = true;
            lblchoose4.Visible = true;
        }

        private void frmTournamentRegistration_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            btnEndDateBrowseClick.Visible = false;
        }

        private void goToTeamRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamRegistration team=new frmTeamRegistration();
            team.Show();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gvTour.Visible = true;
            dts = objTour.LoadGrid();
            if (dts.Rows.Count > 0)
            {
                gvTour.DataSource = dts;
            }
            gvTour.Columns[0].Width = 200;
            gvTour.Columns[1].Width = 75;
            gvTour.Columns[2].Width = 75;
            gvTour.Columns[3].Width = 40;
            gvTour.Columns[4].Width = 100;

            gvTour.Width = 600;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamRegistration team = new frmTeamRegistration();
            team.Show();
        }

        private void lblchoose1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            btnEndDateBrowseClick.Visible = false;
            lblchoose1.Visible = false;
            lblchoose2.Visible = false;
            lblchoose3.Visible = false;
            lblchoose4.Visible = false;
        }

        private void lblchoose2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            btnEndDateBrowseClick.Visible = false;
            lblchoose1.Visible = false;
            lblchoose2.Visible = false;
            lblchoose3.Visible = false;
            lblchoose4.Visible = false;
        }

        private void lblchoose3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmFolder = new FolderBrowserDialog();
            frmFolder.ShowDialog();
            txtDBPath.Text = frmFolder.SelectedPath;
        }

        private void lblchoose4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmFolder = new FolderBrowserDialog();
            frmFolder.ShowDialog();
            txtVideoPath.Text = frmFolder.SelectedPath;
        }

        private void lblcontinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamRegistration team = new frmTeamRegistration();
            team.Show();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamRegistration team = new frmTeamRegistration();
            team.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
