using System;
using System.Collections.Generic;

using System.Text;

using System.Configuration;
using System.Data;
namespace DAL
{
    public class Authentication
    {
        //public string GetDBConnection()
        //{
        //    try
        //    {

        //        string connectionString = ConfigurationManager.ConnectionStrings["FootBallMasterConnection"].ConnectionString;
        //        return connectionString;
        //         throw new NullReferenceException();
        //    }
        //    catch (NullReferenceException e)
        //    {
        //        throw;
        //   }
        //}
        public string GetConnection()
        {

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FBDB;Integrated Security=True";//ConfigurationManager.ConnectionStrings["FootBallMasterConnection"].ConnectionString;
            return connectionString;
        }
        public string GetMasterConnection()
        {

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";//ConfigurationManager.ConnectionStrings["MasterConnection"].ConnectionString;
            return connectionString;
        }
        public string GetCurrentDBConnection(string strTour)
        {

            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog='" + strTour + "';Integrated Security=True";
            return connectionString;
        }
      

      
    }
}
