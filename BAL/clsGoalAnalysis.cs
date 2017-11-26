using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BAL
{
    public class clsGoalAnalysis
    {


        Authentication clsAut = new Authentication();
        string FootballConnection;
        string query;
        DataTable dt;

        public DataTable LoadTeam(string tour, int mid)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Team_A,Team_B from Match_Registration where Match_Id='" + mid + "' and Tournament_Name='" + tour + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadTour()
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Tournament_Name from Tournament_Master";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadMatch(string Tour)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Match_Id from Match_Registration where Tournament_Name='" + Tour + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadGoalA(string tour, int mid, string TeamA)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(points) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamA + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadGoalB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(points) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadTotShotsA(string tour, int mid, string TeamA)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamA + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadTotShotsB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadOntargetA(string tour, int mid, string TeamA)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamA + "' and kicktype='SHOT ON TARGET'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadOntargetB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "' and kicktype='SHOT ON TARGET'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadYellowA(string tour, int mid, string TeamA)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamA + "' and kicktype='YELOW CARD'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadYellowB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "' and kicktype='YELOW CARD'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadRedA(string tour, int mid, string TeamA)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();

            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamA + "' and kicktype='RED CARD'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadRedB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "' and kicktype='RED CARD'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }

        public DataTable LoadSubB(string tour, int mid, string TeamB)
        {
            FootballConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select Count(kicktype) from TransactionDetails where matchid='" + mid + "' and Tournamentname='" + tour + "' and FromBallTeam='" + TeamB + "' and kicktype='RED CARD'";
            dt = sqlhelper.ExecuteDatatable(FootballConnection, CommandType.Text, query);
            return dt;
        }
    }
}
