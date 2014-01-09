using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchedulingSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && maskedTextBox1.Text == "9999")
            {
                AdminMain AdminMain = new AdminMain();
                AdminMain.Show();
                
            }

            else if (textBox1.Text == "User" && maskedTextBox1.Text == "1111")
            {
                UserMain userMain = new UserMain();
                userMain.Show();
            }

            else
            {
                MessageBox.Show("Invalid information. Please try agian.");
            }



        }
    }
}
