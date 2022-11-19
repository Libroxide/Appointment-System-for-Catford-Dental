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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");
        private string pat_ID;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to Exit?, Make sure all data has been saved", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();


            }
            else
            {
                this.Show();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            LastNameTextbox.Clear();
            PhoneTextbox.Clear();
            EmailTextbox.Clear();
            AddressTextbox.Clear();
            addressL2TB.Clear();
            cityTB.Clear();
            zipTB.Clear();
            CompanyTextbox.Clear();
            PolicyTextbox.Clear();

            NameText.Focus();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            NameText.Clear();
            SurnameText.Clear();
            PhoneText.Clear();

            NameText.Focus();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand search = new SqlCommand("SELECT * FROM Patient WHERE UPPER(pat_fName) =UPPER('" + NameText.Text + "') AND  UPPER(pat_lName) = UPPER('" + SurnameText.Text + "') AND pat_phoneNo LIKE '%" + PhoneText.Text + "%';", conn);
                SqlDataReader result = search.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        NameTextBox.Text = result.GetString(1);
                        LastNameTextbox.Text = result.GetString(2);
                        PhoneTextbox.Text = result.GetString(3);
                        AddressTextbox.Text = result.GetString(4);
                        addressL2TB.Text = result.GetString(5);
                        cityTB.Text = result.GetString(6);
                        
                        EmailTextbox.Text = result.GetString(8);
                        CompanyTextbox.Text = result.GetString(9);
                        PolicyTextbox.Text = result.GetString(10);
                        pat_ID = result.GetString(0);
                        DependentsComboBox.Text = result.GetString(11);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Patient Name, Last Name or Phone number");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, \n" + ex.Message + "...");
            }
            conn.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet.Patient' table. You can move, or remove it, as needed.
            NameText.Focus();
            
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                DialogResult res;
                res = MessageBox.Show("Are you sure you want to update patient details?", "Update Patient PAT"+pat_ID, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("BEGIN TRANSACTION; UPDATE Patient SET pat_fName = '" + NameTextBox.Text + "', pat_lName = '" + LastNameTextbox.Text + "',  pat_phoneNo = '" + PhoneTextbox.Text + "', address_line1 = '" + AddressTextbox.Text + "', address_line2 = '"+ addressL2TB.Text +"', city = '"+ cityTB.Text +"', zipcode = '"+ zipTB.Text +"', pat_emailAddress = '" + EmailTextbox.Text + "', medAid_company = '" + CompanyTextbox.Text + "', medAid_policyNo ='" + PolicyTextbox.Text + "', medAid_dependantNo = '" + DependentsComboBox.Text + "' WHERE pat_ID = '" + tbPatID.Text + "'; COMMIT;", conn);
                    command.ExecuteNonQuery();
                    CancelButton.PerformClick();
                    MessageBox.Show("Patient Succefully Updated");
                    Populate();
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
            conn.Close();

        }

        private void Populate()
        {
            SqlCommand command = new SqlCommand("select * from Patient", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnPatID_Click(object sender, EventArgs e)
        {
            if (tbPatID.Text != "")
            {
                try
                {
                    conn.Open();
                    SqlCommand search = new SqlCommand("SELECT * FROM Patient WHERE pat_ID='" + tbPatID.Text + "';", conn);
                    SqlDataReader result = search.ExecuteReader();
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            NameTextBox.Text = result.GetString(1);
                            LastNameTextbox.Text = result.GetString(2);
                            PhoneTextbox.Text = result.GetString(3);
                            AddressTextbox.Text = result.GetString(4);
                            addressL2TB.Text = result.GetString(5);
                            cityTB.Text = result.GetString(6);
                            
                            EmailTextbox.Text = result.GetString(8);
                            CompanyTextbox.Text = result.GetString(9);
                            PolicyTextbox.Text = result.GetString(10);
                            DependentsComboBox.Text = result.GetString(11);
                            dataGridView1.Update();
                            dataGridView1.Refresh();
                        }
                    }
                   


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error, \n" + ex.Message + "...");
                }
                conn.Close();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
