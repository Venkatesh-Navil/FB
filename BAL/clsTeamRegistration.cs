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
   public class clsTeamRegistration
    {
        string connection;
        Authentication clsAut = new Authentication();
        DataTable dt = new DataTable();
        string FootBallConnection;
        public string strInsertMsg;
        string CurrentDBConnection;
        string query;
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
        public void DeleteTeam(string strTour, string strTeam)
        {
            connection = clsAut.GetCurrentDBConnection(strTour);


            query = "delete from Team_Registration where Team_Name='" + strTeam + "'";
            sqlhelper.ExecuteNonQuery(connection, CommandType.Text, query);

        }
        public void UpdateTeam(string strTour, string strTeam, string strManager, string strCoach, string strFlag)
        {
            connection = clsAut.GetCurrentDBConnection(strTour);

            if (strFlag == "Default")
            {
                query = "update Team_Registration set Team_Manager='" + strManager + "',Team_Coach='" + strCoach + "' where Team_Name='" + strTeam + "'";
                sqlhelper.ExecuteNonQuery(connection, CommandType.Text, query);
            }
            else
            {
                byte[] imageData = ReadFile1(strFlag);
                query = "update Team_Registration set Team_Manager='" + strManager + "',Team_Coach='" + strCoach + "',Team_Flag=@Flag where Team_Name='" + strTeam + "'";
                SqlParameter PP1 = new SqlParameter("@Flag", imageData);
                sqlhelper.ExecuteNonQuery(connection, CommandType.Text, query, PP1);
            }


        }
        public DataTable LoadComboTour()
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select Tournament_Name from Tournament_Master order by Tournament_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
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

                    query = "insert into Team_Registration (Tournament_Id,Team_Name,Team_Flag,Team_Coach,Team_Manager) values('"+mid+"','" + strTeamName + "',@Flag,'" + strCoach + "','" + strManager + "')";
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
        public DataTable LoadGrid(string strTour)
        {

            try
            {

                CurrentDBConnection = clsAut.GetCurrentDBConnection(strTour);

                query = "select Team_Name,Team_Coach,Team_Manager from Team_Registration";

                dt = new DataTable();

                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                dt.Columns[0].ColumnName = "Team";
                dt.Columns[1].ColumnName = "Coach";
                dt.Columns[2].ColumnName = "Manager";
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

    }
}
