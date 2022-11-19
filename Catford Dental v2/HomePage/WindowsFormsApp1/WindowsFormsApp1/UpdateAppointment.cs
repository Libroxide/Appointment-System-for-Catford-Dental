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
    public partial class UpdateAppointment : Form
    {
        public UpdateAppointment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to Exit?, Make sure all data has been saved", "Exiting Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();


            }
            else
            {
                this.Show();
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            patientLastNameTextBox.Clear();
            patientNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst5DataSet);

        }



        private void searchAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT Appointment.app_ID, Appointment.app_date, Appointment.app_time, Appointment.pat_ID, Appointment.procedure_ID FROM Appointment INNER JOIN Patient ON Patient.pat_ID = Appointment.pat_ID WHERE app_date = '" + dateTimePicker3.Value.Date.ToString() + "' AND pat_fName= '" + patientNameTextBox.Text + "' AND pat_lName= '" + patientLastNameTextBox.Text + "'AND pat_phoneNo LIKE '%" + PhoneNumberTextBox.Text + "%' ", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                patientDataGridView.DataSource = dt;
                patientDataGridView.Update();
                patientDataGridView.Refresh();
                if (dt.Rows.Count > 0)
                {
                    dateTimePicker1.Value = (DateTime)patientDataGridView[1, patientDataGridView.CurrentCell.RowIndex].Value;
                    int procedureid = (int)patientDataGridView[4, patientDataGridView.CurrentCell.RowIndex].Value;
                    comboBox1.SelectedIndex = (int)procedureid - 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patientDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (patientDataGridView.CurrentCell.RowIndex < patientDataGridView.RowCount - 1)
            {
                dateTimePicker1.Value = (DateTime)patientDataGridView[1, patientDataGridView.CurrentCell.RowIndex].Value;
                int procedureid = (int)patientDataGridView[4, patientDataGridView.CurrentCell.RowIndex].Value;
                comboBox1.SelectedIndex = (int)procedureid - 1;
                Object time = patientDataGridView[2, patientDataGridView.CurrentCell.RowIndex].Value;
                string[] times = time.ToString().Split('-');
                string[] actual_time = times[0].Split(':');

                dateTimePicker2.Value = new DateTime(2022, 11, 29, int.Parse(actual_time[0]), int.Parse(actual_time[1]), 00);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res;
                res = MessageBox.Show("Are you sure you want to update appointment?", "Update Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int procedureid = comboBox1.SelectedIndex + 1;
                    conn.Open();
                    DateTime dtt = dateTimePicker2.Value;
                    TimeSpan timeSpansele = new TimeSpan(dtt.Hour, dtt.Minute, dtt.Second);
                    TimeSpan endAppTime = new TimeSpan(dtt.Hour + 1, dtt.Minute, dtt.Second);
                    SqlCommand command = new SqlCommand("BEGIN TRANSACTION; UPDATE [Appointment] SET app_date= '" + dateTimePicker1.Value.Date + "', app_time='" + timeSpansele.ToString() + "-" + endAppTime.ToString() + "', procedure_ID =" + procedureid + "  WHERE app_ID =" + patientDataGridView[0, patientDataGridView.CurrentCell.RowIndex].Value + "; COMMIT;", conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Appointment succefully updated");
                    conn.Close();
                    DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
            conn.Close();
        }


        void DataBind()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Appointment]", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            patientDataGridView.DataSource = dt;
            patientDataGridView.Update();
            patientDataGridView.Refresh();
            conn.Open();
            command = new SqlCommand("SELECT * FROM [Procedure];", conn);
            SqlDataReader sqlData = command.ExecuteReader();
            try
            {
                if (comboBox1.Items.Count > 0)
                    comboBox1.Items.Clear();
                if (sqlData.HasRows)
                {
                    while (sqlData.Read())
                    {
                        comboBox1.Items.Add(sqlData.GetString(0).Replace(" ", "") + " - " + sqlData.GetString(1));
                    }
                    comboBox1.Text = comboBox1.Items[0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while filling procedure box\nplease exit form...");
                Console.WriteLine("{0}", ex.Message);
            }
            conn.Close();
        }

        private void patientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientDataGridView.CurrentCell.RowIndex < patientDataGridView.RowCount - 1)
            {
                dateTimePicker1.Value = (DateTime)patientDataGridView[1, patientDataGridView.CurrentCell.RowIndex].Value;
                int procedureid = (int)patientDataGridView[4, patientDataGridView.CurrentCell.RowIndex].Value;
                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = (int)procedureid - 1;
                Object time = patientDataGridView[2, patientDataGridView.CurrentCell.RowIndex].Value;
                string[] times = time.ToString().Split('-');
                string[] actual_time = times[0].Split(':');

                dateTimePicker2.Value = new DateTime(2022, 11, 29, int.Parse(actual_time[0]), int.Parse(actual_time[1]), 00);
                //dateTimePicker2.Value = new DateTime(2022, 06, 29, int.Parse(time.ToString().Split(':')[0]), int.Parse(time.ToString().Split(':')[1]), int.Parse(time.ToString().Split(':')[2]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
