using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerConsultancy.DAL
{
    public class EmployeeDataAccessLayer

    {
        public int TakeEmployeeName(string firstName, string lastName, string emailId, long phoneNumber, long alternatePhoneNumber, string address1, string address2, string homeCountry, string  currentCountry, int zipCode )
        {
            //Creating Sql Database Connection
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                                            "'" + firstName + "','" + lastName + "','" + emailId + "'," +
                                            phoneNumber + "," + alternatePhoneNumber + ",'" + address1 + "','" + address2 +
                                            "','" + homeCountry + "','" + currentCountry + "'," + zipCode + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeProjectDetail(string projectName, string clientName, string location, string roles, int employeeId)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectDetail VALUES(" + "'" + projectName + "','" + clientName + "','" + location + "','" + roles + "'," + employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeCompanyDetail(string employerName, int contactNumber, string location, string website, int employeeId )
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO CompanyDetail VALUES(" + "'" + employerName + "'," + contactNumber + ",'" + location + "','" + website + "'," + employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;
        }

    }
}
