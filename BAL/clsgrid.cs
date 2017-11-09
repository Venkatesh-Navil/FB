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
    public class clsgrid
    {
        Authentication clsAut = new Authentication();
        string MasterConnection;
        DataTable dt;
        string query;
        string FootBallConnection;
        public DataTable LoadGrid(string strTour)
        {

            try
            {

                FootBallConnection = clsAut.GetConnection();

                query = "select Team_Name,Team_Coach,Team_Manager from Team_Registration where Tournament_Name='"+strTour+"'";

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
        public DataTable LoadGridTour(string strTour)
        {

            try
            {


                FootBallConnection = clsAut.GetConnection();
                query = "select Tournament_Id,Tournament_Name,Start_Date,End_Date,country,VideoPath from Tournament_Master";

                dt = new DataTable();

                dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
                dt.Columns[0].ColumnName = "Tournament_Id";
                dt.Columns[1].ColumnName = "Tournament_Name";
                dt.Columns[2].ColumnName = "Start_Date";
                dt.Columns[3].ColumnName = "End_Date";
                dt.Columns[4].ColumnName = "Country";
                dt.Columns[5].ColumnName = "VideoPath";
                return dt;
            }
            catch
            {

            }
            return dt;

        }
        public DataTable view_squad(string strTour, string strTeam)
        {

            FootBallConnection = clsAut.GetConnection();
            query = "Select Player_Team,Player_Name,Position,Jersey_No from Player_Registration where Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";

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
        public DataTable GetTourOnGridClick(string strTour)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select * from Tournament_Master where Tournament_Name='" + strTour + "' ";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable GetTeamOnGridClick(string strTour, string strTeam)
        {
            FootBallConnection = clsAut.GetConnection();
            query = "select * from Team_Registration where Tournament_Name='" + strTour + "' and Team_Name='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable GetPlayersOnGridClick(string strTour, string strTeam, string strPlayer)
        {
            FootBallConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select * from Player_Registration where Tournament_Name='" + strTour + "' and Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(FootBallConnection, CommandType.Text, query);
            return dt;
        }
        
    }
}
