using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PioneerConsultancy.DAL;


namespace Pioneer.Consultancy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void companyDetailsSaveButton_Click(object sender, EventArgs e)
        {
            var employerName = employerNameTextBox.Text;
            var contactNumber = Convert.ToInt32(contactNumberTextBox.Text);
            var location = locationTextBox.Text;
            var website = websiteTextBox.Text;
            var employeeId = Convert.ToInt32(textBox2.Text);

            EmployeeDataAccessLayer myCompanyDal = new EmployeeDataAccessLayer();
            int result = myCompanyDal.TakeCompanyDetail(employerName, contactNumber, location, website, employeeId);

            if (result > 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Not done");
            }


            //Creating Sql Database Connection
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO CompanyDetail VALUES(" + "'" + employerName + "'," + contactNumber + ",'" + location + "','" + website + "'," + employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            SqlDataReader Dr = cmd.ExecuteReader();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string emailId = emailIDTextBox.Text;
                var phoneNumber = Convert.ToInt64(phoneNumberTextBox.Text);
                var alternatePhoneNumber = Convert.ToInt64(alternatePhoneTextBox.Text);
                string address1 = address1TextBox.Text;
                string address2 = address2TextBox.Text;
                string homeCountry = homeCountryTextBox.Text;
                string currentCountry = currentCountryTextBox.Text;
                var zipCode = Convert.ToInt32(zipcodeTextBox.Text);

            EmployeeDataAccessLayer myempdataal = new EmployeeDataAccessLayer();
            int result = myempdataal.TakeEmployeeName(firstName, lastName, emailId, phoneNumber, alternatePhoneNumber, address1, address2, homeCountry, currentCountry, zipCode );
            if (result > 0)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("fail");
            }


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
            SqlDataReader Dr = cmd.ExecuteReader();




        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(textBox1.Text);
            // Creating Sql Database Connection
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmdE = new SqlCommand("SELECT *FROM EmployeeDetail WHERE EmployeeID =" + empid, mysqlconnection);
            SqlCommand cmdP = new SqlCommand("SELECT *FROM Projectdetail WHERE EmployeeID =" + empid, mysqlconnection);
            SqlCommand cmdC = new SqlCommand("SELECT *FROM CompanyDetail WHERE EmployeeID =" + empid, mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            SqlDataReader DataE = cmdE.ExecuteReader();
            BindingSource src = new BindingSource();
            src.DataSource = DataE;
            mysqlconnection.Close();

            mysqlconnection.Open();
            SqlDataReader DataP = cmdP.ExecuteReader();
            BindingSource src1 = new BindingSource();
            src1.DataSource = DataP;
            mysqlconnection.Close();

            mysqlconnection.Open();
            SqlDataReader DataC = cmdC.ExecuteReader();
            BindingSource src2 = new BindingSource();
            src2.DataSource = DataC;
            mysqlconnection.Close();


            dataGridView2.DataSource = src;
            dataGridView3.DataSource = src1;
            dataGridView1.DataSource = src2;

        }

        private void projectDetailsSaveButton_Click(object sender, EventArgs e)
        {
            string projectName = projectNameTextBox.Text;
            string clientName = clientNameTextBox.Text;
            string location = projectLocationTextBox.Text;
            string roles = rolesTextBox.Text;
            var employeeId = Convert.ToInt32(employeeIdTextBox.Text);

            EmployeeDataAccessLayer myProjectDal = new EmployeeDataAccessLayer();
            int result = myProjectDal.TakeProjectDetail(projectName, clientName, location, roles, employeeId);
            if (result > 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Failure");
            }


            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectDetail VALUES(" + "'" + projectName + "','" + clientName + "','" + location + "','" + roles +"'," + employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            SqlDataReader Dr = cmd.ExecuteReader();
            mysqlconnection.Close();
        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

