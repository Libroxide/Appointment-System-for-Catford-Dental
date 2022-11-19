using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
  

    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                panel3.Width += 3;
                if (panel3.Width > 800)
                {
                    timer.Stop();
                LoginForm f2 = new LoginForm();
                f2.Show();
                this.Hide();
                
                }
        }

    }
}

