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
using PioneerTech.Models;

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


            CompanyModel myCompany = new CompanyModel()
            {
                employerName = employerNameTextBox.Text,
                contactNumber = Convert.ToInt32(contactNumberTextBox.Text),
                location = locationTextBox.Text,
                website = websiteTextBox.Text,
                employeeId = Convert.ToInt32(textBox2.Text)
            };



            EmployeeDataAccessLayer myCompanyDal = new EmployeeDataAccessLayer();
            int result = myCompanyDal.TakeCompanyDetail(myCompany);

            if (result > 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Not done");
            }


            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            EmployeeModel myEmployee = new EmployeeModel
            {
                firstName= firstNameTextBox.Text,
                lastName = lastNameTextBox.Text,
                emailId = emailIDTextBox.Text,
                phoneNumber = Convert.ToInt64(phoneNumberTextBox.Text),
                alternatePhoneNumber = Convert.ToInt64(alternatePhoneTextBox.Text),
                address1 = address1TextBox.Text,
                address2 = address2TextBox.Text,
                homeCountry = homeCountryTextBox.Text,
                currentCountry = currentCountryTextBox.Text,
                zipCode = Convert.ToInt32(zipcodeTextBox.Text)
            };











            EmployeeDataAccessLayer myempdataal = new EmployeeDataAccessLayer();
            int result = myempdataal.TakeEmployeeName(myEmployee) ;
            if (result > 0)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("fail");
            }


           




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
            ProjectModel myProject = new ProjectModel()
            {
                projectName = projectNameTextBox.Text,
                clientName = clientNameTextBox.Text,
                location = projectLocationTextBox.Text,
                roles = rolesTextBox.Text,
                employeeId = Convert.ToInt32(employeeIdTextBox.Text)
            };
            EmployeeDataAccessLayer myProjectDal = new EmployeeDataAccessLayer();
            ServiceReference1.Service1Client sc1 = new ServiceReference1.Service1Client();
            var result = sc1.TakeProjectDetail(myProject);
            
            
            if (result > 0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Failure");
            }


            
        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

