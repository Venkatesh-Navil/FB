using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BAL
{
   public class clsposition
   {
       Authentication clsAut = new Authentication();
       DataTable dt;
       string Connection;
       string query;
       public DataTable LoadTeams(int intMid, string strTour)
       {
           Connection = clsAut.GetConnection();
           query = "select Team_A,Team_B from Match_Registration where Match_Id=" + intMid + "";
           dt = new DataTable();
           dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
           return dt;
       }
        public DataTable LoadTeamsattribute(int intMid, string strTour)
        {
            Connection = clsAut.GetConnection();
            query = "select distinct player_attribute from players ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable Loadplayer(int intMid, string strTour,string strTeam)
       {
           Connection = clsAut.GetConnection();
           
                query = "select distinct Player_Name from Players where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "' and player_status!=1 ";
            
                dt = new DataTable();
           dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
           return dt;
       }
        public void updateplayer(int intMid, string strTour, string strTeam,string player)
        {
            Connection = clsAut.GetConnection();

            query = "update Players set player_status=1  where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "' and player_Name='"+player+"' ";

            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
           
        }
        public void updateplayer1(int intMid, string strTour, string strTeam, string player)
        {
            Connection = clsAut.GetConnection();

            query = "update Players set player_status=0  where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "' and player_Name='" + player + "' ";

            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);

        }
        public DataTable Loadplayerone(int intMid, string strTour, string strTeam,string player)
        {
            Connection = clsAut.GetConnection();
            query = "select distinct Player_Name from Players where player_Name!= '"+ player + "' and Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable playerselect(int intMid, string strTour, string strTeam,string player)
       {
           Connection = clsAut.GetConnection();
           query = "select distinct Player_Name from Players where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'and Player_Name!='" + player + "'";
           dt = new DataTable();
           dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
           return dt;
       }


       public void insertPosition(int intMid, string strTour, string strTeam, string strPlayer, string strformation, string strPosition)
       {
           Connection = clsAut.GetConnection();
           query = "insert into  Position values ("+intMid+", '"+strTour+"','"+strTeam+"','"+strPlayer+"','"+strformation+"','"+strPosition+"' )"; 
           sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
       }
      

    }

}
