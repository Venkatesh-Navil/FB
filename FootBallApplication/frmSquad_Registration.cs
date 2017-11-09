using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Linq;
using BAL;

namespace FootBallApplication
{
    public partial class frmSquad_Registration : Form
    {
        
        bool yes1;
       
        ArrayList arsource = new ArrayList();
        ArrayList arDest = new ArrayList();
        DataTable team1, team2;
        DataTable sub1, sub2;
        DataTable dtcount = new DataTable();
        bool TeamA = false;
        bool TeamB = false;
        string TA, TB, Raidteam;
        int a;
        string finalteama, finalteamb;
        public frmSquad_Registration()
        {
            InitializeComponent();
        }
        clssquadRegistration objSquard = new clssquadRegistration();
        clsNavigation objNavigation = new clsNavigation();
        DataTable dt = new DataTable();
        private void frmSquad_Registration_Load(object sender, EventArgs e)
        {
            dtcount.Columns.Add("count", typeof(string));
            dt = new DataTable();
            dt = objSquard.Loadtour(clsGlobalValues.Tournament, clsGlobalValues.mid);
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
           
            dt = new DataTable();
            dt = objSquard.LoadMatchDetails(clsGlobalValues.Tournament, clsGlobalValues.mid);
            dataGridView1.DataSource = dt;


        }

        private void lstLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            count.Text = lstLeft.SelectedItems.Count.ToString();
        }

