using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
    public class clssquadRegistration
    {
        Authentication clsAut = new Authentication();
        DataTable dt;
        string Connection;
        string query;
        public DataTable LoadMatchDetails(string strTour, int intMid)
        {

            dt = new DataTable();
            Connection = clsAut.GetConnection();
            query = "select Match_Id,Team_A,Team_B,Venue,Match_Date,Match_Status from Match_Registration where Match_id=" + intMid + "";
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;

        }
        public DataTable Loadtour(string strTour, int intMid)
        {

            dt = new DataTable();
            Connection = clsAut.GetConnection();
            query = "select distinct Tournament_Name from tournament_master ";
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;

        }
        public void AutoLoad(string mid, string strTour)
        {
            Connection = clsAut.GetConnection();
            //comboBox1_SelectedIndexChanged(sender, e);
            droptables("temp" + mid.ToString(), strTour);
            droptables("umpdetail" + mid.ToString(), strTour);
            droptables("teamscore" + mid.ToString(), strTour);
            droptables("scorecard" + mid.ToString(), strTour);
            droptables("bowlers" + mid.ToString(), strTour);
            droptables("batsmans" + mid.ToString(), strTour);

            try
            {
                query = "Delete Players where id=" + mid + "";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);

                query = "Delete Sub_Players where id=" + mid + "";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {

            }

            try
            {
                //query = "drop table MatchDetails" + mid + "";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {

            }

            try
            {
                //query = "drop table SideChange" + mid + "";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {

            }

            try
            {


                //query = "create table Meta_Details" + mid + "(Team varchar(100),Captain varchar(100),Umpire1 varchar(100),Umpire2 varchar(100),Refree varchar(100),Analyst varchar(250))";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {
            }

            try
            {

               // query = "create table SideChange" + mid + "(Team_Name varchar(100),Game_Side varchar(100))";
               // sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch { }
            try
            {
               // query = "Create table MatchDetails" + mid + "(Toss_Team varchar(250),Toss_Decision varchar(250),Ride_Team varchar(250),Won_Details varchar(250),Match_Details varchar(250),Mplayer varchar(250))";
               // sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {

            }

            int dox = 0;
            
        }
        public void droptables(string kk1, string strTour)
        {
            try
            {
                Connection = clsAut.GetConnection();
                query = "Drop table " + kk1 + "";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            catch
            {

            }
        }
        public DataTable LoadTeams(int intMid, string strTour)
        {
            Connection = clsAut.GetConnection();
            query = "select Team_name from team_Registration where tournament_name='"+strTour+"'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadPlay(int intMid, string strTour ,string player)
        {
            Connection = clsAut.GetConnection();
            query = "select Player_Name from Player_Registration where Tournament_Name='" + strTour + "' and Player_Team='" + strTour + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadRefree()
        {
            return dt;
        }
        public DataTable LoadUmpire()
        {
            return dt;

        }
        public DataTable LoadAnalyst()
        {
            return dt;
        }
        public DataTable LoadPlayers(string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Player_Name from Player_Registration where Player_Team='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public void Insert_player(DataTable team1, DataTable team2, DataTable sub1, DataTable sub2, string strTour, int intMid, string teamA, string teamB, string strTossTeam, string strDecision, string strCaptainA, string strCaptainB, string strUmpire1, string strUmpire2, string strRefree, string strAnalyst, string strRaidTeam)
        {
            if (team1.Rows.Count == 11 && team2.Rows.Count == 11)
            {
                //try
                //{
                //    try
                //    {
                Connection = clsAut.GetConnection();



                //query = "Delete from MatchDetails" + intMid + "";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);

                query = "insert into Match_Master(Match_Id,Toss_Won_Team,Decision,Match_Result)values(" + intMid + ",'" + strTossTeam + "','" + strDecision + "','')";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                //}

                //catch
                //{
                //    con.Close();
                //}
                //try
                //{


                //query = "delete from Meta_Details" + intMid + "";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);


                //query = "insert into Meta_Details" + intMid + "(Team,Captain,Umpire1,Umpire2,Refree,Analyst)values('" + teamA + "','" + strCaptainA + "','" + strUmpire1 + "','" + strUmpire2 + "','" + strRefree + "','" + strAnalyst + "');insert into Meta_Details" + intMid + "(Team,Captain,Umpire1,Umpire2,Refree,Analyst)values('" + teamB + "','" + strCaptainB + "','" + strUmpire1 + "','" + strUmpire2 + "','" + strRefree + "','" + strAnalyst + "')";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);


                //query = "IF OBJECT_ID('Players') IS NULL " + " create table Players([Match_Id] [int] NULL,[Player_Name] [nvarchar](max) NULL,[Player_Team] [nvarchar](max) NULL,[Player_Attribute] [nvarchar](max) NULL,[Player_Status] [bit] NULL,[Player_Sub] [bit] NULL,[Player_Sub_Name] [nvarchar](max) NULL,[Player_Position] [int] NULL)";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);

                //query = "IF OBJECT_ID('TransactionMaster') IS NULL " + " CREATE TABLE [dbo].[TransactionMaster]([Match_Id] [int] NULL,[Raide_Number] [int] NULL,[Raide_Team] [nvarchar](100) NULL,[Raider] [nvarchar](max) NULL,[Opp_Team] [nvarchar](max) NULL,[Defender] [nvarchar](max) NULL,[Outcome] [nvarchar](max) NULL,[Result] [nvarchar](max) NULL,[Invovled_Players] [nvarchar](max) NULL,[Points] [int] NULL,[Bonus_Point] [int] NULL,[Coordinates] [nvarchar](max) NULL,[Skills] [nvarchar](max) NULL,[PointsEach] [int] NULL,[Substitution] [nvarchar](max) NULL,[Time] [int] NULL,[HalfTime] [nvarchar](max) NULL)";
                //sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                //}
                //catch 
                //{ 
                //    con.Close(); 
                //}
                query = "delete from Players where Match_Id=" + intMid + "";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);

                query = "delete from Sub_Players where Match_Id=" + intMid + "";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);

                DataSet ds = new DataSet();
                query = "select * from Player_Registration where Player_Team='" + teamA + "';select * from Player_Registration where Player_Team='" + teamB + "'";
                ds = sqlhelper.ExecuteDataset(Connection, CommandType.Text, query);


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < team1.Rows.Count; j++)
                    {
                        if (team1.Rows[j][0].ToString() == ds.Tables[0].Rows[i][3].ToString())
                        {
                            query = "insert into Players values(" + intMid + ",'" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "','" + ds.Tables[0].Rows[i][4].ToString() + "','" + ds.Tables[0].Rows[i][6].ToString() + "',0,0,''," + j + ")";
                            sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                        }
                    }
                }

                //INSERTING SUBSTITUTES-TEAM A
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < sub1.Rows.Count; j++)
                    {
                        if (sub1.Rows[j][0].ToString() == ds.Tables[0].Rows[i][3].ToString())
                        {
                            query = "insert into Sub_Players values(" + intMid + ",'" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "','" + ds.Tables[0].Rows[i][4].ToString() + "','" + ds.Tables[0].Rows[i][6].ToString() + "')";
                            sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                        }
                    }
                }

                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    for (int j = 0; j < team2.Rows.Count; j++)
                    {
                        if (team2.Rows[j][0].ToString() == ds.Tables[1].Rows[i][3].ToString())
                        {
                            query = "insert into Players values(" + intMid + ",'" + ds.Tables[1].Rows[i][1].ToString() + "','" + ds.Tables[1].Rows[i][2].ToString() + "','" + ds.Tables[1].Rows[i][3].ToString() + "','" + ds.Tables[1].Rows[i][4].ToString() + "','" + ds.Tables[1].Rows[i][6].ToString() + "',0,0,''," + j + ")";
                            sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                        }
                    }
                }

                //INSERTING SUBSTITUTES-TEAM B
                for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                {
                    for (int j = 0; j < sub2.Rows.Count; j++)
                    {
                        if (sub2.Rows[j][0].ToString() == ds.Tables[1].Rows[i][3].ToString())
                        {
                            query = "insert into Sub_Players values(" + intMid + ",'" + ds.Tables[1].Rows[i][1].ToString() + "','" + ds.Tables[1].Rows[i][2].ToString() + "','" + ds.Tables[1].Rows[i][3].ToString() + "','" + ds.Tables[1].Rows[i][4].ToString() + "','" + ds.Tables[1].Rows[i][6].ToString() + "')";
                            sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
                        }
                    }
                }

               
            }
            else
            {
               
            }
        }
    }
}
