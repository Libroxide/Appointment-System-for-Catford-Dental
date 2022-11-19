using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign()
        {
            patientPanelSubMenu.Visible = false;
            appointmentsPanelSubMenu.Visible = false;
           

        }
        private void hideSubMenu()
        {
            if (patientPanelSubMenu.Visible == true)
                patientPanelSubMenu.Visible = false;
            if (appointmentsPanelSubMenu.Visible == true)
                appointmentsPanelSubMenu.Visible = false;
            

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            showSubMenu(patientPanelSubMenu);
        }

        private void addPatButton_Click(object sender, EventArgs e)
        {
            addPatient f4 = new addPatient();
            f4.Show();
            hideSubMenu();
         
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to LogOut?", "Log adminOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                LoginForm back = new LoginForm();
                back.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void appButton_Click(object sender, EventArgs e)
        {
            showSubMenu(appointmentsPanelSubMenu);
        }

       

        private void editAppButton_Click(object sender, EventArgs e)
        {
            UpdateAppointment f5 = new UpdateAppointment();
            f5.Show();
            hideSubMenu();

        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            AddApointments f7 = new AddApointments();
            f7.Show();
            hideSubMenu();
        }

        private void delAppButton_Click(object sender, EventArgs e)
        {
            DeleteAppointment f11 = new DeleteAppointment();
            f11.Show();
            hideSubMenu();
        }

        private void delPatButton_Click(object sender, EventArgs e)
        {
            DeletePatient f9 = new DeletePatient();
            f9.Show();
            hideSubMenu();
        }

        private void editPatButton_Click(object sender, EventArgs e)
        {
            Update f8 = new Update();
            f8.Show();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(paymentsPanelSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientPanelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void paymentsButton_Click_1(object sender, EventArgs e)
        {
            PatientPayment f10 = new PatientPayment();
            f10.Show();
            hideSubMenu();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void updatePayment_Click(object sender, EventArgs e)
        {
            updatePatientPayment f12 = new updatePatientPayment();
            f12.Show();
            hideSubMenu();
        }


        private void ReportBtn_Click(object sender, EventArgs e)
        {
            PaymentReport f13 = new PaymentReport();
            f13.Show();
            hideSubMenu();
        }
    }


}
