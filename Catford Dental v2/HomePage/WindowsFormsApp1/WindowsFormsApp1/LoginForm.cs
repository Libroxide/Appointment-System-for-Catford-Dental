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



    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst5;Persist Security Info=True;User ID=GroupWst5;Password=hd832");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, password;

            username = UserTextbox.Text;
            password = PasswordTextbox.Text;

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" +UserTextbox.Text+ "'AND password = '"+PasswordTextbox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = UserTextbox.Text;
                    password = PasswordTextbox.Text;

                    //leads to MenuForm
                    MenuForm f3 = new MenuForm();
                    f3.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserTextbox.Clear();
                    PasswordTextbox.Clear();
                    UserTextbox.Focus();

               

                  
                   
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UserTextbox.Clear();
            PasswordTextbox.Clear();

            UserTextbox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }


            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }

        private void UserTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
