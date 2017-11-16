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
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        clsgrid objgrid = new clsgrid();
        int Gridid;
        string Tournament;
        string Team;
        private void frmGrid_Load(object sender, EventArgs e)
        {
            
           

        }
        public frmGrid(string tour,string team,int id)
        {
            Gridid = id;
            Tournament = tour;
            InitializeComponent();
            if (id == 1)
            {//gvTeam.Visible=false;
                
               
                try
                {
                    gvTeam.Visible = true;

                    dt = new DataTable();
                    dt = objgrid.LoadGridTour(tour); ;
                    gvTeam.DataSource = dt;
                }
                catch
                {
                }
            }
            else if (id == 2)
            {
                try
                {
                    
                    gvTeam.Visible = true;
                    dt = new DataTable();
                    dt = objgrid.LoadGrid(tour);
                    gvTeam.DataSource = dt;
                    
                }
                catch
                {
                }

            }
            else if (id == 3)
            {
                try
                {
                   
                        gvTeam.Visible = true;
                        dt = new DataTable();
                        dt = objgrid.view_squad(tour, team);
                        gvTeam.DataSource = dt;
                    
                }
                catch
                {
                }
            }
                
        }
        private void GridAlign()
        {
        //    dgNavigation.Columns[0].Width = 70;
        //    dgNavigation.Columns[1].Width = 70;
        //    dgNavigation.Columns[2].Width = 100;
        //    dgNavigation.Columns[3].Width = 100;
        //    dgNavigation.Columns[4].Width = 100;
        //    dgNavigation.Columns[5].Width = 100;



        //    dgNavigation.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgNavigation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgNavigation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgNavigation.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgNavigation.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgNavigation.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    // dgNavigation.Width = 520;
        //    dgNavigation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgNavigation.ReadOnly = true;
        }

        private void gvTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            if (Gridid == 1)
            {
                int selindex = e.RowIndex;
                if (selindex != -1)
                {


                    dt = new DataTable();
                    dt = objgrid.GetTourOnGridClick( gvTeam.Rows[selindex].Cells[1].Value.ToString());
                    if (dt.Rows.Count > 0)
                    {
                        string Id = dt.Rows[0][0].ToString();
                        string Tour= dt.Rows[0][2].ToString();
                        string Start = dt.Rows[0][3].ToString();
                        string End = dt.Rows[0][4].ToString();
                        string Country = dt.Rows[0][7].ToString();
                        string VideoPath = dt.Rows[0][10].ToString();
                        string Category = dt.Rows[0][11].ToString();
//
                        Total__Registration tot = new Total__Registration(Id,Tour,Start,End,Country,VideoPath,Category);
                        tot.Show();

                    }
                    else
                    {
                        MessageBox.Show("There are no team");
                        Total__Registration tot = new Total__Registration();
                        tot.Show();
                    }
                }
            }
            else  if(Gridid==2)
            {
            int selindex = e.RowIndex;
            if (selindex != -1)
            {


                dt = new DataTable();
                dt = objgrid.GetTeamOnGridClick(Tournament, gvTeam.Rows[selindex].Cells[0].Value.ToString());
                if (dt.Rows.Count > 0)
                {
                    string txtManager = dt.Rows[0][5].ToString();
                    string txtCoach = dt.Rows[0][4].ToString();
                    string txtTeamName = dt.Rows[0][2].ToString();
                    byte[] array = (byte[])dt.Rows[0][3];
                    //pnlFlag.Visible = true;
                    //MemoryStream ms = new MemoryStream(array);
                    //pnlFlag.BackgroundImage = Image.FromStream(ms);
                    string txtTeamFlag = "Default";
                    Total__Registration tot = new Total__Registration(Tournament, txtManager, txtCoach, txtTeamName, array, txtTeamFlag);
                    tot.Show();

                }
                else
                {
                    //MessageBox.Show("There are no team");
                   Total__Registration tot = new Total__Registration();
                    tot.Show();
                }
            }
            }
            else if(Gridid==3)
            {
                int selindex = e.RowIndex;
                if (selindex != -1)
                {


                    dt = new DataTable();


                    dt = objgrid.GetPlayersOnGridClick(Tournament, gvTeam.Rows[selindex].Cells[0].Value.ToString(), gvTeam.Rows[selindex].Cells[1].Value.ToString());
                    if (dt.Rows.Count > 0)
                    {


                        string TxtPlayer = dt.Rows[0][3].ToString();
                        string cmbPosition = dt.Rows[0][4].ToString();
                        //txtPlayerImg.Text = "Default";
                        byte[] array = (byte[])dt.Rows[0][5];
                        //pnlImg.Visible = true;
                        //MemoryStream ms = new MemoryStream(array);
                        //pnlImg.BackgroundImage = Image.FromStream(ms);
                        string txtPlayerImg = "Default";
                        string TxtJersey = dt.Rows[0][6].ToString();
                        int id = 1;
                        Total__Registration tot = new Total__Registration(Tournament, gvTeam.Rows[selindex].Cells[0].Value.ToString(), TxtPlayer, cmbPosition, txtPlayerImg, array, TxtJersey, id);
                        tot.Show();


                    }
                    else
                    {
                        MessageBox.Show("There are no players");
                        Total__Registration tot = new Total__Registration();
                        tot.Show();
                    }
                }
            }
        }

        private void frmGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
           // Total__Registration tot = new Total__Registration();
            //tot.Show();
        }
    }
}
