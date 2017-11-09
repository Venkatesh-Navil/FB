using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BAL;

namespace FootBallApplication
{
    public partial class frmTeamRegistration : Form
    {
        public frmTeamRegistration()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        clsTeamRegistration objTeam = new clsTeamRegistration();
        private void frmTeamRegistration_Load(object sender, EventArgs e)
        {
            dt = objTeam.LoadComboTour();
            cmbTour.DataSource = dt;
            cmbTour.ValueMember = "Tournament_Name";
            cmbTour.DisplayMember = "Tournament_Name";
        }

        private void btnFlagBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtTeamName.Text != "" && txtCoach.Text != "" && txtManager.Text != "" && txtTeamFlag.Text != "")
            {
                objTeam.InsertValues(cmbTour.Text, txtTeamName.Text, txtTeamFlag.Text, txtCoach.Text, txtManager.Text);
                if (objTeam.strInsertMsg == "Success")
                {
                    MessageBox.Show("Team has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //LoadGrid(cmbTour.SelectedValue.ToString());
                    ClearControls();

                }
                else
                {
                    MessageBox.Show("'" + txtTeamName.Text + "'" + " is already registered", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter all the details", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearControls()
        {
            txtTeamName.Text = "";
            txtTeamFlag.Text = "";
            pnlFlag.Visible = false;
            txtManager.Text = "";
            txtCoach.Text = "";


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlayer_Registration play = new frmPlayer_Registration();
            play.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadGrid(cmbTour.SelectedValue.ToString());
        }
        public void LoadGrid(string strTour)
        {
            dt = new DataTable();
            dt = objTeam.LoadGrid(strTour);
            gvTeam.DataSource = dt;

           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selindex = e.RowIndex;
            if (selindex != -1)
            {


                dt = new DataTable();
                dt = objTeam.GetTeamOnGridClick(cmbTour.SelectedValue.ToString(), gvTeam.Rows[selindex].Cells[0].Value.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtManager.Text = dt.Rows[0][3].ToString();
                    txtCoach.Text = dt.Rows[0][2].ToString();
                    txtTeamName.Text = dt.Rows[0][0].ToString();
                    byte[] array = (byte[])dt.Rows[0][1];
                    pnlFlag.Visible = true;
                    MemoryStream ms = new MemoryStream(array);
                    pnlFlag.BackgroundImage = Image.FromStream(ms);
                    txtTeamFlag.Text = "Default";

                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbTour.SelectedIndex != -1 && txtTeamName.Text != "")
            {
                objTeam.UpdateTeam(cmbTour.Text, txtTeamName.Text, txtManager.Text, txtCoach.Text, txtTeamFlag.Text);

                MessageBox.Show("Team details have been updated", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // view_teams();
                LoadGrid(cmbTour.SelectedItem.ToString());
                ClearControls();
            }
            else
                MessageBox.Show("Select Team to Update", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbTour.SelectedIndex != -1 && txtTeamName.Text != "")
            {
                objTeam.DeleteTeam(cmbTour.Text, txtTeamName.Text);
                MessageBox.Show("Team has been removed", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid(cmbTour.SelectedValue.ToString());
                ClearControls();
            }
            else
                MessageBox.Show("Select Team to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPlayer_Registration play = new frmPlayer_Registration();
            play.Show();
        }

        private void lblchoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtTeamFlag.Text = openFileDialog1.FileName;
                    pnlFlag.BackgroundImage = Image.FromFile(txtTeamFlag.Text);


                }
            }
            catch
            {
                txtTeamFlag.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BFI.png";
                pnlFlag.BackgroundImage = Image.FromFile(txtTeamFlag.Text);

            }
            if (txtTeamFlag.Text == "")
            {
                txtTeamFlag.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BFI.png";
                pnlFlag.BackgroundImage = Image.FromFile(txtTeamFlag.Text);

            }
            pnlFlag.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text != "" && txtCoach.Text != "" && txtManager.Text != "" && txtTeamFlag.Text != "")
            {
                objTeam.InsertValues(cmbTour.Text, txtTeamName.Text, txtTeamFlag.Text, txtCoach.Text, txtManager.Text);
                if (objTeam.strInsertMsg == "Success")
                {
                    MessageBox.Show("Team has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //LoadGrid(cmbTour.SelectedValue.ToString());
                    ClearControls();

                }
                else
                {
                    MessageBox.Show("'" + txtTeamName.Text + "'" + " is already registered", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter all the details", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadGrid(cmbTour.SelectedValue.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmbTour.SelectedIndex != -1 && txtTeamName.Text != "")
            {
                objTeam.UpdateTeam(cmbTour.Text, txtTeamName.Text, txtManager.Text, txtCoach.Text, txtTeamFlag.Text);

                MessageBox.Show("Team details have been updated", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // view_teams();
                LoadGrid(cmbTour.SelectedItem.ToString());
                ClearControls();
            }
            else
                MessageBox.Show("Select Team to Update", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (cmbTour.SelectedIndex != -1 && txtTeamName.Text != "")
            {
                objTeam.DeleteTeam(cmbTour.Text, txtTeamName.Text);
                MessageBox.Show("Team has been removed", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid(cmbTour.SelectedValue.ToString());
                ClearControls();
            }
            else
                MessageBox.Show("Select Team to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmPlayer_Registration play = new frmPlayer_Registration();
            play.Show();
        }
        
    }
}