        private void btnLeftToRight_Click(object sender, EventArgs e)
        {

            count.Text = a.ToString();


            //lblPlayerCount.Text = "Players Count " + lstRight.Items.Count;
            if (lstRight.Items.Count < 11)
            {
                xxx();
                lstLeft.Focus();
                if (a > 7)
                {
                    MessageBox.Show("More than 7 Players");
                }


            }
            else
            {
                MessageBox.Show("Cannot add more than 11 players", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstLeft.SelectedIndex = -1;
            }
        }
        private void xxx()
        {
            int n1;
            if (lstLeft.SelectedIndex != -1)
            {
                if (lstLeft.SelectedItems.Count > 0)
                {
                    arsource.Clear();
                    for (int i = 0; i < 11; i++)
                    {
                        try
                        {
                            arsource.Add(lstLeft.SelectedItems[i].ToString());
                        }
                        catch { }
                    }
                    arDest.Clear();
                    for (int i = 0; i < lstRight.Items.Count; i++)
                    {
                        arDest.Add(lstRight.Items[i].ToString());
                    }

                    for (int k = 0; k < arsource.Count; k++)
                    {
                        if (!arDest.Contains(arsource[k].ToString()))
                        {
                            lstRight.Items.Add(arsource[k].ToString());
                            lstRight.ValueMember = "Player_Name";
                            lstRight.DisplayMember = "Player_Name";
                            lstLeft.Items.Remove(arsource[k].ToString());
                            count1.Text = lstLeft.Items.Count.ToString();
                        }
                    }
                }

                lstLeft.Refresh();
                lstRight.Refresh();
            }
            if (lstRight.SelectedIndex != -1)
            {
                lstLeft.Items.Add(lstRight.SelectedItem.ToString());
                lstRight.Items.Remove(lstRight.SelectedItem.ToString());
            }

            if (TeamA == true && TeamB == false)
            {
                cmbCaptonA.Items.Clear();
                try
                {

                    //captain
                    for (int i = 0; i < 11; i++)
                    {
                        cmbCaptonA.Items.Add(lstRight.Items[i].ToString());
                    }
                }
                catch { }
            }
            else if (TeamB == true && TeamA == false)
            {
                cmbCaptonB.Items.Clear();
                try
                {


                    for (int i = 0; i < 11; i++)
                    {
                        cmbCaptonB.Items.Add(lstRight.Items[i].ToString());
                    }
                }
                catch { }
            }


        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPlayerCount.Text = "Players Count " + lstRight.Items.Count;
                xxx();
                if (lstRight.Items.Count > 11)
                {
                    lstLeft.SelectedIndex = -1;

                    int n = lstRight.SelectedItems.Count;
                    for (int i = 0; i < n; i++)
                    {
                        if (lstRight.SelectedIndex != -1)
                        {
                            lstLeft.Items.Add(lstRight.SelectedItem.ToString());
                            lstRight.Items.Remove(lstRight.SelectedItem.ToString());

                            if (TeamA == true && TeamB == false)
                            {
                                cmbCaptonA.Items.Remove(lstRight.SelectedItem.ToString());
                            }
                            else if (TeamB == true && TeamB == false)
                            {
                                cmbCaptonB.Items.Remove(lstRight.SelectedItem.ToString());
                            }

                        }
                    }
                }
            }
            catch
            {
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            yes1 = true;


            if (lstRight.Items.Count > 7)
            {
                MessageBox.Show("You are not allowed to select more than 7 players", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yes1 = false;
            }
            else if (lstRight.Items.Count < 7)
            {
                MessageBox.Show("You should select 7 players", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                yes1 = false;
            }

            if (yes1 == true)
            {
                if (TeamA == true && TeamB == false)
                {
                    team1 = new DataTable();
                    team1.Columns.Add("Players", typeof(string));
                    for (int l = 0; l < lstRight.Items.Count; l++)
                    {
                        team1.Rows.Add(lstRight.Items[l].ToString());
                    }
                    sub1 = new DataTable();
                    sub1.Columns.Add("Players", typeof(string));
                    for (int l = 0; l < lstLeft.Items.Count; l++)
                    {
                        sub1.Rows.Add(lstLeft.Items[l].ToString());
                    }
                    MessageBox.Show("Playing 7 is saved", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TeamB == true && TeamA == false)
                {
                    team2 = new DataTable();
                    team2.Columns.Add("Players", typeof(string));
                    for (int l = 0; l < lstRight.Items.Count; l++)
                    {
                        team2.Rows.Add(lstRight.Items[l].ToString());
                    }
                    sub2 = new DataTable();
                    sub2.Columns.Add("Players", typeof(string));
                    for (int l = 0; l < lstLeft.Items.Count; l++)
                    {
                        sub2.Rows.Add(lstLeft.Items[l].ToString());
                    }
                    MessageBox.Show("Playing 7 is saved", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmbTossWonTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void players(DataTable dt)
            {

            chkp1.Text = dt.Rows[0][0].ToString();
            chkp2.Text = dt.Rows[1][0].ToString();
            chkp3.Text = dt.Rows[2][0].ToString();
            chkp4.Text = dt.Rows[3][0].ToString();
            chkp5.Text = dt.Rows[4][0].ToString();

            chkp6.Text = dt.Rows[5][0].ToString();
            chkp7.Text = dt.Rows[6][0].ToString();
            chkp8.Text = dt.Rows[7][0].ToString();
            chkp9.Text = dt.Rows[8][0].ToString();
            chkp10.Text = dt.Rows[9][0].ToString();
            chkp11.Text = dt.Rows[10][0].ToString();
            if (dt.Rows.Count == 12)
            {
                chkp12.Visible = true;
                chkp12.Text= dt.Rows[11][0].ToString();
                chkp12.Checked = true;


            }
            if (dt.Rows.Count == 13)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;


            }
            if (dt.Rows.Count == 14)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
               


            }
            if (dt.Rows.Count == 15)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;


            }
            if (dt.Rows.Count == 16)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                


            }
            if (dt.Rows.Count == 17)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;


            }
            if (dt.Rows.Count == 18)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();
                chkp18.Visible = true;
                chkp18.Text = dt.Rows[17][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;
                chkp18.Checked = true;
                chkp13.Checked = true;


            }
            if (dt.Rows.Count == 19)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();
                chkp18.Visible = true;
                chkp18.Text = dt.Rows[17][0].ToString();
                chkp19.Visible = true;
                chkp19.Text = dt.Rows[18][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;
                chkp18.Checked = true;
                chkp19.Checked = true;


            }
            if (dt.Rows.Count == 20)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();
                chkp18.Visible = true;
                chkp18.Text = dt.Rows[17][0].ToString();
                chkp19.Visible = true;
                chkp19.Text = dt.Rows[18][0].ToString();
                chkp20.Visible = true;
                chkp20.Text = dt.Rows[19][0].ToString();


                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;
                chkp18.Checked = true;
                chkp19.Checked = true;
                chkp20.Checked = true;


            }
            if (dt.Rows.Count == 21)
            {
                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();
                chkp18.Visible = true;
                chkp18.Text = dt.Rows[17][0].ToString();
                chkp19.Visible = true;
                chkp19.Text = dt.Rows[18][0].ToString();
                chkp20.Visible = true;
                chkp20.Text = dt.Rows[19][0].ToString();
                chkp21.Visible = true;
                chkp21.Text = dt.Rows[20][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;
                chkp18.Checked = true;
                chkp19.Checked = true;
                chkp20.Checked = true;
                chkp21.Checked = true;


            }
            if (dt.Rows.Count == 22)
            {

                chkp12.Visible = true;
                chkp13.Visible = true;
                chkp12.Text = dt.Rows[11][0].ToString();
                chkp13.Text = dt.Rows[12][0].ToString();
                chkp14.Visible = true;
                chkp14.Text = dt.Rows[13][0].ToString();
                chkp15.Visible = true;
                chkp15.Text = dt.Rows[14][0].ToString();

                chkp16.Visible = true;
                chkp16.Text = dt.Rows[15][0].ToString();
                chkp17.Visible = true;
                chkp17.Text = dt.Rows[16][0].ToString();
                chkp18.Visible = true;
                chkp18.Text = dt.Rows[17][0].ToString();
                chkp19.Visible = true;
                chkp19.Text = dt.Rows[18][0].ToString();
                chkp20.Visible = true;
                chkp20.Text = dt.Rows[19][0].ToString();
                chkp21.Visible = true;
                chkp21.Text = dt.Rows[20][0].ToString();
                chkp22.Visible = true;
                chkp22.Text = dt.Rows[21][0].ToString();

                chkp12.Checked = true;
                chkp13.Checked = true;
                chkp14.Checked = true;
                chkp15.Checked = true;
                chkp16.Checked = true;
                chkp17.Checked = true;
                chkp18.Checked = true;
                chkp19.Checked = true;
                chkp20.Checked = true;
                chkp21.Checked = true;
                chkp22.Checked = true;





            }
        }
        private void checkboxcheck()
        {
            chkp1.Checked = true;
            chkp2.Checked = true;
            chkp3.Checked = true;
            chkp4.Checked = true;
            chkp5.Checked = true;
            chkp6.Checked = true;
            chkp7.Checked = true;

            chkp8.Checked = true;
            chkp9.Checked = true; 
            chkp10.Checked = true;
            chkp11.Checked = true;
           
        }
        private void reset()
        {
            chkp1.Checked = false;
            chkp2.Checked = false;
            chkp3.Checked = false;
            chkp4.Checked = false;
            chkp5.Checked = false;
            chkp6.Checked = false;
            chkp7.Checked = false;
        
            chkp8.Checked = false;
            chkp9.Checked = false; chkp13.Checked = false;
            chkp10.Checked = false; chkp14.Checked = false;
            chkp11.Checked = false;
            chkp12.Checked = false;
            chkp15.Checked = false;
            chkp16.Checked = false;
            chkp17.Checked = false;
            chkp18.Checked = false;
            chkp19.Checked = false;
            chkp20.Checked = false;
            chkp21.Checked = false;
            chkp22.Checked = false;
        }
        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

            button2.Visible = true;

            chkp1.Visible = true;
            chkp2.Visible = true;
            chkp3.Visible = true;
            chkp4.Visible = true;
            chkp5.Visible = true;
            chkp6.Visible = true;
            chkp7.Visible = true;
            chkp8.Visible = true;
            chkp9.Visible = true;
            chkp10.Visible = true;
            chkp11.Visible = true;

            label4.Visible = true;
            label12.Visible = true;



            reset();
            checkboxcheck();

            DataTable dtteams = new DataTable();
            dtteams = objNavigation.Loadteams(comboBox1.Text);


            dt = new DataTable();

            dt = objSquard.LoadTeams(clsGlobalValues.mid, clsGlobalValues.Tournament);
            cmbTossWonTeam.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbTossWonTeam.Items.Add(dt.Rows[i][0].ToString());
            }

            dt = new DataTable();
            dt = objSquard.LoadPlayers(clsGlobalValues.Tournament, cmbTeams.SelectedItem.ToString());

            players(dt);


            if (dt.Rows.Count > 0)
            {
                //lstLeft.DataSource = dt;
                lstLeft.Items.Clear();
                lstRight.Items.Clear();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lstLeft.Items.Add(dt.Rows[i][0].ToString());

                    }
                }

                objSquard.AutoLoad(Convert.ToString(clsGlobalValues.mid), clsGlobalValues.Tournament);
            }



