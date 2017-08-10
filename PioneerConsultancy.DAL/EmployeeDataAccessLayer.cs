using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PioneerTech.Models;
using System.Threading.Tasks;

namespace PioneerConsultancy.DAL
{
    public class EmployeeDataAccessLayer

    {
        public int TakeEmployeeName(EmployeeModel myEmployee)
        {
            //Creating Sql Database Connection
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                                            "'" + myEmployee.firstName + "','" + myEmployee.lastName + "','" + myEmployee.emailId + "'," +
                                            myEmployee.phoneNumber + "," + myEmployee.alternatePhoneNumber + ",'" + myEmployee.address1 + "','" + myEmployee.address2 +
                                            "','" + myEmployee.homeCountry + "','" + myEmployee.currentCountry + "'," + myEmployee.zipCode + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeProjectDetail(ProjectModel myProject)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectDetail VALUES(" + "'" + myProject.projectName + "','" + myProject.clientName + "','" + myProject.location + "','" + myProject.roles + "'," + myProject.employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeCompanyDetail(CompanyModel myCompany)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO CompanyDetail VALUES(" + "'" + myCompany.employerName + "'," + myCompany.contactNumber + ",'" + myCompany.location + "','" + myCompany.website + "'," + myCompany.employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;
        }

    }
}
