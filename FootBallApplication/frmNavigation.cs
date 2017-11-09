using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using BAL;

namespace FootBallApplication
{
    public partial class frmNavigation : Form
    {
        string btnId;
         DataTable dt = new DataTable();
        public frmNavigation()
        {
            InitializeComponent();
        }
        string strMatchStatus;
        clsGlobalValues objGlobal = new clsGlobalValues();
        clsNavigation objNavigation = new clsNavigation();

        private void label1_Click(object sender, EventArgs e)
        {

            pnlregistration.Visible = true;

            panel7.Visible = false;
           // panel8.Visible = false;
            dgNavigation.Visible = false;
            lblback.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //*************PREVIOUS CLICK************************************************************************
            btnId = "1";
            lstTour.Items.Clear();
            dt = new DataTable();
            dt = objNavigation.LoadTournament();


            //if (dt.Rows.Count > 0)
            //{
            //    lstTournaments.ValueMember = "Tour_Name";
            //    lstTournaments.DisplayMember = "Tour_Name";
            //    lstTournaments.DataSource = dt;
            //    lstTournaments.SelectedIndex = -1;
            //}




            // lstTournaments.ClearValue(ListBox.BackgroundProperty);//its not working   

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] array = new string[] { dt.Rows[i][0].ToString() };
                Array.Sort(array);
              lstTour.Items.AddRange(array);
              lstTour.Sorted = true;



                // lstTournaments.ForeColor = Color.Black;
                //Tournaments.Items.Add(dt.Rows[i][0].ToString());
            }
            //*********************END***********
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {

        }
        private void GridAlign()
        {
            //dgNavigation.ColumnCount = 7;
            dgNavigation.Columns[0].Width = 20;
            dgNavigation.Columns[1].Width = 130;
            dgNavigation.Columns[2].Width = 60;
            dgNavigation.Columns[3].Width = 60;
            dgNavigation.Columns[4].Width = 50;
            dgNavigation.Columns[5].Width = 100;
            dgNavigation.Columns[6].Width = 100;



            dgNavigation.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNavigation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNavigation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNavigation.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNavigation.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgNavigation.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dgNavigation.Width = 520;
            dgNavigation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNavigation.ReadOnly = true;
        }

        private void lstTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GridAlign();
            //lbltour.Visible = false;
            //lblteam.Visible = false;
            //lblmatch.Visible = false;
            //lblplayer.Visible = false;
            //lblreports.Visible = false;
            //lblSquad.Visible = false;

            //panel1.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;
            //panel4.Visible = false;
            //panel5.Visible = false;
            //panel6.Visible = false;

            pnlregistration.Visible = false;
            lblviewnav.Visible = true;
       

            panel7.Visible = true;
            panel8.Visible = true;

            lblback.Visible = true;

            Cursor.Current = Cursors.WaitCursor;
            dgNavigation.DefaultCellStyle.Font = new Font("BankGothic Lt BT", 11F, GraphicsUnit.Pixel);
            dgNavigation.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dgNavigation.DefaultCellStyle.ForeColor = Color.White;
            dgNavigation.GridColor = Color.FromArgb(30, 30, 30);
            dgNavigation.DefaultCellStyle.SelectionBackColor = Color.White;
            dgNavigation.DefaultCellStyle.SelectionForeColor = Color.Black;
            Cursor.Current = Cursors.Default;

            
            //dgNavigation.Columns[0].Width = 30;
            //dgNavigation.Columns[1].Width = 120;
            //dgNavigation.Columns[2].Width = 100;
            //dgNavigation.Columns[3].Width = 100;
            //dgNavigation.Columns[4].Width = 60;
            //dgNavigation.Columns[5].Width = 80;
            //dgNavigation.Columns[6].Width = 120;


            //***************************TOURNAMENT LIST CLICK***************************************************

