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
    public partial class AddProfessor : Form
    {
        public AddProfessor()
        {
            InitializeComponent();
        }

        private void checkBox_OfficePhoneNumberNA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_OfficePhoneNumberNA.Checked == true)
            {
                maskedTextBox_OfficePhoneNumberRight.Enabled = false;
            }

            else if (checkBox_OfficePhoneNumberNA.Checked == false)
            {
                maskedTextBox_OfficePhoneNumberRight.Enabled = true;
            }

        }

        private void checkBox_CellPhoneNumberNA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CellPhoneNumberNA.Checked == true)
            {
                maskedTextBox_CellPhoneNumberRight.Enabled = false;
            }

            else if (checkBox_CellPhoneNumberNA.Checked == false)
            {
                maskedTextBox_CellPhoneNumberRight.Enabled = true;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            this.Close();

            //Submit data to database
        }
    }
}
