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
    public partial class frmPlayer_Registration : Form
    {
        public frmPlayer_Registration()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        clsplayerRegistration objplay = new clsplayerRegistration();
        
        private void frmPlayer_Registration_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dt = objplay.LoadComboTour();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //cmbTour.Items.Add("Select Tournament");
                cmbTour.Items.Add(dt.Rows[i][0].ToString());
            }
            //cmbTour.ValueMember = "Tour_Name";
            //cmbTour.DisplayMember = "Tour_Name";
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbTour.SelectedIndex != -1)
            //{
            //    //cmbTour.ValueMember = "Tour_Name";
            //    string tour = cmbTour.SelectedValue.ToString();
            //    dt = new DataTable();

            //    dt = objplay.LoadComboTeam(tour);
            //    cmbTeam.DataSource = dt;
            //    cmbTeam.ValueMember = "Team_Name";
            //    cmbTeam.DisplayMember = "Team_Name";
            //}

        }

        private void cmbTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = objplay.LoadComboTeam(cmbTour.SelectedItem.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                cmbTeam.Items.Add(dt.Rows[i][0].ToString());
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNavigation navi = new frmNavigation();
            navi.Show();
        }

        private void btnImgBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPlayerImg.Text = openFileDialog1.FileName;
                    pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
                }
            }
            catch
            {
                txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
            }
            if (txtPlayerImg.Text == "")
            {
                txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int jersey = Convert.ToInt32(TxtJersey.Text);
            if (txtPlayerImg.Text != "")
            {
                //txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
                dt = new DataTable();

                string msg = objplay.InsertValues(cmbTour.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                if (msg == "Success")
                {
                    MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //dt = objplay.view_squad(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString());
                   

                }
                else
                {
                    MessageBox.Show("'" + TxtPlayer.Text + "'" + " already there in the table", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(@System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png");
                dt = new DataTable();
                string msg = objplay.InsertValues(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text,jersey);

                if (msg == "Success")
                {
                    MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    

                }
                else
                {
                    MessageBox.Show("'" + TxtPlayer.Text + "'" + " already there in the table", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1)
            {

                LoadGrid();
            }
            else
            {
                MessageBox.Show("Select the Tournament and Team", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LoadGrid()
        {
            dt = new DataTable();
            dt = objplay.view_squad(cmbTour.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString());
            dgPlayerRegistration.DataSource = dt;

            GridAlign();
        }
        private void GridAlign()
        {
            dgPlayerRegistration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPlayerRegistration.Width = 450;
            dgPlayerRegistration.Columns[0].Width = 150;
            dgPlayerRegistration.Columns[1].Width = 150;
            dgPlayerRegistration.Columns[2].Width = 150;
            dgPlayerRegistration.Columns[3].Width = 150;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {int jersey;
            jersey=Convert.ToInt32(TxtJersey.Text);
            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1 && TxtPlayer.Text != "")
            {
                objplay.UpdatePlayer(cmbTour.SelectedItem.ToString(), TxtPlayer.Text, cmbTeam.SelectedItem.ToString(), cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                MessageBox.Show("Player details has been updated", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                ClearControls();

            }
            else
                MessageBox.Show("Select a player to update", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearControls()
        {
            //cmbTeam.SelectedIndex = -1;
            TxtPlayer.Text = "";
            txtPlayerImg.Text = "";
            cmbPosition.SelectedIndex = -1;
            pnlImg.Visible = false;
            TxtJersey.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1 && TxtPlayer.Text != "")
            {
                objplay.DeletePlayer(cmbTour.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString(), TxtPlayer.Text);
                MessageBox.Show("Player details has been Deleted", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                ClearControls();

            }
            else
                MessageBox.Show("Select a player to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgPlayerRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selindex = e.RowIndex;
            if (selindex != -1)
            {


                dt = new DataTable();
                
                
                dt = objplay.GetPlayersOnGridClick(cmbTour.SelectedItem.ToString(), dgPlayerRegistration.Rows[selindex].Cells[0].Value.ToString(), dgPlayerRegistration.Rows[selindex].Cells[1].Value.ToString());
                if (dt.Rows.Count > 0)
                {


                    TxtPlayer.Text = dt.Rows[0][0].ToString();
                    cmbPosition.SelectedItem = dt.Rows[0][1].ToString();
                    //txtPlayerImg.Text = "Default";
                    byte[] array = (byte[])dt.Rows[0][3];
                    pnlImg.Visible = true;
                    MemoryStream ms = new MemoryStream(array);
                    pnlImg.BackgroundImage = Image.FromStream(ms);
                    txtPlayerImg.Text = "Default";
                    TxtJersey .Text= dt.Rows[0][4].ToString();




                }
            }
        }

        private void lblchoose_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtPlayerImg.Text = openFileDialog1.FileName;
                    pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
                }
            }
            catch
            {
                txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
            }
            if (txtPlayerImg.Text == "")
            {
                txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int jersey = Convert.ToInt32(TxtJersey.Text);
                if (txtPlayerImg.Text != "")
                {
                    //txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                    pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
                    dt = new DataTable();

                    string msg = objplay.InsertValues(cmbTour.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                    if (msg == "Success")
                    {
                        MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //dt = objplay.view_squad(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString());


                    }
                    else
                    {
                        MessageBox.Show("'" + TxtPlayer.Text + "'" + " already there in the table", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                    pnlImg.BackgroundImage = Image.FromFile(@System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png");
                    dt = new DataTable();
                    string msg = objplay.InsertValues(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                    if (msg == "Success")
                    {
                        MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    else
                    {
                        MessageBox.Show("'" + TxtPlayer.Text + "'" + " already there in the table", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgPlayerRegistration.Visible = true;
            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1)
            {

                LoadGrid();
            }
            else
            {
                MessageBox.Show("Select the Tournament and Team", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int jersey;
            jersey = Convert.ToInt32(TxtJersey.Text);
            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1 && TxtPlayer.Text != "")
            {
                objplay.UpdatePlayer(cmbTour.SelectedItem.ToString(), TxtPlayer.Text, cmbTeam.SelectedItem.ToString(), cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                MessageBox.Show("Player details has been updated", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                ClearControls();

            }
            else
                MessageBox.Show("Select a player to update", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1 && TxtPlayer.Text != "")
            {
                objplay.DeletePlayer(cmbTour.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString(), TxtPlayer.Text);
                MessageBox.Show("Player details has been Deleted", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadGrid();
                ClearControls();

            }
            else
                MessageBox.Show("Select a player to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearControls();

        }

        private void lblcontinue_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmNavigation navi = new frmNavigation();
            navi.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmNavigation navi = new frmNavigation();
            navi.Show();
        }
       
       

    }
}
