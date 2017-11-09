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
    public class clsplayerRegistration
    {
        string connection;
        Authentication clsAut = new Authentication();
        DataTable dt = new DataTable();
        string FootBallMasterConnection;
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
        public DataTable LoadComboTour()
        {
            FootBallMasterConnection = clsAut.GetConnection();
            query = "select Tournament_Name from Tournament_Master order by Tournament_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            return dt;
        }
        public DataTable LoadComboTeam(string strTour)
        {
            FootBallMasterConnection = clsAut.GetConnection();
            query = "select Team_Name from Team_Registration order by Team_Name";
            dt = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            return dt;
        }
        public string InsertValues(string strTour, string strTeam, string strPlayerName, string strPosition, string strImage,int jersey)
        {
            FootBallMasterConnection = clsAut.GetConnection();
            query = "select * from Tournament_Master";
            dt = new DataTable();
            dt = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            int intMid = dt.Rows.Count;
            string mid = intMid.ToString();


            byte[] imageData = ReadFile1(strImage);
            strPlayerName = strPlayerName.TrimStart();
            strPlayerName = strPlayerName.TrimEnd();
           
            clsCommon com = new clsCommon();
            strPlayerName = com.nameformat(strPlayerName);
            
            FootBallMasterConnection = clsAut.GetConnection();
            query = "Select *  from Player_Registration where Player_Name='" + strPlayerName + "' and Player_Team='" + strTeam + "'";
            DataTable dtc = new System.Data.DataTable();
            dtc = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            if (dtc.Rows.Count == 0)
            {

                query = "Insert into Player_Registration values('" + mid + "','" + strTour + "','" + strTeam + "','" + strPlayerName + "','" + strPosition + "',@photo,'" + jersey + "')";
                SqlParameter pp1 = new SqlParameter("@photo", imageData);
                sqlhelper.ExecuteNonQuery(FootBallMasterConnection, CommandType.Text, query, pp1);
                strInsertMsg = "Success";
               
            }
            else
            {
                strInsertMsg = "Exist";
                
            }




            return strInsertMsg;
        }
        public DataTable view_squad(string strTour, string strTeam)
        {
            //if (cmbTour.SelectedIndex != -1 && cmbTeam.SelectedIndex != -1)
            //{
            // dgPlayerRegistration.Visible = true;
            FootBallMasterConnection = clsAut.GetConnection();
            query = "Select Player_Name,Player_Team,Position,Jersey_Number from Player_Registration where Player_Team='" + strTeam + "'";

            DataTable dts = new System.Data.DataTable();
            dts = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            if (dts.Rows.Count > 0)
            {
                dts.Columns[0].ColumnName = "Player";
                dts.Columns[1].ColumnName = "Team";
                dts.Columns[2].ColumnName = "Position";
                dts.Columns[3].ColumnName = "Jersey";
                
                //dts.Columns[3].ColumnName = "Bowlstyle";
                //dgPlayerRegistration.DataSource = dts;
                //dgPlayerRegistration.Columns[0].Width = 150;
                //dgPlayerRegistration.Columns[1].Width = 150;
                //dgPlayerRegistration.Columns[2].Width = 150;
                //dgPlayerRegistration.Columns[3].Width = 150;
                //dgPlayerRegistration.Width = 610;
            }
            else
            {

            }
            return dts;
            //}
            //else
            //    MessageBox.Show("Select the Tournament and Team", "iCricket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void UpdatePlayer(string strTour, string strPlayer, string strTeam, string position, string strimage,int jersey)
        {
            FootBallMasterConnection = clsAut.GetConnection();
            if (strimage == "Default")
            {
                query = "update Player_Registration set Position='" + position + "' where Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
                sqlhelper.ExecuteNonQuery(FootBallMasterConnection, CommandType.Text, query);

            }
            else
            {
                byte[] imageData = ReadFile1(strimage);
                query = "update Player_Registration set Position='" + position + "',Player_Image=@image  where Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
                SqlParameter pp = new SqlParameter("@image", imageData);
                sqlhelper.ExecuteNonQuery(FootBallMasterConnection, CommandType.Text, query, pp);
            }
        }
        public void DeletePlayer(string strTour, string strTeam, string strPlayer)
        {
            FootBallMasterConnection = clsAut.GetConnection();
            query = "delete from Player_Registration where Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
            sqlhelper.ExecuteNonQuery(FootBallMasterConnection, CommandType.Text, query);
        }
        public DataTable GetPlayersOnGridClick(string strTour, string strPlayer, string strTeam)
        {
            FootBallMasterConnection = clsAut.GetConnection();
            dt = new DataTable();
            query = "select * from Player_Registration where Player_Name='" + strPlayer + "' and Player_Team='" + strTeam + "'";
            dt = sqlhelper.ExecuteDatatable(FootBallMasterConnection, CommandType.Text, query);
            return dt;
        }
    }
}
