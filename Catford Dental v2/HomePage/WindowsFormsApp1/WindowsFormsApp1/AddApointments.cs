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
    public partial class AddApointments : Form
    {
        public string pat_Id = "";
        public AddApointments()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst5DataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.groupWst5DataSet1.Patient);
            // TODO: This line of code loads data into the 'groupWst5DataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.groupWst5DataSet.Appointment);
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datechosen = dateTimePicker2.Value.Date;
            int timechosen = dateTimePicker1.Value.Hour;

            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; Initial Catalog = GroupWst5; Persist Security Info = True; User ID = GroupWst5; Password = hd832");
                SqlCommand command = new SqlCommand("select * from Appointment where app_date = '" + dateTimePicker2.Value.Date + "'", conn);
                 
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                int numRows = dataGridView1.Rows.Count;

                if (numRows <8)
                {

                    MessageBox.Show("Date Available");
                    button3.Visible = true;
                    

                }
                else { MessageBox.Show("Date Not Available Please Select A New Date");
                    
                }         
            }
            catch 

            {
                MessageBox.Show("ERROR");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dtt= dateTimePicker1.Value;
           TimeSpan timeSpan = new TimeSpan(dtt.Hour,dtt.Minute,dtt.Second);
            TimeSpan endAppTime = new TimeSpan(dtt.Hour+1, dtt.Minute, dtt.Second);

            try
            {
                SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; Initial Catalog = GroupWst5; Persist Security Info = True; User ID = GroupWst5; Password = hd832");
                SqlCommand command = new SqlCommand("select  * from Appointment where app_time='" + timeSpan.ToString() + "-"+endAppTime.ToString()+"' and app_date='" + dateTimePicker2.Value.Date + "'", conn);
              
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
                int numRows = dataGridView1.Rows.Count;

                if (numRows == 1)
                {

                    MessageBox.Show("Time Available");
                   


                }
                else
                {
                    MessageBox.Show("Time Not Available Please Select A New Time");

                }
            }
            catch

            {
                MessageBox.Show("ERROR");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)

          
        {
            
           
            try
            {

                SqlConnection conn = new SqlConnection("Data Source = 146.230.177.46; Initial Catalog = GroupWst5; Persist Security Info = True; User ID = GroupWst5; Password = hd832");

                

                SqlCommand command = new SqlCommand("select  * from patient where pat_fName='" + textBox1.Text + "' and pat_phoneNo='" + textBox2.Text + "'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView2.DataSource = dt;
              
                button2.Visible = true;
                



            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime dtt = dateTimePicker1.Value;
            TimeSpan timeSpansele = new TimeSpan(dtt.Hour, dtt.Minute, dtt.Second);
            int procedureid = comboBox1.SelectedIndex + 1;
            TimeSpan endAppTime = new TimeSpan(dtt.Hour+1, dtt.Minute, dtt.Second);
            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst5;User ID=GroupWst5;Password=hd832");
            con.Open();
            String app_date = dateTimePicker2.Value.Date.ToString().Split(' ')[0];
            SqlCommand dupAppointment = new SqlCommand("SELECT app_ID FROM Appointment WHERE app_date = '" +app_date+ "'  AND app_time = '" + timeSpansele.ToString() + "' ",con);
            SqlDataReader dupAppData = dupAppointment.ExecuteReader();
            if (dupAppData.HasRows)
            {
                MessageBox.Show("Duplicate appointment can not be inserted...");
                dupAppData.Close();
                return;
            }
            dupAppData.Close();
            
            SqlCommand command = new SqlCommand("insert into Appointment(app_date, pat_ID, procedure_ID, app_time) values ( '" + dateTimePicker2.Value.Date + "','" +pat_Id+ "'," + procedureid + ",'" + timeSpansele.ToString() + "-"+endAppTime.ToString()+"')", con);

            command.ExecuteNonQuery();
            MessageBox.Show("Appointment Added Successfully");
            con.Close();

            BindData();




        }


        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst5;User ID=GroupWst5;Password=hd832");
            SqlCommand command = new SqlCommand("select * from Appointment", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            con.Close();
            con.Open();
            command = new SqlCommand("SELECT * FROM [Procedure];", con);
            SqlDataReader sqlData = command.ExecuteReader();
            try
            {
                if (comboBox1.Items.Count > 0)
                    comboBox1.Items.Clear();
                if (sqlData.HasRows)
                {
                    while (sqlData.Read())
                    {
                        comboBox1.Items.Add(sqlData.GetString(0).Replace(" ", "") + " - "+sqlData.GetString(1));
                    }
                    comboBox1.Text = comboBox1.Items[0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while filling procedure box\nplease exit form...");
                Console.WriteLine("{0}", ex.Message);
            }
            con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            /**
             * Most of the Appointments Works :)
             * 
             * 
             */
            

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
          
            
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
                pat_Id = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString();
            if(pat_Id != "")
                button2.Visible = true;
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    

