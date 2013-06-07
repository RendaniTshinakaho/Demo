using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Model;

namespace DataLayer
{
    public class DAL
    {
        public static Model.Employee GetEmployee(int EmpNo)
        {
            string cs = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            SqlConnection connection = null;
            SqlDataReader reader = null;
            try
            {
                connection = new SqlConnection(cs);
                string sql = "SELECT Emp_No,Company_No,Sys_Prefix,ID_No,Account_No FROM EmpMst WHERE Emp_No = '" + EmpNo +
                             "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                Employee employee = new Employee();
                employee.EmpNo = Convert.ToInt32(reader["Emp_No"].ToString());
                employee.CompanyNo = reader["Company_No"].ToString();
                employee.SystemPrefix = reader["Sys_Prefix"].ToString();
                employee.AccountNumber = reader["Account_No"].ToString();
                employee.IdNo = reader["ID_No"].ToString();
                return employee;
            }
            catch (Exception exception)
            {
                //Add Logging
                HttpContext.Current.Trace.Warn("Error", "Error in GetEmployee()", exception);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (connection != null && connection.State != ConnectionState.Closed) connection.Close();
            }
            return null;
        }
    }
}
