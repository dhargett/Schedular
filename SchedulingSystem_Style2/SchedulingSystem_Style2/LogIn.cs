using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchedulingSystem_Style2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && maskedTextBox1.Text == "")
            {
                AdminMain adminMain = new AdminMain();
                adminMain.Show();
            }

            else if (textBox1.Text == "User" && maskedTextBox1.Text == "")
            {
                UserMain userMain = new UserMain();
                userMain.Show();
            }

            else
                MessageBox.Show("Invalid Log-In. Please try again.");
            
        }
    }
}
