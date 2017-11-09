using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
    public class clsMatchRegistration
    {
        Authentication clsAut = new Authentication();
        string MasterConnection;
        DataTable dt;
        string query;
        string CurrentDBConnection;
        string FootBallConnection;
        public DataTable LoadTeamA(string strTour)
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Team_Name from Team_Registration where Tournament_Name='" + strTour + "'order by Team_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadTournament()
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
           
            query = "select Venue from Tournament_Master order by Venue";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadTeamB(string TeamA, string strTour)
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Team_Name from Team_Registration where Tournament_Name='" + strTour + "' and Team_Name!='" + TeamA + "' order by Team_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public void InsertValues(string strTour, string strTeamA, string strTeamB, string strVenue, string strDate, string strStatus)
        {

            FootBallConnection = clsAut.GetConnection();

            query = "select * from Match_Registration";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            int intMid = dt.Rows.Count + 1;
            string mid = intMid.ToString();
            query = "insert into Match_Registration values('" + mid + "','" + strTour + "','" + strTeamA + "','" + strTeamB + "','" + strVenue + "','" + strDate + "','" + strStatus + "')";
            sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);
        }
        public DataTable LoadComboTour()
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select Tournament_Name from Tournament_Master order by Tournament_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadVenue()
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select distinct Venue_Name from Venue_Master";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadMatches(string strTour)
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Match_Id,Team_A,Team_B,Venue,Match_Date from Match_Registration";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
    }
}
