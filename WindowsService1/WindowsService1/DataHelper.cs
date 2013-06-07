using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsService1
{
  public class DataHelper
    {
      //Create new Method to get username and password

      public static int GetLoginCredentials(string username,string password)
      {
          username.Trim();
          password.Trim();

          //Create Connection
          string connection = ConfigurationManager.ConnectionStrings["DatabaseCon"].ConnectionString;
          using (SqlConnection sc = new SqlConnection())
          {
              sc.ConnectionString = connection;
              sc.Open();
              using (SqlCommand sco = new SqlCommand())
              {
                  sco.CommandType = System.Data.CommandType.Text;
                  sco.CommandText = @"Select * from Login where UserName ='" + username + "' and Password = '" + password + "' ";
                  sco.Connection = sc;
                  if (sco.ExecuteScalar() != null)
                  {
                      return 1;
                  }
                  return 0;
              }
          }

      }
    }
}
