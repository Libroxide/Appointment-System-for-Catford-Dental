using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
            populate();
            patientDataGridView.Visible = false;
            IDTextbox.Focus();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");
        
        private void populate()
        {
            SqlCommand command = new SqlCommand("select * from Patient", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            patientDataGridView.DataSource = dt;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDTextbox.Clear();
            NameTextBox.Clear();
            LastNameTextbox.Clear();
            PhoneTextbox.Clear();
            EmailTextbox.Clear();
            AddressTB.Clear();
            addressline2TB.Clear();
            cityTB.Clear();
            zipTB.Clear();
            CompanyTextbox.Clear();
            PolicyTextbox.Clear();

            IDTextbox.Focus();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                //Check if patient already exists in the database
                SqlCommand search = new SqlCommand("SELECT pat_fName FROM Patient WHERE UPPER(pat_fName) = UPPER('"+NameTextBox.Text+"') AND  UPPER(pat_lName) = UPPER('"+LastNameTextbox.Text+"') AND pat_phoneNo ='"+PhoneTextbox.Text+"';",conn);
                //Get SQLDATA from the search
                SqlDataReader result = search.ExecuteReader();
                //Check if a row with patient name was returned from the search
                if (!result.HasRows)
                {
                    result.Close();
                    //Insert new patient into database
                    SqlCommand command = new SqlCommand("BEGIN TRANSACTION; INSERT INTO Patient (pat_ID,pat_fName, pat_lName, pat_phoneNo, address_line1, address_line2, city, zipcode, pat_emailAddress, medAid_company, medAid_policyNo, medAid_dependantNo) VALUES ('"+ IDTextbox.Text +"','" + NameTextBox.Text + "','" + LastNameTextbox.Text + "','" + PhoneTextbox.Text + "', '" + AddressTB.Text + "','" + addressline2TB.Text + "', '"+ cityTB.Text +"','"+ zipTB.Text +"', '" + EmailTextbox.Text + "', '" + CompanyTextbox.Text + "','" + PolicyTextbox.Text + "', '" + DependantComboBox.Text + "'); COMMIT;", conn);
                    command.ExecuteNonQuery();
                    //Display Success Message
                    MessageBox.Show("Patient Added Successfully");
                    CancelButton.PerformClick();
                    patientDataGridView.DataSource = null;
                    populate();
                    patientDataGridView.Update();
                    patientDataGridView.Refresh();
                    patientDataGridView.Visible = true;
                   
                }
                else //Display Message when theres duplicate
                    MessageBox.Show("Patient: " + NameTextBox.Text + " " + LastNameTextbox.Text + " is already in the database");
                result.Close();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error,"+ex.Message);
            }
            conn.Close();
        }
        

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to Go Back?, Make sure all data has been saved", "Back to Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addPatient_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }


   
    }

    

     
    

