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
    public partial class frmMatch_Registration : Form
    {
        string Tournament;
        DataTable dtTeam;
        clsMatchRegistration objMatch = new clsMatchRegistration();
        clsImage objImage = new clsImage();
        
        public frmMatch_Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void frmMatch_Registration_Load(object sender, EventArgs e)
        {
            DataTable dt = objMatch.LoadComboTour();
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
            comboBox1.ValueMember = "Tournament_Name";
            comboBox1.DisplayMember = "Tournament_Name";
           
        }

        private void btnDateBrowse_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbTeamA.SelectedIndex != -1 && cmbTeamA.SelectedIndex != -1 && txtDate.Text != "" && cmbVenue.Text != "")
            {
                objMatch.InsertValues(clsGlobalValues.Tournament, cmbTeamA.SelectedItem.ToString(), cmbTeamB.SelectedItem.ToString(), cmbVenue.Text, txtDate.Text, "InComplete");
                MessageBox.Show("Match Created");
            }
            else
            {
                MessageBox.Show("Enter All Details");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            dtTeam = objMatch.LoadMatches(clsGlobalValues.Tournament);
            if (dtTeam.Rows.Count > 0)
            {
                dgMatch.DataSource = dtTeam;
                dgMatch.Width = 500;
                dgMatch.Columns[0].Width = 100;
                dgMatch.Columns[1].Width = 100;
                dgMatch.Columns[2].Width = 100;
                dgMatch.Columns[3].Width = 100;
                dgMatch.Columns[4].Width = 100;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation objNavigation = new frmNavigation();
            objNavigation.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblchoose.Visible = true;
            txtDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;


            dtTeam = new DataTable();
            dtTeam = objMatch.LoadTournament();
             cmbVenue.Items.Clear();
            if (dtTeam.Rows.Count > 0)
            {
                for (int i = 0; i < dtTeam.Rows.Count; i++)
                {
                    cmbVenue.Items.Add(dtTeam.Rows[i][0].ToString());

                }
            }
        }

        private void cmbTeamA_SelectedValueChanged(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            dtTeam = objMatch.LoadTeamB(cmbTeamA.SelectedItem.ToString(), comboBox1.Text);
            cmbTeamB.Items.Clear();
            if (dtTeam.Rows.Count > 0)
            {
                for (int i = 0; i < dtTeam.Rows.Count; i++)
                {
                    cmbTeamB.Items.Add(dtTeam.Rows[i][0].ToString());
                }
            }
        }

        private void cmbTeamB_SelectedIndexChanged(object sender, EventArgs e)
        {
            objImage.TwoTeamFlagsDisplay(clsGlobalValues.Tournament, cmbTeamA.SelectedItem.ToString(), cmbTeamB.SelectedItem.ToString(), panel1, panel2);
        }

        private void lblchoose_Click(object sender, EventArgs e)
        {
            lblchoose.Visible = false;
            monthCalendar1.Visible = true;
            monthCalendar1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (cmbTeamA.SelectedIndex != -1 && cmbTeamB.SelectedIndex != -1 && txtDate.Text != "" && cmbVenue.Text != "")
            {
                objMatch.InsertValues(comboBox1.Text, cmbTeamA.SelectedItem.ToString(), cmbTeamB.SelectedItem.ToString(), cmbVenue.Text, txtDate.Text, "InComplete");
                MessageBox.Show("Match Created");
            }
            else
            {
                MessageBox.Show("Enter All Details");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgMatch.Visible = true;
            panel8.Visible = true;
            dtTeam = new DataTable();
            dtTeam = objMatch.LoadMatches(clsGlobalValues.Tournament);
            if (dtTeam.Rows.Count > 0)
            {
                dgMatch.DataSource = dtTeam;
                dgMatch.Width = 500;
                dgMatch.Columns[0].Width = 100;
                dgMatch.Columns[1].Width = 100;
                dgMatch.Columns[2].Width = 100;
                dgMatch.Columns[3].Width = 100;
                dgMatch.Columns[4].Width = 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmNavigation objNavigation = new frmNavigation();
            objNavigation.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tournament = comboBox1.Text;

            dtTeam = new DataTable();
            dtTeam = objMatch.LoadTeamA(Tournament);
            cmbTeamA.Items.Clear();
            if (dtTeam.Rows.Count > 0)
            {
                for (int i = 0; i < dtTeam.Rows.Count; i++)
                {
                    cmbTeamA.Items.Add(dtTeam.Rows[i][0].ToString());

                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbTeamA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
