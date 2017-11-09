using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using DAL;
using System.Data.SqlClient;

namespace BAL
{
   public class clsTotalRegistration
    {
        public string Tourname;
        string FootBallConnection;
        string MasterConnection;
        string CurrentDBConnection;
        string query;
        public string strInsertMsg;

        Authentication clsAut = new Authentication();
        DataTable dt = new DataTable();
        public void CreateTournament(string strTourName, string StartDate, string EndDate, string Country, string DBPath, string VideoPath,string category)
        {
            //********************************CREATE TOURNAMENT***************************************************
            Tourname = strTourName;
            FootBallConnection = clsAut.GetConnection();
            string FootballMaster = "FootballMaster";







            FootBallConnection = clsAut.GetConnection();
            try
            {

                query = "select * from Tournament_Master";
                dt = new DataTable();
                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                int intMid = dt.Rows.Count + 1;
                string mid = intMid.ToString();

                query = "insert into Tournament_Master (Tournament_Id,Tournament_Name,Start_Date,End_Date,Venue,Type,Country,Winner,Runner,VideoPath,category) values ('" + mid + "','" + strTourName + "','" + StartDate + "','" + EndDate + "','" + mid + "','" + mid + "','" + mid + "','','','" + VideoPath + "','" + category + "')";
                sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);

            }
            catch
            {

            }

            //******************************END**********************************************************************
        }
        public DataTable LoadComboTour()
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select Tournament_Name from Tournament_Master order by Tournament_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        byte[] ReadFile1(string sPath)
        {
            if (sPath == "Default")
            {
                sPath = @System.AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\BFI.png";
            }
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        public string InsertValues(string strTour, string strTeamName, string strFlag, string strCoach, string strManager)
        {
            FootBallConnection = clsAut.GetConnection();
            byte[] imageData = ReadFile1(strFlag);
            strTeamName = strTeamName.TrimStart();
            strTeamName = strTeamName.TrimEnd();
            //startcommon com = new startcommon();
            //if (Teams.Text.Length > 4)
            //Teams.Text = com.nameformat(Teams.Text);
            if (strTour != "" && strTeamName != "" && strFlag != "")
            {

                query = "Select * from Team_Registration where Team_Name='" + strTeamName + "'";

                dt = new System.Data.DataTable();
                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                if (dt.Rows.Count == 0)
                {
                    query = "select * from Tournament_Master";
                    dt = new DataTable();
                    dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                    int intMid = dt.Rows.Count;
                    string mid = intMid.ToString();

                    query = "insert into Team_Registration (Tournament_Id,Tournament_Name,Team_Name,Team_Flag,Team_Coach,Team_Manager) values('" + mid + "','" + strTour + "','" + strTeamName + "',@Flag,'" + strCoach + "','" + strManager + "')";
                    SqlParameter PP1 = new SqlParameter("@Flag", imageData);
                    sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query, PP1);
                    strInsertMsg = "Success";

                }
                else
                {
                    strInsertMsg = "Exist";

                }
            }
            else
            {

            }
            return strInsertMsg;


        }
        public string InsertValues(string strTour, string strTeam, string strPlayerName, string strPosition, string strImage, int jersey)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select * from Tournament_Master";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            int intMid = dt.Rows.Count;
            string mid = intMid.ToString();


            byte[] imageData = ReadFile1(strImage);
            strPlayerName = strPlayerName.TrimStart();
            strPlayerName = strPlayerName.TrimEnd();

            clsCommon com = new clsCommon();
            strPlayerName = com.nameformat(strPlayerName);

            FootBallConnection = clsAut.GetConnection();
            query = "Select *  from Player_Registration where Player_Name='" + strPlayerName + "' and Player_Team='" + strTeam + "'";
            DataTable dtc = new System.Data.DataTable();
            dtc = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            if (dtc.Rows.Count == 0)
            {

                query = "Insert into Player_Registration values('" + mid + "','" + strTour + "','" + strTeam + "','" + strPlayerName + "','" + strPosition + "',@photo,'" + jersey + "')";
                SqlParameter pp1 = new SqlParameter("@photo", imageData);
                sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query, pp1);
                strInsertMsg = "Success";

            }
            else
            {
                strInsertMsg = "Exist";

            }




            return strInsertMsg;
        }
        public DataTable LoadComboTeam(string strTour)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select Team_Name from Team_Registration where Tournament_Name='" + strTour + "' order by Team_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public void DeleteTeam(string strTour, string strTeam)
        {
            FootBallConnection = clsAut.GetConnection();


            query = "delete from Team_Registration where Team_Name='" + strTeam + "'";
            sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);

        }
        public void DeleteTour(string strTour)
        {
            FootBallConnection = clsAut.GetConnection();


            query = "delete Tournament_Master where Tournament_Name='" + strTour + "'";
            sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);

        }
        public DataTable LoadGrid(string strTour)
        {

            try
            {



                query = "select Tournament_Name,Team_Name,Team_Coach,Team_Manager from Team_Registration where Tournament_Name='" + strTour + "'";

                dt = new DataTable();

                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                dt.Columns[0].ColumnName = "Tournament Name";
                dt.Columns[1].ColumnName = "Team Name";
                dt.Columns[2].ColumnName = "Coach";
                dt.Columns[2].ColumnName = "Manager";
                return dt;
            }
            catch
            {

            }
            return dt;

        }
        public DataTable LoadGridTour(string strTour)
        {

            try
            {



                query = "select Tournament_Id,Tournament_Name,Start_Date,End_Date from Tournament_Master";

                dt = new DataTable();

                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                dt.Columns[0].ColumnName = "Tournament_Id";
                dt.Columns[1].ColumnName = "Tournament_Name";
                dt.Columns[2].ColumnName = "Start_Date";
                dt.Columns[2].ColumnName = "End_Date";
                return dt;
            }
            catch
            {

            }
            return dt;

        }
        public DataTable GetTeamOnGridClick(string strTour, string strTeam)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select * from Team_Registration where Team_Name='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable view_squad(string strTour, string strTeam)
        {
           
            FootBallConnection = clsAut.GetConnection();
            query = "Select Player_Team,Player_Name,Position,Jersey_No from Player_Registration where Player_Team='" + strTeam + "'";

            DataTable dts = new System.Data.DataTable();
            dts = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            if (dts.Rows.Count > 0)
            {
                dts.Columns[0].ColumnName = "Player Team";
                dts.Columns[1].ColumnName = "Player";
                dts.Columns[2].ColumnName = "Position";
                dts.Columns[3].ColumnName = "Jersey";

               
            }
            else
            {

            }
            return dts;
          
        }
        public DataTable GetPlayersOnGridClick(string strTour, string strTeam)
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select * from Player_Registration where Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public void DeletePlayer(string strTour, string strTeam, string strPlayer)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "delete from Player_Registration where Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
            sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);
        }
    }
}
