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
    public partial class DeleteAppointment : Form
    {
        public DeleteAppointment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst5;User ID=GroupWst5;Password=hd832");
        private int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.groupWst5DataSet.Appointment);

        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst5DataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult res;
                res = MessageBox.Show("Are you sure you want to Delete Appointment?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    id = (int)dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
                    SqlCommand command = new SqlCommand("BEGIN TRANSACTION; Delete Appointment where app_ID = " + id + "; COMMIT;", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted");
                    patientLastNameTextBox.Clear();
                    patientNameTextBox.Clear();
                    PhoneNumberTextBox.Clear();

                    BindData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error," + ex.Message); 
            }
        }
        void BindData()
        {

            SqlCommand command = new SqlCommand("select * from Appointment", con);

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;




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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void searchAppointment_Click(object sender, EventArgs e)
        {
            DateTime dtt = dateTimePicker1.Value;
            TimeSpan timeSpansele = new TimeSpan(dtt.Hour, dtt.Minute, dtt.Second);
            String app_date = dateTimePicker2.Value.Date.ToString().Split(' ')[0];
            SqlCommand appointment = new SqlCommand("SELECT Appointment.app_ID, Appointment.app_date, Appointment.app_time, Appointment.pat_ID, Appointment.procedure_ID FROM Appointment INNER JOIN Patient ON Patient.pat_ID = Appointment.pat_ID WHERE app_date = '" + app_date + "' AND pat_fName= '"+patientNameTextBox.Text+"' AND pat_lName= '"+patientLastNameTextBox.Text+"'AND pat_phoneNo LIKE '%"+PhoneNumberTextBox.Text+"%' AND app_time LIKE '%" + timeSpansele.ToString() + "%' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(appointment);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
            dataGridView1.Refresh();
            button1.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