            if (lstTour.SelectedIndex != -1)
            {
                clsGlobalValues.Tournament = lstTour.SelectedItem.ToString();
                //try
                //{
                if (btnId == "1")
                {
                   // dgNavigation = new DataGridView();
                    DataTable dt = new DataTable();
                    dt = objNavigation.LoadMatchesPrevious(clsGlobalValues.Tournament);

                    try
                    {
                        if (dt.Rows.Count > 0)
                        {

                            dgNavigation.Visible = true;
                            //dgNavigation = new DataGridView();
                            dgNavigation.Rows.Clear();
                            dgNavigation.DataSource = dt;
                            GridAlign();


                        }

                    }
                    catch { }
                }

                if (btnId == "2")
                {
                    

                            DataTable dt = new DataTable();
                            dt = objNavigation.LoadMatchesCurrent(clsGlobalValues.Tournament);
                            try
                            {
                                if (dt.Rows.Count > 0)
                                {

                                    dgNavigation.Visible = true;
                            dgNavigation.Rows.Clear();
                            dgNavigation.DataSource = dt;
                                    GridAlign();
                                }

                            }
                            catch { }
                        }

                    
                   
                }
            
        }
        private void lstTour_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTour.SelectedIndex != -1)
            {
                this.Close();
                clsGlobalValues.Tournament = lstTour.SelectedItem.ToString();
                frmMatch_Registration objForm = new frmMatch_Registration();
                objForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnId = "2";
            lstTour.Items.Clear();
            dt = new DataTable();
            dt = objNavigation.LoadTournament();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] array = new string[] { dt.Rows[i][0].ToString() };
                Array.Sort(array);
                lstTour.Items.AddRange(array);
                lstTour.Sorted = true;

            }
        }

        private void dgNavigation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int dg1 = e.RowIndex;

            clsGlobalValues.mid = Convert.ToInt16(dgNavigation.Rows[dg1].Cells[0].Value.ToString());


            strMatchStatus = dgNavigation.Rows[dg1].Cells[6].Value.ToString();
            if (dgNavigation.Rows[dg1].Cells[5].Value.ToString() == "Incomplete" || dgNavigation.Rows[e.RowIndex].Cells[5].Value.ToString() == "Incompleted")
            {
             lblstart.Text = "Lets Kick Off";
            }
            else if (dgNavigation.Rows[dg1].Cells[5].Value.ToString() == "Complete" || dgNavigation.Rows[dg1].Cells[5].Value.ToString() == "Completed")
            {

                lblstart.Text = "View Reports";
            }
            else
            {
                lblstart.Text = "Continue Kick Off";
            }
            lblstart.Visible = true;
            pnlball.Visible = true;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (strMatchStatus != "" && strMatchStatus != null)
            {
                if (strMatchStatus == "InComplete" || strMatchStatus == "InCompleted")
                {
                    frmSquad_Registration objSquard = new frmSquad_Registration();
                    objSquard.Show();
                    this.Hide();
                }
                else
                {

                    frmTransaction objTran = new frmTransaction();
                    objTran.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Select Match");
            }
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentRegistration tr = new frmTournamentRegistration();
            tr.Show();
        }

        private void lblPrevious_Click(object sender, EventArgs e)
        {
            lstTour.Visible = true;
            btnId = "1";
            lstTour.Items.Clear();
            dt = new DataTable();
            panel8.Visible = true;
            dt = objNavigation.LoadTournament();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] array = new string[] { dt.Rows[i][0].ToString() };
                Array.Sort(array);
                lstTour.Items.AddRange(array);
                lstTour.Sorted = true;

            }
        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {
            btnId = "2";
            lstTour.Items.Clear();
            dt = new DataTable();
            dt = objNavigation.LoadTournament();
            lstTour.Visible = true;
            panel8.Visible = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] array = new string[] { dt.Rows[i][0].ToString() };
                Array.Sort(array);
                lstTour.Items.AddRange(array);
                lstTour.Sorted = true;

            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FOOTBALL APPLICATION 2016");
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            
           MessageBox.Show("GET SOON");
           
        }

        private void lbltour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Total__Registration tot = new Total__Registration();
            tot.Show();
        }

        private void lblteam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Total__Registration tot = new Total__Registration();
            tot.Show();
        }

        private void lblplayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Total__Registration tot = new Total__Registration();
            tot.Show();
        }

        private void lblmatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatch_Registration match = new frmMatch_Registration();
            match.Show();
        }

        private void lblreports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReports fr = new frmReports();

            fr.Show();
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            if (strMatchStatus != "" && strMatchStatus != null)
            {
                if (strMatchStatus == "InComplete" || strMatchStatus == "InCompleted")
                {
                    frmSquad_Registration objSquard = new frmSquad_Registration();
                    objSquard.Show();
                    this.Hide();
                }
                else
                {

                    frmTransaction objTran = new frmTransaction();
                    objTran.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Select Match");
            }

        }

        private void pnlball_Paint(object sender, PaintEventArgs e)
        {

               }

        private void pnlball_MouseDown(object sender, MouseEventArgs e)
        {
            if (strMatchStatus != "" && strMatchStatus != null)
            {
                if (strMatchStatus == "InComplete" || strMatchStatus == "InCompleted")
                {
                    frmSquad_Registration objSquard = new frmSquad_Registration();
                    objSquard.Show();
                    this.Hide();
                }
                else
                {

                    frmTransaction objTran = new frmTransaction();
                    objTran.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Select Match");
            }
    
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSquad_Registration squad = new frmSquad_Registration();
            squad.Show();
        }

        private void pnlregistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblviewnav_Click(object sender, EventArgs e)
        {
            pnlregistration.Visible = true;
            lblviewnav.Visible = false;


            panel7.Visible = false;
            panel8.Visible = false;
            lstTour.Visible = false;
            dgNavigation.Visible = false;

            lblback.Visible = false;
            lblstart.Visible = false;
            pnlball.Visible = false;
        }

        private void matchRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
