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
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
            
            DeleteButton.Visible = false;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;User ID=GroupWst5;Password=hd832");
        private void DeletePatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.groupWst5DataSet.Patient);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst5;User ID=GroupWst5;Password=hd832"));
                {
                    if (PatientNameTextBox.Text != "" || PatientLastNameTextBox.Text != "" || IDtxt.Text != "")
                    {

                        DialogResult res;
                        res = MessageBox.Show("Are you sure you want to Delete Patient?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            conn.Open();
                            string pat_ID = (string)dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
                            SqlCommand command = new SqlCommand("BEGIN TRANSACTION; DELETE FROM Patient WHERE pat_ID = '" + pat_ID + "'; COMMIT;", conn);
                            command.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Deleted");
                            dataGridView1.Update();
                            dataGridView1.Refresh();
                            BindData();
                            PatientNameTextBox.Clear();
                            PatientLastNameTextBox.Clear();
                            PhoneNumberTextBox.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Patient Name");
                    }
                    void BindData()
                    {

                        SqlCommand command = new SqlCommand("select * from Patient", conn);
                        SqlDataAdapter sd = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = sd;
                    }


                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error ,"+ex.Message);
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

       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * from Patient where UPPER(pat_fName) = UPPER('" + PatientNameTextBox.Text + "') AND UPPER(pat_lName) = UPPER('"+PatientLastNameTextBox.Text+"') AND pat_phoneNo LIKE '%"+PhoneNumberTextBox.Text+"%' or pat_ID = '"+ IDtxt.Text +"'", conn);
                conn.Open();
                SqlDataReader result = command.ExecuteReader();
                if (result.HasRows)
                {
                   
                    DeleteButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("There's no patient named " + PatientNameTextBox.Text + " " + PatientLastNameTextBox.Text+", "+PhoneNumberTextBox.Text);
                }
                conn.Close();
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Visible = true;
        }

        private void PhoneNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void PatientLastNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void PatientNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        
    }
}
