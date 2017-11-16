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
    public partial class Total__Registration : Form
    {
        public Total__Registration()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        clsTotalRegistration objTot = new clsTotalRegistration();
        private void Total__Registration_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;

            //get team
            dt = objTot.LoadComboTour();
            cmbTour.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //cmbTour.Items.Add("Select Tournament");
                cmbTour.Items.Add(dt.Rows[i][0].ToString());
            }

            //get tournament

            dt = new DataTable();
            dt = objTot.LoadComboTour();
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //cmbTour.Items.Add("Select Tournament");
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        public Total__Registration(string Tour,string manager,string coach,string teamname,byte[] array,string teamflag)
        {
            InitializeComponent();
            txtManager.Text = manager;
            txtCoach.Text = coach;
            txtTeamName.Text = teamname;
            pnlFlag.Visible = true;
            cmbTour.Text = Tour;
            //MemoryStream ms = new MemoryStream(array);
            //pnlFlag.BackgroundImage = Image.FromStream(ms);
            txtTeamFlag.Text = teamflag;
        }
        public Total__Registration(string Tour,string Team,string player,string position,string txtimage,byte[] array,string jersey,int id)
        {
            InitializeComponent();
            TxtPlayer.Text = player;
            cmbPosition.Text = position;
            pnlImg.Visible = true;
            MemoryStream ms = new MemoryStream(array);
            pnlImg.BackgroundImage = Image.FromStream(ms);
            txtPlayerImg.Text = txtimage;
            TxtJersey.Text = jersey;
            comboBox1.Text = Tour;
            cmbTeam.Text = Team;
        }
        public Total__Registration(string Id,string Tour,string start,string End,string country,string Videopath,string category)
        {
            InitializeComponent();
            txtTourName.Text = Tour;
            txtDate.Text = start;
            txtEnd.Text = End;
            txtVideoPath.Text = Videopath;
            txtCountry.Text = country;
            cmbCategory.Text = category;

        }

        private void lblchoose1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            lblchoose1.Visible = false;
            lblchoose2.Visible = false;
            txtCountry.Visible = false;
            txtEnd.Visible = false;
            txtDate.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;

            lblchoose1.Visible = true;
            lblchoose2.Visible = true;
            txtCountry.Visible = true;
            txtEnd.Visible = true;
            txtDate.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
                
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            
            txtEnd.Text = monthCalendar2.SelectionStart.ToShortDateString();
            monthCalendar2.Visible = false ;

            lblchoose1.Visible = true;
            lblchoose2.Visible = true;
            txtCountry.Visible = true;
            txtEnd.Visible = true;
            txtDate.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTourName.Text != "" && txtDate.Text != "" && txtCountry.Text != "" && txtVideoPath.Text != "")
            {

                objTot.CreateTournament(txtTourName.Text, txtDate.Text, txtEnd.Text, txtCountry.Text, txtDBPath.Text, txtVideoPath.Text,cmbCategory.Text);
                MessageBox.Show("Tournament has been registered and Database have been created successfully", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clearcontrols();
            }
            else
            {
                MessageBox.Show("Please Enter All Details");
            }
            // get tour for team
            dt = objTot.LoadComboTour();
            cmbTour.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                cmbTour.Items.Add(dt.Rows[i][0].ToString());
            }

            //get tour for player

            dt = new DataTable();
            dt = objTot.LoadComboTour();
            comboBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //cmbTour.Items.Add("Select Tournament");
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        private void clearcontrols()
        {
            txtTourName.Text = "";
            txtEnd.Text = "";
            txtDate.Text = "";
            txtVideoPath.Text = "";
            cmbCategory.Text = "";
            txtCountry.Text = "";
        }
        private void clearteamControls()
        {
            //cmbTour.Text = "";
            txtCoach.Text = "";
            txtManager.Text = "";
            txtTeamFlag.Text = "";
            txtTeamName.Text = "";
        }
        private void clearplayerControls()
        {
            ///comboBox1.Text = "";
            //cmbTeam.Text = "";
            TxtJersey.Text = "";
            txtPlayerImg.Text = "";
            cmbPosition.Text = "";
            TxtPlayer.Text = "";

        }
        private void lblchoose2_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            lblchoose1.Visible = false;
            lblchoose2.Visible = false;
            txtCountry.Visible = false;
            txtEnd.Visible = false;
            txtDate.Visible = false;
            label2.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label3.Visible = false;

        }

        private void lblchoose4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog frmFolder = new FolderBrowserDialog();
            frmFolder.ShowDialog();
            txtVideoPath.Text = frmFolder.SelectedPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text != "" && txtCoach.Text != "" && txtManager.Text != "" && txtTeamFlag.Text != "")
            {
                objTot.InsertValues(cmbTour.Text, txtTeamName.Text, txtTeamFlag.Text, txtCoach.Text, txtManager.Text);
                if (objTot.strInsertMsg == "Success")
                {
                    MessageBox.Show("Team has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //LoadGrid(cmbTour.SelectedValue.ToString());
                    clearteamControls();

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

            dt = new DataTable();
            dt = objTot.LoadComboTeam(cmbTour.Text);
            cmbTeam.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                cmbTeam.Items.Add(dt.Rows[i][0].ToString());
            }
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int jersey = Convert.ToInt32(TxtJersey.Text);
                if (txtPlayerImg.Text != "")
                {
                    //txtPlayerImg.Text = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BPI.png";
                    pnlImg.BackgroundImage = Image.FromFile(txtPlayerImg.Text);
                    dt = new DataTable();

                    string msg = objTot.InsertValues(comboBox1.SelectedItem.ToString(), cmbTeam.SelectedItem.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                    if (msg == "Success")
                    {
                        MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //dt = objplay.view_squad(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString());

                        clearplayerControls();
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
                    string msg = objTot.InsertValues(cmbTour.SelectedValue.ToString(), cmbTeam.SelectedValue.ToString(), TxtPlayer.Text, cmbPosition.SelectedItem.ToString(), txtPlayerImg.Text, jersey);

                    if (msg == "Success")
                    {
                        MessageBox.Show("Player details has been registered", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        clearplayerControls();
                    }
                    else
                    {
                        MessageBox.Show("'" + TxtPlayer.Text + "'" + " already there in the table", "Rider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch(Exception e1)
            {

                MessageBox.Show(e1.Message);
               // MessageBox.Show("Please Enter Details Properly");
            }
        }

        private void label13_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearteamControls();
            clearcontrols();
            dt = new DataTable();
            dt = objTot.LoadComboTeam(comboBox1.SelectedItem.ToString());
            cmbTeam.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                cmbTeam.Items.Add(dt.Rows[i][0].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbTour.Text!="" && txtTeamName.Text != "")
             {
                objTot.DeleteTeam(cmbTour.Text, txtTeamName.Text);
                MessageBox.Show("Team has been removed", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //LoadGrid(cmbTour.SelectedValue.ToString());
                clearteamControls();
            }
            else
                MessageBox.Show("Please Select a Team to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            //dgPlayerRegistration.Visible = false;
            //gvTour.Visible = false;
            //if (cmbTour.SelectedIndex != -1|| cmbTour.Text!="")
            //{
            //    try
            //    {
            //        gvTeam.Visible = true;


            //        dt = new DataTable();
            //        dt = objTot.LoadGrid(cmbTour.Text); ;
            //        gvTeam.DataSource = dt;
            //    }
            //    catch
            //    {
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select Tournament");
            //}
            if (cmbTour.Text != "")
            {
                //this.Hide();
                int id = 2;
                frmGrid frm = new frmGrid(cmbTour.Text, txtTeamName.Text, id);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please  select any Tournament");
            }

        }
        private void gvTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbTour.Text != "")
            {
                int selindex = e.RowIndex;
                if (selindex != -1)
                {


                    dt = new DataTable();
                    dt = objTot.GetTeamOnGridClick(cmbTour.SelectedItem.ToString(), gvTeam.Rows[selindex].Cells[1].Value.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        txtManager.Text = dt.Rows[0][5].ToString();
                        txtCoach.Text = dt.Rows[0][4].ToString();
                        txtTeamName.Text = dt.Rows[0][2].ToString();

                        byte[] array = (byte[])dt.Rows[0][3];
                        pnlFlag.Visible = true;
                        MemoryStream ms = new MemoryStream(array);
                        pnlFlag.BackgroundImage = Image.FromStream(ms);
                        txtTeamFlag.Text = "Default";

                    }
                }
            }
            else
            {

            }
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
            //gvTour.Visible = false;
            //gvTeam.Visible = false;
           
            //if ( cmbTeam.SelectedIndex != -1)
            //{
            //    dgPlayerRegistration.Visible = true;
            //    dt = new DataTable();
              // dt = objTot.view_squad(cmbTour.Text, cmbTeam.Text);
            //    dgPlayerRegistration.DataSource = dt;

            //    GridAlign();
            //}
            //else
            //{
            //    MessageBox.Show("Select the Tournament and Team", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            if(comboBox1.Text!="")
            {
            int id = 3;
            this.Hide();
            frmGrid frm = new frmGrid(comboBox1.Text,cmbTeam.Text,id);
            frm.Show();
            }
            else
            {
                MessageBox.Show("Please select any Tournament and Team");
            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selindex = e.RowIndex;
            if (selindex != -1)
            {


                dt = new DataTable();
                dt = objTot.GetTeamOnGridClick(cmbTour.SelectedValue.ToString(), gvTeam.Rows[selindex].Cells[1].Value.ToString());
                if (dt.Rows.Count > 0)
                {
                    txtManager.Text = dt.Rows[0][5].ToString();
                    txtCoach.Text = dt.Rows[0][4].ToString();
                    txtTeamName.Text = dt.Rows[0][2].ToString();

                    byte[] array = (byte[])dt.Rows[0][3];
                    pnlFlag.Visible = true;
                    MemoryStream ms = new MemoryStream(array);
                    pnlFlag.BackgroundImage = Image.FromStream(ms);
                    txtTeamFlag.Text = "Default";

                }
            }
        }

        private void cmbTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearplayerControls();
            clearcontrols();
        }

        private void txtTourName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTourName_MouseClick(object sender, MouseEventArgs e)
        {
            clearteamControls();
            clearplayerControls();
        }

        private void dgPlayerRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selindex = e.RowIndex;
            if (selindex != -1)
            {


                dt = new DataTable();


                dt = objTot.GetPlayersOnGridClick(comboBox1.SelectedItem.ToString(), dgPlayerRegistration.Rows[selindex].Cells[0].Value.ToString());
                if (dt.Rows.Count > 0)
                {


                    TxtPlayer.Text = dt.Rows[0][3].ToString();
                    cmbPosition.SelectedItem = dt.Rows[0][4].ToString();
                    //txtPlayerImg.Text = "Default";
                    byte[] array = (byte[])dt.Rows[0][5];
                    pnlImg.Visible = true;
                    MemoryStream ms = new MemoryStream(array);
                    pnlImg.BackgroundImage = Image.FromStream(ms);
                    txtPlayerImg.Text = "Default";
                    TxtJersey.Text = dt.Rows[0][6].ToString();




                }
            }
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //gvTeam.Visible=false;
            //dgPlayerRegistration.Visible=false;
            //gvTour.Visible=true;
            //    try
            //    {
            //        gvTour.Visible = true;

            //        dt = new DataTable();
                //  dt = objTot.LoadGridTour(cmbTour.Text); ;
            //        gvTour.DataSource = dt;
            //    }
            //    catch
            //    {
            //    }
            int id = 1;
            string tour = "";
            string team = "";
            frmGrid frm = new frmGrid(tour,team,id);
            frm.Show();
    
           
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && cmbTeam.Text != "" && TxtPlayer.Text != "")
            {
                objTot.DeletePlayer(comboBox1.Text, cmbTeam.Text, TxtPlayer.Text);
                MessageBox.Show("Player details has been Deleted", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //LoadGrid();
                clearplayerControls();

            }
            else
                MessageBox.Show("Please Select a player to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            this.Hide();
           // frmNavigation nav = new frmNavigation();
           // nav.Show();
        }

        private void panel17_MouseDown(object sender, MouseEventArgs e)
        {
            this.Hide();
            Total__Registration tot = new Total__Registration();
            tot.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtTourName.Text != "")
            {
                objTot.DeleteTour(txtTourName.Text);
                MessageBox.Show("Tournament has been removed", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //LoadGrid(cmbTour.SelectedValue.ToString());
                clearteamControls();
            }
            else
                MessageBox.Show("Please Select a Tournament to Delete", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Total__Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //frmNavigation nav = new frmNavigation();
           // nav.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
