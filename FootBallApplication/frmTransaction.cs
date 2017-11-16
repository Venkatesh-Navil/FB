using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Video.VFW;
using AForge;
using AForge.Video.FFMPEG;
using BAL;
namespace FootBallApplication
{
    public partial class frmTransaction : Form
    {
        DataTable dt = new DataTable();
       
        public frmTransaction()
        {
            InitializeComponent();
        }
        clstransaction trans = new clstransaction();
        string playernamehover = "";
        System.Drawing.Point p1, p2;
        Graphics g;
        int points=0;
        int x;
        int y;
        string player="";
        string team1 = "";
        string team2 = "";
        DataTable dt5;
        string start = "Start";
        string filename = "";
        private FilterInfoCollection videoDevices;
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevicesPlayer;
        private VideoCaptureDevice videoCaptureSource = null;
        bool FirstTime = true;
        int Height, Width;
        VideoFileWriter Playerwriter = new VideoFileWriter();
        string Shot = "";
        private Boolean isRecord = false;
        ArrayList alX = new ArrayList();
        string teamA, teamB, Coordinates="";
        string videopath = "";
        string playerentry = "";
        string toplayer = "";
        string subteam = "";
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            try
            {


                btnpause.Text = "Pause";
                pnlrecording.Visible = false;//load team

                lbltour.Text = clsGlobalValues.Tournament;
                dt = new DataTable();
                dt = trans.Loadteam(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);
                DataTable dt5 = trans.LoadDay(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);
                lbldate.Text = dt5.Rows[0][0].ToString();
                if (dt.Rows.Count > 0)
                {
                    lblteamA.Text = dt.Rows[0][0].ToString();
                    lblteamB.Text = dt.Rows[0][1].ToString();

                }
                try
                {
                    general();
                }
                catch

                {
                }
                //load team a players
                dt = new DataTable();
                dt = trans.Loadplayer(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);

                if (dt.Rows.Count > 0)
                {
                    lblteamA.Text = dt.Rows[0][1].ToString();

                    btntma1.Text = dt.Rows[0][0].ToString();
                    btntma2.Text = dt.Rows[1][0].ToString();
                    btntma3.Text = dt.Rows[2][0].ToString();
                    btntma4.Text = dt.Rows[3][0].ToString();
                    btntma5.Text = dt.Rows[4][0].ToString();
                    btntma6.Text = dt.Rows[5][0].ToString();
                    btntma7.Text = dt.Rows[6][0].ToString();
                    btntma8.Text = dt.Rows[7][0].ToString();
                    btntma9.Text = dt.Rows[8][0].ToString();
                    btntma10.Text = dt.Rows[9][0].ToString();


                }

                //load team b players
                dt = new DataTable();
                dt = trans.Loadplayer(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamB.Text);

                if (dt.Rows.Count > 0)
                {
                    lblteamB.Text = dt.Rows[0][1].ToString();

                    btntmb1.Text = dt.Rows[0][0].ToString();
                    btntmb1.Text = dt.Rows[1][0].ToString();
                    btntmb1.Text = dt.Rows[2][0].ToString();
                    btntmb1.Text = dt.Rows[3][0].ToString();
                    btntmb1.Text = dt.Rows[4][0].ToString();
                    btntmb1.Text = dt.Rows[5][0].ToString();
                    btntmb1.Text = dt.Rows[6][0].ToString();
                    btntmb1.Text = dt.Rows[7][0].ToString();
                    btntmb1.Text = dt.Rows[8][0].ToString();
                    btntmb1.Text = dt.Rows[9][0].ToString();


                }

                dt = new DataTable();
                dt = trans.Loadgoalkeeper(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);
                if (dt.Rows.Count > 0)
                {
                    btngkA.Text = dt.Rows[0][0].ToString();
                }


                dt = new DataTable();
                dt = trans.Loadgoalkeeper(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);
                if (dt.Rows.Count > 0)
                {
                    btngkB.Text = dt.Rows[0][0].ToString();
                }
            }
            catch
            {

            }
           
        }
        private void update()
        {
            dt = new DataTable();
            dt = trans.Load1sttime(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text);
            if (dt.Rows.Count > 0)
            {
                string max = trans.undomax(clsGlobalValues.Tournament, clsGlobalValues.mid);
                trans.update(clsGlobalValues.mid, clsGlobalValues.Tournament, lblteamA.Text,max,toplayer);
            }
        }
        private void insert()
        {
            if (alX.Count >= 1)
            {
                Coordinates = string.Join(",", alX.ToArray());
            }

            if (Shot != "")
            {

                trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid,team1,team2, player, Shot, Coordinates, points, toplayer,team1);
                alX.Clear();
                general();
                playerentry = btntma1.Text;






                // p1 = new System.Drawing.Point();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pnlpitch_MouseDown(object sender, MouseEventArgs e)
        {
            int duration = 0; int seconds;
            timer1.Enabled = true;
            timer1.Start();


            if (e.Button == MouseButtons.Left)
            {
                if (p1 == System.Drawing.Point.Empty)
                {
                    p1 = e.Location;
                }
                else
                {
                    pnlpitch.BackgroundImage = Properties.Resources.Ground___Transaction_page;
                    p2 = e.Location;
                    this.DrawLine();
                    p1 = p2;
                    p2 = System.Drawing.Point.Empty;
                    p1= System.Drawing.Point.Empty;




                }
            }
        }
        private void DrawLine()
        {
            using (var p = new Pen(Color.Maroon, 2))
            {
                g = Graphics.FromImage(pnlpitch.BackgroundImage);
                g.DrawLine(p, p1, p2);
                g.Dispose();

                this.pnlpitch.Refresh();
            }
        }

        private void btnoffside_Click(object sender, EventArgs e)
        {
            Shot = btnoffside.Text;
            insert();
        }

        private void btnpass_Click(object sender, EventArgs e)
        {
            Shot = btnpass.Text;
            if (alX.Count >= 1)
            {
                Coordinates = string.Join(",", alX.ToArray());
            }
            insert();
        }

       
        private void pnlpitch_MouseClick(object sender, MouseEventArgs e)
        {
           // alX.Clear();

            string CoOrd = e.X + "," + e.Y + "@";
            alX.Add(CoOrd);
             x = (e.X);
             y = (e.Y); 
            
        }
        private void general()
        {
            pnlpitch.BackgroundImage = Properties.Resources.Ground___Transaction_page;
            DataTable pointsA = trans.LoadScore(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text);

           
            DataTable pointsB = trans.LoadScore(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text);

            if (pointsA.Rows[0][0].ToString()!="")
            {
                lblscoreA.Text = pointsA.Rows[0][0].ToString();

            }
            else
            {
                lblscoreA.Text = "0";
            }
            if (pointsB.Rows[0][0].ToString()!="")
            {
               
                lblscoreB.Text = pointsB.Rows[0][0].ToString();
            }
            else
            {
                lblscoreB.Text = "0";
            }
            
        }
        
        private void btntma1_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;

            if (chkSub.Checked == false)
            {
                player = btntma1.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma1.BackColor = Color.Gold;
                btntma1.ForeColor = Color.Black;
                toplayer = btntma1.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                //btntma1.BackColor = Color.Gold;
                //btntma1.ForeColor = Color.Black;



                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, playerentry,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //    playerentry = btntma1.Text;


                //    // p1 = new System.Drawing.Point();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(450, 400);
            }
        }
        private void btntma2_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;
                player = btntma2.Text;

