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
    public partial class updatePatientPayment : Form
    {
        public updatePatientPayment()
        {
            InitializeComponent();
            DataBind();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void updatePatientPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.groupWst5DataSet.Payments);
            DataBind();
        }

        private void backBtn_Click(object sender, EventArgs e)
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            patientFNameTB.Clear();
            patientLNameTB.Clear();
            phoneNumTB.Clear();
            patientFNameTB.ReadOnly = false;
            patientLNameTB.ReadOnly = false;
            phoneNumTB.ReadOnly = false;
            patientIDTb.Clear();
            dataGridView1.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand search = new SqlCommand("SELECT pat_ID FROM Patient WHERE UPPER(pat_fName) =UPPER('" + patientFNameTB.Text + "') AND  UPPER(pat_lName) = UPPER('" + patientLNameTB.Text + "') AND pat_phoneNo LIKE '%" + phoneNumTB.Text + "%' or pat_ID LIKE '"+ IDtxt.Text +"';", conn);
                SqlDataReader result = search.ExecuteReader();
                if (result.HasRows)
                {
                    string id ="";
                    while (result.Read())
                    {
                        id = result.GetString(0);
                    }
                    patientFNameTB.ReadOnly = true;
                    patientLNameTB.ReadOnly = true;
                    phoneNumTB.ReadOnly = true;
                    result.Close();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM [Payments] WHERE pat_ID='"+ id + "'",conn));
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    if (dt.Rows.Count > 0)
                    {
                        AutoScroll = true;
                        patientIDTb.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                        amountTb.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Patient ID, Name, Last Name or Phone number");
                    CancelButton.PerformClick();
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, \n" + ex.Message + "...");
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DataBind()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [Payments]", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView1.Refresh();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(amountTb.Text != "" && patientIDTb.Text != "" && dataGridView1.CurrentCell.RowIndex < dataGridView1.RowCount - 1)
            {

                try
                {
                    DialogResult res;
                    res = MessageBox.Show("Are you sure you want to update payment?", "Update Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
      
                        conn.Open();
                        string payNo = dataGridView1[0,dataGridView1.CurrentCell.RowIndex].Value.ToString();
                        float amount = float.Parse(amountTb.Text);
                        string patId = patientIDTb.Text;
                        SqlCommand command = new SqlCommand("BEGIN TRANSACTION; UPDATE [Payments] SET pat_ID = '" + patId + "', pay_amount='" + amount + "'  WHERE pay_recepitNo =" + payNo+ "; COMMIT;", conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Payment succefully updated");
                        conn.Close();
                        DataBind();
                        patientIDTb.Clear();
                        amountTb.Clear();
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, " + ex.Message);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Select Payment to Update");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < dataGridView1.RowCount - 1)
            {
                AutoScroll = true;
                patientIDTb.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                amountTb.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            }
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
