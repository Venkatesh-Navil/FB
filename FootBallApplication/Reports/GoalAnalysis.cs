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

namespace FootBallApplication.Reports
{
    public partial class GoalAnalysis : Form
    {
        string TeamA;
        string TeamB;
        public GoalAnalysis()
        {
            InitializeComponent();
        }
        clsGoalAnalysis objGolAnalysis = new clsGoalAnalysis();
        clsImage objImage = new clsImage();
        private void GoalAnalysis_Load(object sender, EventArgs e)
        {
            grpshots.Visible = true;
            grdsubA.Visible = false;
            grdsubB.Visible = false;
            try
            {
                DataTable dttour = new DataTable();
                dttour = objGolAnalysis.LoadTour();
                cmbTour.Items.Clear();
                for (int i = 0; i < dttour.Rows.Count; i++)
                {
                    cmbTour.Items.Add(dttour.Rows[i][0].ToString());
                }



            }
            catch { }
        }

        private void cmbTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpshots.Visible = true;
            grdsubA.Visible = false;
            grdsubB.Visible = false;
            try
            {
                DataTable dtmid = new DataTable();
                dtmid = objGolAnalysis.LoadMatch(cmbTour.SelectedItem.ToString());
                cmbMatch.Items.Clear();
                for (int i = 0; i < dtmid.Rows.Count; i++)
                {
                    cmbMatch.Items.Add(dtmid.Rows[i][0].ToString());
                }
            }
            catch { }
        }

        private void cmbMatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btsSub.BackColor = Color.White;
            btnshot.BackColor = Color.Aqua;
            grpshots.Visible = true;
            grdsubA.Visible = false;
            grdsubB.Visible = false;
            panel1.Visible = false;
            panel7.Visible = false;
            try
            {
                lblmatchno.Text = "Match No " + cmbMatch.Text;
                DataTable dt = new DataTable();
                int middd = Convert.ToInt32(cmbMatch.SelectedItem.ToString());
                dt = objGolAnalysis.LoadTeam(cmbTour.SelectedItem.ToString(), middd);
                TeamA = dt.Rows[0][0].ToString();
                TeamB = dt.Rows[0][1].ToString();
                lblTeamA.Text = dt.Rows[0][0].ToString();
                lblTeamB.Text = dt.Rows[0][1].ToString();
                objImage.TwoTeamFlagsDisplay(cmbTour.SelectedItem.ToString(), TeamA, TeamB, pnlTeamA, pnlTeamB);



                // Goal //
                DataTable dtGoal = new DataTable();
                dtGoal = objGolAnalysis.LoadGoalA(cmbTour.SelectedItem.ToString(), middd, TeamA);
                lblGTeamA.Text = dtGoal.Rows[0][0].ToString();
                dtGoal = objGolAnalysis.LoadGoalB(cmbTour.SelectedItem.ToString(), middd, TeamB);
                lblGTeamB.Text = dtGoal.Rows[0][0].ToString();

                // Total Shots //

                DataTable dtTotShots = new DataTable();
                dtTotShots = objGolAnalysis.LoadTotShotsA(cmbTour.SelectedItem.ToString(), middd, TeamA);
                totshotsA.Text = dtTotShots.Rows[0][0].ToString();
                dtTotShots = objGolAnalysis.LoadTotShotsB(cmbTour.SelectedItem.ToString(), middd, TeamB);
                totshotsB.Text = dtTotShots.Rows[0][0].ToString();

                // On Target Shots //

                DataTable dtonTargt = new DataTable();
                dtonTargt = objGolAnalysis.LoadOntargetA(cmbTour.SelectedItem.ToString(), middd, TeamA);
                ontrgtA.Text = dtonTargt.Rows[0][0].ToString();
                dtonTargt = objGolAnalysis.LoadOntargetB(cmbTour.SelectedItem.ToString(), middd, TeamB);
                ontrgtB.Text = dtonTargt.Rows[0][0].ToString();


                // Yellow  Card //

                DataTable dtyellow = new DataTable();
                dtyellow = objGolAnalysis.LoadYellowA(cmbTour.SelectedItem.ToString(), middd, TeamA);
                totYellowA.Text = dtyellow.Rows[0][0].ToString();
                dtyellow = objGolAnalysis.LoadYellowB(cmbTour.SelectedItem.ToString(), middd, TeamB);
                totYellowB.Text = dtyellow.Rows[0][0].ToString();

                // Red  Card //

                DataTable dtred = new DataTable();
                dtred = objGolAnalysis.LoadRedA(cmbTour.SelectedItem.ToString(), middd, TeamA);
                totRedA.Text = dtred.Rows[0][0].ToString();
                dtred = objGolAnalysis.LoadRedB(cmbTour.SelectedItem.ToString(), middd, TeamB);
                totRedB.Text = dtred.Rows[0][0].ToString();

            }
            catch { }
        }

        private void btnshot_Click(object sender, EventArgs e)
        {
            btnshot.BackColor = Color.Aqua;
            btsSub.BackColor = Color.White;
            grpshots.Visible = true;
            grdsubA.Visible = false;
            grdsubB.Visible = false;
            panel1.Visible = false;
            panel7.Visible = false;
        }

        private void btsSub_Click(object sender, EventArgs e)
        {
            int matchid = Convert.ToInt32(cmbMatch.SelectedItem.ToString());
            DataTable dtsub = new DataTable();
            dtsub = objGolAnalysis.LoadSubA(cmbTour.SelectedItem.ToString(), matchid, TeamA);
            grdsubA.DataSource = dtsub;
            DataTable dtdes = new DataTable();
            dtdes.Columns.Add("Player_Name (J.NO)",typeof(string));
            dtdes.Columns.Add("SubPlayer_Name (J.NO)", typeof(string));
            for (int i = 0; i < dtsub.Rows.Count; i++)
            {
                dtdes.Rows.Add(dtsub.Rows[i][0].ToString() + "(" + dtsub.Rows[i][2].ToString() + ")",dtsub.Rows[i][1].ToString() + " (" + dtsub.Rows[i][3].ToString()+")");
            }
            grdsubA.DataSource = dtdes;

            //totRedA.Text = dtsub.Rows[0][0].ToString();
            dtsub = objGolAnalysis.LoadSubB(cmbTour.SelectedItem.ToString(), matchid, TeamB);
           
            dtdes = new DataTable();
            dtdes.Columns.Add("Player_Name (J.NO)", typeof(string));
            dtdes.Columns.Add("SubPlayer_Name (J.NO)", typeof(string));
            for (int i = 0; i < dtsub.Rows.Count; i++)
            {
                dtdes.Rows.Add(dtsub.Rows[i][0].ToString() + "(" + dtsub.Rows[i][2].ToString() + ")", dtsub.Rows[i][1].ToString() + " (" + dtsub.Rows[i][3].ToString() + ")");
            }
            grdsubB.DataSource = dtdes; 
            
            //totRedB.Text = dtsub.Rows[0][0].ToString();

            btnshot.BackColor = Color.White;
            btsSub.BackColor = Color.Aqua;
            //grpshots.Visible = false;
            grdsubA.Visible = true;
            grdsubB.Visible = true;

            grdsubA.Columns[0].Width = 140;
            grdsubA.Columns[1].Width = 138;
            grdsubB.Columns[0].Width = 140;
            grdsubB.Columns[1].Width = 138;
            panel1.Visible = true;
            panel7.Visible = true;

            grdsubA.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdsubA.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdsubB.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdsubB.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
