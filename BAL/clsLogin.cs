using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BAL
{
    public class clsLogin
    {
        Authentication clsAut = new Authentication();
        string Connection;
        string query;
        public int fnLogin(string strUserName, string strPassword)
        {
            Connection = clsAut.GetConnection();
            DataTable dt = new DataTable();
            query = "select * from Users where Username='" + strUserName + "' and Password='" + strPassword + "'";
            dt = sqlhelper.ExecuteDatatable(Connection, CommandType.Text, query);
            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