                btntma2.BackColor = Color.Gold;
                btntma2.ForeColor = Color.Black;
               
                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;

    

                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;

                color1();

                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, playerentry,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //    playerentry = btntma2.Text;
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(490, 400);
            }

        }

        private void btntma3_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma3.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma3.BackColor = Color.Gold;
                btntma3.ForeColor = Color.Black;
                toplayer = btntma3.Text;
                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();update();

                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, playerentry,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //    playerentry = btntma3.Text;
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(534, 400);
            }
        }

        private void btntma4_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;

            if (chkSub.Checked == false)
            {
                player = btntma4.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                lstSubA.Visible = false;
                lstSub.Visible = false;

                btntma4.BackColor = Color.Gold;
                btntma4.ForeColor = Color.Black;
                toplayer = btntma4.Text;
                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma4.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(578, 400);
            }
            

        }

        private void btntma5_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma5.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Gold;
                btntma5.ForeColor = Color.Black;
                toplayer = btntma5.Text;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma5.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(622, 400);
            }

        }

        private void btntma6_Click(object sender, EventArgs e)
        {

            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma6.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Gold;
                btntma6.ForeColor = Color.Black;
                toplayer = btntma6.Text;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                lstSubA.Visible = false;
                lstSub.Visible = false;
                color1();
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma6.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(666, 400);
            }
        }

        private void btntma7_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma7.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;
                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Gold;
                btntma7.ForeColor = Color.Black;
                toplayer = btntma7.Text;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma7.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(710, 400);
            }

        }

        private void btntma8_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma8.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Gold;
                btntma8.ForeColor = Color.Black;
                toplayer = btntma8.Text;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma8.Text,  Shot, Coordinates, points,toplayer);

                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(754, 400);
            }
        }

        private void btntma9_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma9.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Gold;
                btntma9.ForeColor = Color.Black;
                toplayer = btntma9.Text;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma9.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(798, 400);
            }
        }

        private void color1()
        {
            btntmb2.BackColor = Color.Silver;
            btntmb2.ForeColor = Color.Black;

            btntmb1.BackColor = Color.Silver;
            btntmb1.ForeColor = Color.Black;



            btntmb3.BackColor = Color.Silver;
            btntmb3.ForeColor = Color.Black;

            btntmb4.BackColor = Color.Silver;
            btntmb4.ForeColor = Color.Black;

            btntmb5.BackColor = Color.Silver;
            btntmb5.ForeColor = Color.Black;

            btntmb6.BackColor = Color.Silver;
            btntmb6.ForeColor = Color.Black;

            btntmb7.BackColor = Color.Silver;
            btntmb7.ForeColor = Color.Black;

            btntmb8.BackColor = Color.Silver;
            btntmb8.ForeColor = Color.Black;

            btntmb9.BackColor = Color.Silver;
            btntmb9.ForeColor = Color.Black;

            btntmb10.BackColor = Color.Silver;
            btntmb10.ForeColor = Color.Black;

            btngkB.BackColor = Color.Silver;
            btngkB.ForeColor = Color.Black;
        }

        private void btntma10_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
            if (chkSub.Checked == false)
            {
                player = btntma10.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;



                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Gold;
                btntma10.ForeColor = Color.Black;
                toplayer = btntma10.Text;

                btngkA.BackColor = Color.Silver;
                btngkA.ForeColor = Color.Black;
                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btntma10.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(846, 400);
            }
        }

        private void btntmb1_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb1.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Gold;
                btntmb1.ForeColor = Color.Black;
                toplayer = btntmb1.Text;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb1.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(-3, 156);
            }

        }

        private void btntmb2_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                player = btntmb2.Text;

                btntmb2.BackColor = Color.Gold;
                btntmb2.ForeColor = Color.Black;
                toplayer = btntmb2.Text;
                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb2.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}

                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(44, 156);
            }
        }

        private void btntmb3_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;

            if (chkSub.Checked == false)
            {
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                player = btntmb3.Text;

                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Gold;
                btntmb3.ForeColor = Color.Black;
                toplayer = btntmb3.Text;
                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();

                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb3.Text,  Shot, Coordinates, points,toplayer);

                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(88, 156);
            }

        }

        private void btntmb4_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb4.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Gold;
                btntmb4.ForeColor = Color.Black;
                toplayer = btntmb4.Text;
                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();

                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb4.Text,  Shot, Coordinates, points,toplayer);

                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(132, 156);
            }
        }

        private void btntmb5_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb5.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;

                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Gold;
                btntmb5.ForeColor = Color.Black;
                toplayer = btntmb5.Text;
                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();

                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb5.Text,  Shot, Coordinates, points,toplayer);

                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(176, 156);
            }
        }

        private void btntmb6_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                player = btntmb6.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Gold;
                btntmb6.ForeColor = Color.Black;
                toplayer = btntmb6.Text;
                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();

                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb6.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(220, 156);
            }
        }

        private void btntmb7_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb7.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Gold;
                btntmb7.ForeColor = Color.Black;
                toplayer = btntmb7.Text;
                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb7.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(264, 156);
            }

        }

        private void btntmb8_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb8.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Gold;
                btntmb8.ForeColor = Color.Black;
                toplayer = btntmb8.Text;
                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb8.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(308, 156);
            }
        }

        private void btntmb9_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                player = btntmb9.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Gold;
                btntmb9.ForeColor = Color.Black;
                toplayer = btntmb9.Text;
                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                // insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb9.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(352, 156);
            }
        }

        private void btntmb10_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;
            if (chkSub.Checked == false)
            {
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                player = btntmb10.Text;

                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Gold;
                btntmb10.ForeColor = Color.Black;
                toplayer = btntmb10.Text;
                btngkB.BackColor = Color.Silver;
                btngkB.ForeColor = Color.Black;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btntmb10.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(400, 156);
            }
        }

        private void btncross1_Click(object sender, EventArgs e)
        {
            Shot = btncross1.Text;
            insert();
        }

        private void btnthrowin_Click(object sender, EventArgs e)
        {
            Shot = btnthrowin.Text;
            insert();
        }

        private void btnblocked_Click(object sender, EventArgs e)
        {
            Shot = btnblocked.Text;
            insert();
        }

        private void btninter_Click(object sender, EventArgs e)
        {
            Shot = btninter.Text;
            insert();
        }

        private void btnheaderwon_Click(object sender, EventArgs e)
        {
            Shot = btnheaderwon.Text;
            insert();
        }

        private void btnthrough_Click(object sender, EventArgs e)
        {
            Shot = btnthrough.Text;
            insert();
        }

        private void btnfoulagainst_Click(object sender, EventArgs e)
        {
            Shot = btnfoulagainst.Text;
            insert();
        }

        private void btnshoton_Click(object sender, EventArgs e)
        {
            Shot = btnshoton.Text;
            insert();

        }
        private void goal()
        {
            Coordinates = string.Join(",", alX.ToArray());
            
                points = 1;
                trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, team1, team2, player,  Shot, Coordinates, points,toplayer,team1);
                alX.Clear();
                MessageBox.Show("Goal");
                pnlpitch.BackgroundImage = Properties.Resources.Ground___Transaction_page;
                points = 0;

           
        }

        private void btngoal_Click(object sender, EventArgs e)
        {
            Shot = btngoal.Text;
            insert();
            //goal();
            general();
           

        }

        private void btnclearance_Click(object sender, EventArgs e)
        {
            Shot = btnclearance.Text;
            insert();
        }

        private void btnballwon_Click(object sender, EventArgs e)
        {
            Shot = btnballwon.Text;
            insert();

        }

        private void btnpassinfinal_Click(object sender, EventArgs e)
        {
            Shot = btnpassinfinal.Text;
            insert();
        }

        private void btnscondball_Click(object sender, EventArgs e)
        {
            Shot = btnscondball.Text;
            insert();
        }

        private void btntackle_Click(object sender, EventArgs e)
        {
            Shot = btntackle.Text;
            insert();
        }

        private void btnballscored_Click(object sender, EventArgs e)
        {
            //Shot = btnballscored.Text;
            insert();
            goal();

            general();
            color1();
            color2();

        }

        private void btnusp_Click(object sender, EventArgs e)
        {
            Shot = btnusp.Text;
            insert();
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            Shot = btncross.Text;
            insert();
        }

        private void btnheader_Click(object sender, EventArgs e)
        {
            Shot = btnheader.Text;
            insert();
        }

        private void btnutb_Click(object sender, EventArgs e)
        {
            Shot = btnutb.Text;
            insert();

        }

        private void btnfoul_Click(object sender, EventArgs e)
        {
            Shot = btnfoul.Text;
            insert();

        }

        private void btnsot_Click(object sender, EventArgs e)
        {
            Shot = btnsot.Text;
            insert();

        }

        private void btnballlost_Click(object sender, EventArgs e)
        {
            Shot = btnballlost.Text;
            insert();
        }

        private void btnuclear_Click(object sender, EventArgs e)
        {
            Shot = btnuclear.Text;
            insert();
        }

        private void btnredcard_Click(object sender, EventArgs e)
        {
            Shot = btnredcard.Text;
            insert();

        }

        private void btnutpf_Click(object sender, EventArgs e)
        {
            Shot = btnutpf.Text;
            insert();
        }

        private void btnyellowcard_Click(object sender, EventArgs e)
        {
            Shot = btnyellowcard.Text;
            insert();
        }

        private void btnut_Click(object sender, EventArgs e)
        {
            Shot = btnut.Text;
            insert();
        }

        private void btnown_Click(object sender, EventArgs e)
        {
            Shot = btnown.Text;
            insert();

        }

        private void btnuti_Click(object sender, EventArgs e)
        {
            Shot = btnuti.Text;
            insert();
        }

        private void btnsecondball_Click(object sender, EventArgs e)
        {
            Shot = btnsecondball.Text;
            insert();
        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            pnlpitch.BackgroundImage = Properties.Resources.Ground___Transaction_page;
            
            
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
           // frmNavigation nav = new frmNavigation();
           // nav.Show();
            this.Close();
        }

        private void pnlpitch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }
        private void sub()
        {
            lstSubA.Visible = false;
            lstSub.Visible = false;
            lstSubA.Items.Clear();
            lstSub.Items.Clear();
            if (subteam == lblteamA.Text)
            {
                dt=trans.loadsubPlayer(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lstSubA.Items.Add(dt.Rows[i][0].ToString());
                    lstSubA.Visible = true;
                }
            }
            if (subteam == lblteamB.Text)
            {
                dt =trans.loadsubPlayer(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lstSub.Items.Add(dt.Rows[i][0].ToString());
                    lstSub.Visible = true;
                }
            }
            
          
            
        }private void color2()
        {
            btntma1.BackColor = Color.Silver;
            btntma1.ForeColor = Color.Black;

            btntma2.BackColor = Color.Silver;
            btntma2.ForeColor = Color.Black;

            btntma3.BackColor = Color.Silver;
            btntma3.ForeColor = Color.Black;

            btntma4.BackColor = Color.Silver;
            btntma4.ForeColor = Color.Black;

            btntma5.BackColor = Color.Silver;
            btntma5.ForeColor = Color.Black;

            btntma6.BackColor = Color.Silver;
            btntma6.ForeColor = Color.Black;

            btntma7.BackColor = Color.Silver;
            btntma7.ForeColor = Color.Black;

            btntma8.BackColor = Color.Silver;
            btntma8.ForeColor = Color.Black;

            btntma9.BackColor = Color.Silver;
            btntma9.ForeColor = Color.Black;

            btntma10.BackColor = Color.Silver;
            btntma10.ForeColor = Color.Black;

            btngkA.BackColor = Color.Silver;
            btngkA.ForeColor = Color.Black;
        }
        private void btngkA_Click(object sender, EventArgs e)
        {
            subteam = lblteamA.Text;
               
            if (chkSub.Checked == false)
            {
                player = btngkA.Text;
                team1 = lblteamA.Text;
                team2 = lblteamB.Text;


                toplayer = btngkA.Text;
                btntma1.BackColor = Color.Silver;
                btntma1.ForeColor = Color.Black;

                btntma2.BackColor = Color.Silver;
                btntma2.ForeColor = Color.Black;

                btntma3.BackColor = Color.Silver;
                btntma3.ForeColor = Color.Black;

                btntma4.BackColor = Color.Silver;
                btntma4.ForeColor = Color.Black;

                btntma5.BackColor = Color.Silver;
                btntma5.ForeColor = Color.Black;

                btntma6.BackColor = Color.Silver;
                btntma6.ForeColor = Color.Black;

                btntma7.BackColor = Color.Silver;
                btntma7.ForeColor = Color.Black;

                btntma8.BackColor = Color.Silver;
                btntma8.ForeColor = Color.Black;

                btntma9.BackColor = Color.Silver;
                btntma9.ForeColor = Color.Black;

                btntma10.BackColor = Color.Silver;
                btntma10.ForeColor = Color.Black;

                btngkA.BackColor = Color.Gold;
                btngkA.ForeColor = Color.Black;
                toplayer = btngkA.Text;

                color1();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                // insert();
                update();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamA.Text, lblteamB.Text, btngkA.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();


                //    // p1 = new System.Drawing.Point();
                //}
                //else
                //{
                //}
            }
            else 
            {
                sub();
                lstSubA.Location = new System.Drawing.Point(392, 400);

            }
        }

        private void btngkB_Click(object sender, EventArgs e)
        {
            subteam = lblteamB.Text;

            if (chkSub.Checked == false)
            {
                player = btngkB.Text;
                team2 = lblteamA.Text;
                team1 = lblteamB.Text;
                btntmb2.BackColor = Color.Silver;
                btntmb2.ForeColor = Color.Black;

                btntmb1.BackColor = Color.Silver;
                btntmb1.ForeColor = Color.Black;



                btntmb3.BackColor = Color.Silver;
                btntmb3.ForeColor = Color.Black;

                btntmb4.BackColor = Color.Silver;
                btntmb4.ForeColor = Color.Black;

                btntmb5.BackColor = Color.Silver;
                btntmb5.ForeColor = Color.Black;

                btntmb6.BackColor = Color.Silver;
                btntmb6.ForeColor = Color.Black;

                btntmb7.BackColor = Color.Silver;
                btntmb7.ForeColor = Color.Black;

                btntmb8.BackColor = Color.Silver;
                btntmb8.ForeColor = Color.Black;

                btntmb9.BackColor = Color.Silver;
                btntmb9.ForeColor = Color.Black;

                btntmb10.BackColor = Color.Silver;
                btntmb10.ForeColor = Color.Black;

                btngkB.BackColor = Color.Gold;
                btngkB.ForeColor = Color.Black;
                toplayer = btngkB.Text;
                color2();
                lstSubA.Visible = false;
                lstSub.Visible = false;
                if (alX.Count >= 1)
                {
                    Coordinates = string.Join(",", alX.ToArray());
                }
                update();
                //insert();
                //if (Shot != "")
                //{

                //    trans.InsertValues(clsGlobalValues.Tournament, clsGlobalValues.mid, lblteamB.Text, lblteamA.Text, btngkB.Text,  Shot, Coordinates, points,toplayer);
                //    alX.Clear();
                //    general();
                //}
                //else
                //{
                //}
            }
            else
            {
                sub();
                lstSub.Location = new System.Drawing.Point(444, 156);
            }
        }

        private void lstSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            //player = lstSub.SelectedItem.ToString();

        }

        private void lstSub_Click(object sender, EventArgs e)
        {
           
            if (player == btntmb1.Text)
            {
                btntmb1.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb2.Text)
            {
                btntmb2.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb3.Text)
            {
                btntmb3.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb4.Text)
            {
                btntmb4.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb5.Text)
            {
                btntmb5.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb6.Text)
            {
                btntmb6.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb7.Text)
            {
                btntmb7.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb8.Text)
            {
                btntmb8.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb9.Text)
            {
                btntmb9.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btntmb10.Text)
            {
                btntmb10.Text = lstSub.SelectedItem.ToString();
            }
            if (player == btngkB.Text)
            {
                btngkB.Text = lstSub.SelectedItem.ToString();
            }
            lstSub.Visible = false;
        }

        private void lstSubA_Click(object sender, EventArgs e)
        {
            if (player == btngkA.Text)
            {
                btngkA.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma1.Text)
            {
                btntma1.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma2.Text)
            {
                btntma2.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma3.Text)
            {
                btntma3.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma4.Text)
            {
                btntma4.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma5.Text)
            {
                btntma5.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma6.Text)
            {
                btntma6.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma7.Text)
            {
                btntma7.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma8.Text)
            {
                btntma8.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma9.Text)
            {
                btntma9.Text = lstSubA.SelectedItem.ToString();
            }
            if (player == btntma10.Text)
            {
                btntma10.Text = lstSubA.SelectedItem.ToString();
            }
            lstSubA.Visible = false;
        }
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbDevice.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cmbDevice.Items.Add(device.Name);
                }
                cmbDevice.Items.Add("Local Videos");
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cmbDevice.Items.Add("Local Videos");
                cmbDevice.Items.Add("No video capture device on your system");
            }
        }


        private void btnDevice_Click(object sender, EventArgs e)
        {
            getCamList();
        }
        void videoCaptureSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ////throw new NotImplementedException();
            //if (isRecord)
            //{
            //    Bitmap img = (Bitmap)eventArgs.Frame.Clone();               
            //    writer.WriteVideoFrame(img);
            //    img.Dispose();
            //    img = null;
            //}
            if (FirstTime)
            {
                Playerwriter = new VideoFileWriter();

                Bitmap imgage1 = (Bitmap)eventArgs.Frame.Clone();
                Width = imgage1.Width;
                Height = imgage1.Height;
                imgage1.Dispose();
                imgage1 = null;
                FirstTime = false;
            }

            if (isRecord)
            {
                try
                {
                    Bitmap image = (Bitmap)eventArgs.Frame.Clone();
                    Playerwriter.WriteVideoFrame(image);
                    image.Dispose();
                    image = null;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);

                }
            }
        }

        public string sample = "";
        private void btnrecord_Click(object sender, EventArgs e)
        {
            recordstart(1);
        }
        public string gettimes()
        {
            string year = DateTime.Now.Year.ToString();
            string mon = DateTime.Now.Month.ToString();
            if (mon.Length < 2)
            {
                mon = "0" + mon;
            }
            string days = DateTime.Now.Day.ToString();
            if (days.Length < 2)
            {
                days = "0" + days;
            }
            string hrs = DateTime.Now.Hour.ToString();
            string DD = DateTime.Now.ToString();
            if (DD.IndexOf("AM") > 0)
            {
                hrs = hrs;
            }
            else
            {
                if (Convert.ToInt32(hrs) < 12)
                {
                    hrs = (12 + Convert.ToInt32(hrs)).ToString();
                }
            }
            if (hrs.Length < 2)
            {
                hrs = "0" + hrs;
            }
            string min = DateTime.Now.Minute.ToString();
            if (min.Length < 2)
            {
                min = "0" + min;
            }
            string sec = DateTime.Now.Second.ToString();
            if (sec.Length < 2)
            {
                sec = "0" + sec;
            }
            string msec = DateTime.Now.Millisecond.ToString();
            if (msec.Length < 3)
            {
                if (msec.Length == 1)
                {
                    msec = "00" + msec;
                }
                else if (msec.Length == 2)
                {
                    msec = "0" + msec;
                }
            }

            string tim = year + mon + days + "00" + hrs + min + sec + msec;
            sample = tim;


            string fls = videopath + "\\" + tim + ".avi";
            if (File.Exists(fls))
            {
                msec = (Convert.ToInt32(msec) + 1).ToString();
                if (msec.Length < 3)
                {
                    if (msec.Length == 1)
                    {
                        msec = "00" + msec;
                    }
                    else if (msec.Length == 2)
                    {
                        msec = "0" + msec;
                    }
                }
                tim = year + mon + days + "00" + hrs + min + sec + msec;
                sample = tim;
            }
            return tim;


        }
        public void recordstart(int value)
        {
            try
            {

                if (start == "Start")
                {

                    isRecord = true;

                    start = "Stop";
                    filename = videopath+"\\"+gettimes()+".mp4";
                    pnlrecording.Visible = true;
                    Playerwriter.Open(filename, Width, Height, 25, VideoCodec.MPEG4, 9000000);
                }
                else if (start == "Stop")
                {

                    Playerwriter.Close();
                    pnlrecording.Visible = false;
                    start = "Start";
                    //Playerwriter = new VideoFileWriter();
                }

                // General.record = 2;

            }


            catch
            {
            }
        }


        private void btnpath_Click(object sender, EventArgs e)
        {
            //Path();
            FolderBrowserDialog ofds = new FolderBrowserDialog();
          
            if (ofds.ShowDialog() == DialogResult.OK)
            {
                videopath = ofds.SelectedPath;
               



            }
        }

        private void Path()
        {
            dt = trans.path(clsGlobalValues.Tournament,clsGlobalValues.mid);
        }
        string folderPath = "";
        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDevice.SelectedItem.ToString() != "Local Videos")
                {
                    videoCaptureSource = new VideoCaptureDevice(videoDevices[cmbDevice.SelectedIndex].MonikerString);
                    videoCaptureSource.NewFrame += videoCaptureSource_NewFrame;
                    videoCaptureSource.Start();
                    videoSourcePlayer1.VideoSource = videoCaptureSource;
                    videoSourcePlayer1.Start();
                }
                else if (cmbDevice.SelectedItem.ToString() == "Local Videos")
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        folderPath = openFileDialog1.FileName;
                        //playvo1(pictureBox1, folderPath, 0);
                        //diskvideos_recording();
                        VideoFileSource videoFileSoruce;
                        videoFileSoruce = new VideoFileSource(folderPath);
                        videoFileSoruce.NewFrame += videoFileSoruce_NewFrame;
                        videoFileSoruce.Start();
                        videoSourcePlayer1.VideoSource = videoFileSoruce;
                        videoSourcePlayer1.Start();
                        //playingStatus = Start;


                      

                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void lblscoreA_Click(object sender, EventArgs e)
        {

        }

        private void btnpause_Click(object sender, EventArgs e)
        {if (btnpause.Text == "Pause")
            {
                videoSourcePlayer1.Stop();
              
                btnpause.Text = "Play";
            }
        else if(btnpause.Text == "Play")
            {
                videoSourcePlayer1.Start();
                btnpause.Text = "Pause";
            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Do you want to undo this transaction?", "FootBall!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // DataTable dtmax = new DataTable();
                string max = trans.undomax(clsGlobalValues.Tournament, clsGlobalValues.mid);
                trans.undo(clsGlobalValues.Tournament, clsGlobalValues.mid, max);
                general();
            }
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            pnlpitch.BackgroundImage = Properties.Resources.Ground___Transaction_page;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkSub.Checked == false)
            {
                lstSubA.Visible = false;
                lstSub.Visible = false;
            }
            else
            {
            }
        }
        private void showplayer(int playerjersy,string team)
        {
             playernamehover = trans.showplayer(clsGlobalValues.Tournament, clsGlobalValues.mid, playerjersy,team);



        }
        private void btngkA_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btngkA.Text),lblteamA.Text);
            toolTip1.SetToolTip(btngkA, playernamehover);

        }

        private void btntma1_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma1.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma1, playernamehover);
        }

        private void btntma2_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma2.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma2, playernamehover);
        }

        private void btntma3_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma3.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma3, playernamehover);
        }

        private void btntma4_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma4.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma4, playernamehover);
        }

        private void btntma5_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma5.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma5, playernamehover);
        }

        private void btntma6_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma6.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma6, playernamehover);
        }

        private void btntma7_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma7.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma7, playernamehover);
        }

        private void btntma8_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma8.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma8, playernamehover);
        }

        private void btntma9_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma9.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma9, playernamehover);
        }

        private void btntma10_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntma10.Text), lblteamA.Text);
            toolTip1.SetToolTip(btntma10, playernamehover);
        }

        private void btntmb1_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb1.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb1, playernamehover);
        }

        private void btntmb2_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb2.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb2, playernamehover);
        }

        private void btntmb3_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb3.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb3, playernamehover);
        }

        private void btntmb4_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb4.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb4, playernamehover);
        }

        private void btntmb5_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb5.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb5, playernamehover);
        }

        private void btntmb6_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb6.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb6, playernamehover);
        }

        private void btntmb7_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb7.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb7, playernamehover);
        }

        private void btntmb8_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb8.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb8, playernamehover);
        }

        private void btntmb9_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb9.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb9, playernamehover);
        }

        private void btntmb10_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btntmb10.Text), lblteamB.Text);
            toolTip1.SetToolTip(btntmb10, playernamehover);
        }

        private void btngkB_MouseHover(object sender, EventArgs e)
        {
            showplayer(Convert.ToInt32(btngkB.Text), lblteamB.Text);
            toolTip1.SetToolTip(btngkB, playernamehover);
        }

        void videoFileSoruce_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //FirstTime = true;
            //throw new NotImplementedException();
            if (FirstTime)
            {
                Playerwriter = new VideoFileWriter();

                Bitmap imgage1 = (Bitmap)eventArgs.Frame.Clone();
                Width = imgage1.Width;
                Height = imgage1.Height;
                imgage1.Dispose();
                imgage1 = null;
                FirstTime = false;
            }


            if (isRecord)
            {
                try
                {
                    Bitmap img = (Bitmap)eventArgs.Frame.Clone();
                    Playerwriter.WriteVideoFrame(img);
                    img.Dispose();
                    img = null;
                }
                catch (Exception e)
                {
                    // MessageBox.Show(e.Message);

                }
            }
        }

        private void pnlpitch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkSub_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSub.Checked == false)
            {
                lstSubA.Visible = false;
                lstSub.Visible = false;
            }
            else
            {
            }
        }

        private void lblundo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to undo this transaction?", "FootBall!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // DataTable dtmax = new DataTable();
                string max = trans.undomax(clsGlobalValues.Tournament, clsGlobalValues.mid);
                trans.undo(clsGlobalValues.Tournament, clsGlobalValues.mid, max);
                general();
            }
                
        }


        
    }
}
