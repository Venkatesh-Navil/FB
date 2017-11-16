using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BAL
{
   public  class clstransaction
    {
        Authentication clsAut = new Authentication();
        DataTable dt;
        string Connection;
        string query;
        public DataTable Loadplayer(int intMid, string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select Jersey_Number,Player_Team from Players where Player_Attribute!= 'Goalkeeper' and Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable Loadteam(int intMid, string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select Team_A,Team_B from Match_Registration where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadScore(string strTour, int intMid, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select sum(points) from Transaction_Master where mid=" + intMid + " and Tournament='" + strTour + "' and Playing_Team='"+strTeam+"' and points=1";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadDay(int intMid, string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select Match_Date from Match_Registration where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable Loadgoalkeeper(int intMid, string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select Jersey_Number from Players where Player_Attribute= 'Goalkeeper' and Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable Load1sttime(int intMid, string strTour, string strTeam)
        {
            Connection = clsAut.GetConnection();
            query = "select * from transaction_master where Mid=" + intMid + " and Tournament='" + strTour + "' ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable update(int intMid, string strTour, string strTeam,string sno,string toplayer)
        {
            Connection = clsAut.GetConnection();
            query = "update transaction_master set toplayer='"+toplayer+"' where Mid=" + intMid + " and Tournament='" + strTour + "' and sno='"+sno+"'  ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public DataTable loadsubPlayer(string strTour,int intMid,string strTeam)
        {
            DataTable dt5 = new DataTable();
            Connection = clsAut.GetConnection();
            query = "select Jersey_Number from sub_Players where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' and Player_Team='" + strTeam + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }
        public string undomax(string strTour, int intMid)
        {
            DataTable dt5 = new DataTable();
            Connection = clsAut.GetConnection();
            //DELETE FROM MARKS WHERE ID = (SELECT MAX(id) FROM MARKS)
            query = "select max(sno) from Transaction_Master where mid=" + intMid + " and Tournament='" + strTour + "' ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            string max = dt.Rows[0][0].ToString();
            return max;

        }
        public string showplayer(string strTour, int intMid,int jersy,string team)
        {
            string max = "";
                try
            {


                DataTable dt5 = new DataTable();
                Connection = clsAut.GetConnection();
                //DELETE FROM MARKS WHERE ID = (SELECT MAX(id) FROM MARKS)
                query = "select player_name from players where match_id=" + intMid + " and Tournament_name='" + strTour + "' and jersey_number='" + jersy + "' and player_team='"+team+"' ";
                dt = new DataTable();
                dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
               max = dt.Rows[0][0].ToString();
                
            }
            catch
            {

            }
            return max;
        }
        public void undo(string strTour, int intMid,string sno)
        {
            DataTable dt5 = new DataTable();
            Connection = clsAut.GetConnection();
            //DELETE FROM MARKS WHERE ID = (SELECT MAX(id) FROM MARKS)
            query = "delete from Transaction_Master where sno='"+sno+"' ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            
        }
        public void InsertValues(string strTour, int intMid, string teamA, string teamB, string strPlayer,string strshot,string strCordinates,int points,string toplayer,string toTeam)
        {
           
            Connection = clsAut.GetConnection();
            query = "insert into Transaction_Master([Tournament],[mid],[Playing_Team],[Opponent_Team],[Player],[shottype],[Coordinates],[points],[toplayer],[toteam]) values('" + strTour + "'," + intMid + ",'" + teamA + "','" + teamB + "','" + strPlayer + "','" + strshot + "','" + strCordinates + "','" + points + "','" + toplayer + "','" + toTeam + "')";
            sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
           
            query = "select * from Transaction_Master where Mid=" + intMid + " and Tournament='" + strTour + "' ";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);

            if (dt.Rows.Count == 1)
            {
                query = "update Match_Registration set Match_Status='Match Pending' where Match_Id=" + intMid + " and Tournament_Name='" + strTour + "' ";
                sqlhelper.ExecuteNonQuery(Connection, CommandType.Text, query);
            }
            
        }
        public DataTable path(string strTour, int intMid)
        {
            DataTable dt5 = new DataTable();
            Connection = clsAut.GetConnection();
            query = "select videopath from tournament_master where tournament_Id=" + intMid + " and Tournament_Name='" + strTour + "'";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            return dt;
        }

    }
}
