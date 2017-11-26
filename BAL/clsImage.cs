using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using DAL;

namespace BAL
{
   public class clsImage
    {
        string connection;
        string query;
        Authentication clsAut = new Authentication();
        public void TwoTeamFlagsDisplay(string db, string l1, string l2, Panel p1, Panel p2)
        {
            connection = clsAut.GetConnection();
            query = "select Team_Flag from Team_Registration where Team_Name='" + l1 + "'";


            try
            {
                byte[] cn = (byte[])sqlhelper.ExecuteScalar(connection, CommandType.Text, query);
                MemoryStream mm = new MemoryStream(cn);
                p1.BackgroundImage = Image.FromStream(mm);

                if (l2 != null)
                {
                    query = "select Team_Flag from Team_Registration where Team_Name='" + l2 + "'";
                    byte[] cn1 = (byte[])sqlhelper.ExecuteScalar(connection, CommandType.Text, query);
                    mm = new MemoryStream(cn1);
                    p2.BackgroundImage = Image.FromStream(mm);
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);


            }

        }
    }
}
