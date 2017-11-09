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
    public class clsNavigation
    {
        Authentication clsAut = new Authentication();
        string MasterConnection;
        DataTable dt;
        string query;
        string CurrentDBConnection;
        string FootballConnection;

        public DataTable LoadTournament()
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();
           
            query = "select Tournament_Name from Tournament_Master order by Tournament_Name";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadMatchesPrevious(string strTour)
        {
            dt = new DataTable();
            FootballConnection = clsAut.GetConnection();
            query = "select Match_Id,Tournament_Name,Team_A,Team_B,Venue,Match_Date,Match_Status from Match_Registration where Tournament_Name='" + strTour + "'   order by Match_Id asc";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadMatchesCurrent(string strTour)
        {
            dt = new DataTable();
            FootballConnection = clsAut.GetConnection();
            query = "select Match_Id,Team_A,Team_B,Venue,Match_Date,Match_Status from Match_Registration where Tournament_Name='" + strTour + "'   order by Match_Id asc";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
    }
}