            if (dataGridView1.Rows[0].Cells[1].Value != null)
            {
                if (cmbTeams.SelectedItem.ToString() == dataGridView1.Rows[0].Cells[1].Value.ToString())
                {
                    TeamA = true;
                    TeamB = false;
                    finalteama = dataGridView1.Rows[0].Cells[1].Value.ToString();
                }
               

            }
            else
            {
                for (int i = 0; i < dtteams.Rows.Count; i++)
                {

                    if (cmbTeams.SelectedItem.ToString() == dtteams.Rows[i][0].ToString())
                    {
                        TeamA = true;
                        TeamB = false;
                        finalteama = dtteams.Rows[i][0].ToString();
                        break;
                    }
                    

                }
            }
            if (dataGridView1.Rows[0].Cells[2].Value != null)
            {
               
                 if (cmbTeams.SelectedItem.ToString() == dataGridView1.Rows[0].Cells[2].Value.ToString())
                {
                    TeamB = true;
                    TeamA = false;
                    finalteamb = dataGridView1.Rows[0].Cells[2].Value.ToString();
                }

            }
            else
            {
                for (int i = 0; i < dtteams.Rows.Count; i++)
                {

                     if (cmbTeams.SelectedItem.ToString() == dtteams.Rows[i][1].ToString())
                    {
                        TeamB = true;
                        TeamA = false;
                        finalteamb = dtteams.Rows[i][1].ToString();

                        break;
                    }

                }
            }

        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmNavigation fr = new frmNavigation();
            fr.Show();
        //    count.Text = a.ToString();


