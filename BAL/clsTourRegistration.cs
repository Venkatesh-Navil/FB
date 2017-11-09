using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
   public class clsTourRegistration
    {
      public string Tourname;
        string FootBallConnection;
        string MasterConnection;
        string CurrentDBConnection;
        string query;
        Authentication clsAut = new Authentication();
        DataTable dt = new DataTable();
        public void CreateTournament(string strTourName, string StartDate,string EndDate, string Country, string DBPath, string VideoPath)
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

                query = "insert into Tournament_Master (Tournament_Id,Tournament_Name,Start_Date,End_Date,Venue,Type,Country,Winner,Runner,VideoPath) values ('"+mid+"','" + strTourName + "','" + StartDate + "','" + EndDate + "','" + mid + "','" + mid + "','" + mid + "','','','" + VideoPath + "')";
                sqlhelper.ExecuteNonQuery(FootBallConnection, CommandType.Text, query);
                
            }
            catch
            {

            }

            //******************************END**********************************************************************
        }
        public DataTable LoadGrid()
        {
            FootBallConnection = clsAut.GetConnection();
            query = "  select Tournament_Name,Start_Date,End_Date,Country,Videopath from [Tournament_Master]";

            DataTable dts = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dts;
        }
    }
}
