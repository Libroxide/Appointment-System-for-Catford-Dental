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
    public partial class PatientPayment : Form
    {
        public PatientPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(patientID.Text != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; Initial Catalog = GroupWst5; Persist Security Info = True; User ID = GroupWst5; Password = hd832");
                    DialogResult res;
                    res = MessageBox.Show("Are you sure you want to Add payment for "+patientLastNameTextBox.Text+" ?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)

                    {
                        conn.Open();
                        SqlCommand lastentry = new SqlCommand("Select TOP 1 pay_recepitNo FROM Payments ORDER BY pay_recepitNo DESC;", conn);
                        SqlDataReader last = lastentry.ExecuteReader();
                        int payrecepitNo = 1;
                        if (last.HasRows)
                        {

                            while (last.Read())
                                payrecepitNo = last.GetInt32(0) + 1;

                        }

                        last.Close();

                        DateTime now = DateTime.Now;
                        SqlCommand command = new SqlCommand("BEGIN TRANSACTION;INSERT INTO Payments VALUES("+payrecepitNo+",'"+patientID.Text+"',"+amount.Text+",'"+now.Date.ToString()+"'); COMMIT;", conn);
                        command.ExecuteNonQuery();
                        CancelButton.PerformClick();
                        MessageBox.Show("Payment Succefully Added");
                        dataGridView1.Visible = true;
                        BindData();
                        dataGridView1.Update();
                        dataGridView1.Refresh();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, " + ex.Message);

                }

            }
            else
            {
                MessageBox.Show("Error, patient id is empty.");
            }
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand search = new SqlCommand("SELECT pat_ID FROM Patient WHERE UPPER(pat_fName) =UPPER('" + patientNameTextBox.Text + "') AND  UPPER(pat_lName) = UPPER('" +patientLastNameTextBox.Text + "') AND pat_phoneNo LIKE '%" + PhoneNumberTextBox.Text + "%';", conn);
                SqlDataReader result = search.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                        patientID.Text = result.GetString(0);
                    patientNameTextBox.ReadOnly = true;
                    patientLastNameTextBox.ReadOnly = true;
                    PhoneNumberTextBox.ReadOnly = true;
                    CancelButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Patient Name, Last Name or Phone number");
                    CancelButton.PerformClick();
                    CancelButton.Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, \n" + ex.Message + "...");
            }
            conn.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            patientLastNameTextBox.Clear();
            patientNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            patientNameTextBox.ReadOnly = false;
            patientLastNameTextBox.ReadOnly = false;
            PhoneNumberTextBox.ReadOnly = false;
            CancelButton.Visible = false;
            patientID.Clear();
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to Exit?, Make sure all data has been saved", "Back to Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();


            }
            else
            {
                this.Show();
            }
        }

        private void PatientPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.groupWst5DataSet.Payments);

        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Payments;" , conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