        //    //lblPlayerCount.Text = "Players Count " + lstRight.Items.Count;
        //    if (lstRight.Items.Count < 11)
        //    {
        //        xxx();
        //        lstLeft.Focus();
        //        if (a > 11)
        //        {
        //            MessageBox.Show("More than 11 Players");
        //        }


        //    }
        //    else
        //    {
        //        MessageBox.Show("Cannot add more than 11 players", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        lstLeft.SelectedIndex = -1;
        //    }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                //lblPlayerCount.Text = "Players Count " + lstRight.Items.Count;
                xxx();
                if (lstRight.Items.Count > 11)
                {
                    lstLeft.SelectedIndex = -1;

                    int n = lstRight.SelectedItems.Count;
                    for (int i = 0; i < n; i++)
                    {
                        if (lstRight.SelectedIndex != -1)
                        {
                            lstLeft.Items.Add(lstRight.SelectedItem.ToString());
                            lstRight.Items.Remove(lstRight.SelectedItem.ToString());

                            if (TeamA == true && TeamB == false)
                            {
                                cmbCaptonA.Items.Remove(lstRight.SelectedItem.ToString());
                            }
                            else if (TeamB == true && TeamB == false)
                            {
                                cmbCaptonB.Items.Remove(lstRight.SelectedItem.ToString());
                            }

                        }
                    }
                }
            }
            catch
            {
            }
           
        }
        private void playersave()
        {
            team1 = new DataTable();
            sub1 = new DataTable();
            team1.Columns.Add("Players", typeof(string));
            sub1.Columns.Add("Players", typeof(string));
            if (chkp1.Checked == true)
            {
                team1.Rows.Add(chkp1.Text);
            }
            else
            {
                sub1.Rows.Add(chkp1.Text);
            }
            if (chkp2.Checked == true)
            {
                team1.Rows.Add(chkp2.Text);
            }
            else
            {
                sub1.Rows.Add(chkp2.Text);
            }
            if (chkp3.Checked == true)
            {
                team1.Rows.Add(chkp3.Text);
            }
            else
            {
                sub1.Rows.Add(chkp3.Text);
            }
            if (chkp4.Checked == true)
            {
                team1.Rows.Add(chkp4.Text);
            }
            else
            {
                sub1.Rows.Add(chkp4.Text);
            }
            if (chkp5.Checked == true)
            {
                team1.Rows.Add(chkp5.Text);
            }
            else
            {
                sub1.Rows.Add(chkp5.Text);
            }
            if (chkp6.Checked == true)
            {
                team1.Rows.Add(chkp6.Text);
            }
            else
            {
                sub1.Rows.Add(chkp6.Text);
            }
            if (chkp7.Checked == true)
            {
                team1.Rows.Add(chkp7.Text);
            }
            else
            {
                sub1.Rows.Add(chkp7.Text);
            }
            if (chkp8.Checked == true)
            {
                team1.Rows.Add(chkp8.Text);
            }
            else
            {
                sub1.Rows.Add(chkp8.Text);
            }
            if (chkp9.Checked == true)
            {
                team1.Rows.Add(chkp9.Text);
            }
            else
            {
                sub1.Rows.Add(chkp9.Text);
            }
            if (chkp10.Checked == true)
            {
                team1.Rows.Add(chkp10.Text);
            }
            else
            {
                sub1.Rows.Add(chkp10.Text);
            }
            if (chkp11.Checked == true)
            {
                team1.Rows.Add(chkp11.Text);
            }
            else
            {
                sub1.Rows.Add(chkp11.Text);
            }
            if (chkp12.Checked == true)
            {
                team1.Rows.Add(chkp12.Text);
            }
            else
            {
                sub1.Rows.Add(chkp12.Text);
            }
            if (chkp13.Checked == true)
            {
                team1.Rows.Add(chkp13.Text);
            }
            else
            {
                sub1.Rows.Add(chkp13.Text);
            }
            if (chkp14.Checked == true)
            {
                team1.Rows.Add(chkp14.Text);
            }
            else
            {
                sub1.Rows.Add(chkp14.Text);
            }
            if (chkp15.Checked == true)
            {
                team1.Rows.Add(chkp15.Text);
            }
            else
            {
                sub1.Rows.Add(chkp15.Text);
            }
            if (chkp16.Checked == true)
            {
                team1.Rows.Add(chkp16.Text);
            }
            else
            {
                sub1.Rows.Add(chkp16.Text);
            }
            if (chkp17.Checked == true)
            {
                team1.Rows.Add(chkp17.Text);
            }
            else
            {
                sub1.Rows.Add(chkp17.Text);
            }
            if (chkp18.Checked == true)
            {
                team1.Rows.Add(chkp18.Text);
            }
            else
            {
                sub1.Rows.Add(chkp18.Text);
            }
            if (chkp19.Checked == true)
            {
                team1.Rows.Add(chkp19.Text);
            }
            else
            {
                sub1.Rows.Add(chkp19.Text);
            }
            if (chkp20.Checked == true)
            {
                team1.Rows.Add(chkp20.Text);
            }
            else
            {
                sub1.Rows.Add(chkp20.Text);
            }
            if (chkp21.Checked == true)
            {
                team1.Rows.Add(chkp21.Text);
            }
            else
            {
                sub1.Rows.Add(chkp21.Text);
            }
            if (chkp22.Checked == true)
            {
                team1.Rows.Add(chkp22.Text);
            }
            else
            {
                sub1.Rows.Add(chkp22.Text);
            }

        }
        private void playersave1()
        {
            team2 = new DataTable();
            sub2 = new DataTable();
            team2.Columns.Add("Players", typeof(string));
            sub2.Columns.Add("Players", typeof(string));
            if (chkp1.Checked == true)
            {
                team2.Rows.Add(chkp1.Text);
            }
            else
            {
                sub2.Rows.Add(chkp1.Text);
            }
            if (chkp2.Checked == true)
            {
                team2.Rows.Add(chkp2.Text);
            }
            else
            {
                sub2.Rows.Add(chkp2.Text);
            }
            if (chkp3.Checked == true)
            {
                team2.Rows.Add(chkp3.Text);
            }
            else
            {
                sub2.Rows.Add(chkp3.Text);
            }
            if (chkp4.Checked == true)
            {
                team2.Rows.Add(chkp4.Text);
            }
            else
            {
                sub2.Rows.Add(chkp4.Text);
            }
            if (chkp5.Checked == true)
            {
                team2.Rows.Add(chkp5.Text);
            }
            else
            {
                sub2.Rows.Add(chkp5.Text);
            }
            if (chkp6.Checked == true)
            {
                team2.Rows.Add(chkp6.Text);
            }
            else
            {
                sub2.Rows.Add(chkp6.Text);
            }
            if (chkp7.Checked == true)
            {
                team2.Rows.Add(chkp7.Text);
            }
            else
            {
                sub2.Rows.Add(chkp7.Text);
            }
            if (chkp8.Checked == true)
            {
                team2.Rows.Add(chkp8.Text);
            }
            else
            {
                sub2.Rows.Add(chkp8.Text);
            }
            if (chkp9.Checked == true)
            {
                team2.Rows.Add(chkp9.Text);
            }
            else
            {
                sub2.Rows.Add(chkp9.Text);
            }
            if (chkp10.Checked == true)
            {
                team2.Rows.Add(chkp10.Text);
            }
            else
            {
                sub2.Rows.Add(chkp10.Text);
            }
            if (chkp11.Checked == true)
            {
                team2.Rows.Add(chkp11.Text);
            }
            else
            {
                sub2.Rows.Add(chkp11.Text);
            }
            if (chkp12.Checked == true)
            {
                team2.Rows.Add(chkp12.Text);
            }
            else
            {
                sub2.Rows.Add(chkp12.Text);
            }
            if (chkp13.Checked == true)
            {
                team2.Rows.Add(chkp13.Text);
            }
            else
            {
                sub2.Rows.Add(chkp13.Text);
            }
            if (chkp14.Checked == true)
            {
                team2.Rows.Add(chkp14.Text);
            }
            else
            {
                sub2.Rows.Add(chkp14.Text);
            }
            if (chkp15.Checked == true)
            {
                team2.Rows.Add(chkp15.Text);
            }
            else
            {
                sub2.Rows.Add(chkp15.Text);
            }
            if (chkp16.Checked == true)
            {
                team2.Rows.Add(chkp16.Text);
            }
            else
            {
                sub2.Rows.Add(chkp16.Text);
            }
            if (chkp17.Checked == true)
            {
                team2.Rows.Add(chkp17.Text);
            }
            else
            {
                sub2.Rows.Add(chkp17.Text);
            }
            if (chkp18.Checked == true)
            {
                team2.Rows.Add(chkp18.Text);
            }
            else
            {
                sub2.Rows.Add(chkp18.Text);
            }
            if (chkp19.Checked == true)
            {
                team2.Rows.Add(chkp19.Text);
            }
            else
            {
                sub2.Rows.Add(chkp19.Text);
            }
            if (chkp20.Checked == true)
            {
                team2.Rows.Add(chkp20.Text);
            }
            else
            {
                sub2.Rows.Add(chkp20.Text);
            }
            if (chkp21.Checked == true)
            {
                team2.Rows.Add(chkp21.Text);
            }
            else
            {
                sub2.Rows.Add(chkp21.Text);
            }
            if (chkp22.Checked == true)
            {
                team2.Rows.Add(chkp22.Text);
            }
            else
            {
                sub2.Rows.Add(chkp22.Text);
            }

        }

        private void chkp1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp1.Checked == true)
            {


                dtcount.Rows.Add(chkp1.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count-1);
            }
        }

        private void chkp2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp2.Checked == true)
            {


                dtcount.Rows.Add(chkp2.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp3.Checked == true)
            {


                dtcount.Rows.Add(chkp3.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp4.Checked == true)
            {


                dtcount.Rows.Add(chkp4.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
        }

        private void chkp5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp5.Checked == true)
            {


                dtcount.Rows.Add(chkp5.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp6.Checked == true)
            {


                dtcount.Rows.Add(chkp6.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp7.Checked == true)
            {


                dtcount.Rows.Add(chkp7.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp8.Checked == true)
            {


                dtcount.Rows.Add(chkp8.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp9.Checked == true)
            {


                dtcount.Rows.Add(chkp9.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp10.Checked == true)
            {


                dtcount.Rows.Add(chkp10.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp11_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp11.Checked == true)
            {


                dtcount.Rows.Add(chkp11.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp12_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp12.Checked == true)
            {


                dtcount.Rows.Add(chkp12.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp13_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp13.Checked == true)
            {


                dtcount.Rows.Add(chkp13.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp14_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp14.Checked == true)
            {


                dtcount.Rows.Add(chkp14.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp15_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp15.Checked == true)
            {


                dtcount.Rows.Add(chkp15.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp16_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp16.Checked == true)
            {


                dtcount.Rows.Add(chkp16.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp17_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp17.Checked == true)
            {


                dtcount.Rows.Add(chkp17.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp18_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp18.Checked == true)
            {


                dtcount.Rows.Add(chkp18.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp19_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp19.Checked == true)
            {


                dtcount.Rows.Add(chkp19.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp20_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp20.Checked == true)
            {


                dtcount.Rows.Add(chkp20.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp21_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp21.Checked == true)
            {


                dtcount.Rows.Add(chkp21.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {
                dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void chkp22_CheckedChanged(object sender, EventArgs e)
        {
            if (chkp22.Checked == true)
            {


                dtcount.Rows.Add(chkp22.Text);
                label4.Text = Convert.ToString(dtcount.Rows.Count);
            }
            else
            {  dtcount.Rows[0].Delete();
                label4.Text = Convert.ToString(dtcount.Rows.Count );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //playersave();
            yes1 = true;


            if (label4.Text == "11")
            {
                MessageBox.Show(cmbTeams.SelectedItem.ToString()  +" " +"Squad Registered");
            }
            else
            {
                MessageBox.Show("Please select 11 players");
                yes1 = false;
            }

           

            if (yes1 == true)
            {
                if (TeamA == true && TeamB == false)
                {
                    playersave();
                    cmbCaptonA.Items.Clear();
                    for (int i = 0; i < team1.Rows.Count; i++)
                    {
                        cmbCaptonA.Items.Add(team1.Rows[i][0].ToString());
                    }
                    
                    //team1 = new DataTable();
                    //team1.Columns.Add("Players", typeof(string));
                    //for (int l = 0; l < lstRight.Items.Count; l++)
                    //{
                    //    team1.Rows.Add(lstRight.Items[l].ToString());
                    //}
                    //sub1 = new DataTable();
                    //sub1.Columns.Add("Players", typeof(string));
                    //for (int l = 0; l < lstLeft.Items.Count; l++)
                    //{
                    //    sub1.Rows.Add(lstLeft.Items[l].ToString());
                    //}
                    //MessageBox.Show("Playing 11 is saved", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (TeamB == true && TeamA == false)
                {
                    playersave1();
                    cmbCaptonB.Items.Clear();
                    for (int i = 0; i < team2.Rows.Count; i++)
                    {
                        cmbCaptonB.Items.Add(team2.Rows[i][0].ToString());
                    }
                    //team2 = new DataTable();
                    //team2.Columns.Add("Players", typeof(string));
                    //for (int l = 0; l < lstRight.Items.Count; l++)
                    //{
                    //    team2.Rows.Add(lstRight.Items[l].ToString());
                    //}
                    //sub2 = new DataTable();
                    //sub2.Columns.Add("Players", typeof(string));
                    //for (int l = 0; l < lstLeft.Items.Count; l++)
                    //{
                    //    sub2.Rows.Add(lstLeft.Items[l].ToString());
                    //}
                    //MessageBox.Show("Playing 11 is saved", "Raider", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lblstart_Click(object sender, EventArgs e)
        {

            //if (cmbTossWonTeam.Text != "")
            //{
                string raidteam = GetRaidTeam();
                objSquard.Insert_player(team1, team2, sub1, sub2, clsGlobalValues.Tournament, clsGlobalValues.mid, finalteama, finalteamb, cmbTossWonTeam.Text, cmbDecision.Text, cmbCaptonA.Text, cmbCaptonB.Text, cmbUmpire1.Text, cmbUmpire2.Text, cmbRefree.Text, "", raidteam);
              this.Hide();
                frmpositions frm = new frmpositions();
               frm.Show();
               

            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
            
           
        }

        private string GetRaidTeam()
        {

           // if (cmbTossWonTeam.SelectedIndex != -1 && cmbDecision.SelectedIndex != -1)
            //{
                //dt = new DataTable();
                //dt = objSquard.LoadTeams(clsGlobalValues.mid, clsGlobalValues.Tournament);

               //
                    //TA = cmbTossWonTeam.Items[0].ToString();
                    //TB = cmbTossWonTeam.Items[1].ToString();
                    //if ((cmbTossWonTeam.SelectedItem.ToString() == TA && cmbDecision.SelectedItem.ToString() == "Kick") || (cmbTossWonTeam.SelectedItem.ToString() == TB && cmbDecision.SelectedItem.ToString() == "Side"))
                    //{
                    //    Raidteam = TA;
                    //}
                    //else
                    //{
                    //    Raidteam = TB;
                    //}
                
           // }
            return "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count1.Visible = false;
            dt = new DataTable();
            dt = objSquard.LoadTeams(clsGlobalValues.mid, comboBox1.SelectedItem.ToString());
            cmbTeams.Items.Clear();
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                cmbTeams.Items.Add(dt.Rows[i][0].ToString());
            }
            cmbTeams.Text = cmbTeams.Items[0].ToString();
            lblcapA.Text = cmbTeams.Items[0].ToString()+" Captain";
            lblcapB.Text = cmbTeams.Items[1].ToString()+" Captain";
        }
    }
}
