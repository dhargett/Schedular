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
    public partial class AdminMain : Form
    {
        int Count = 1;

        public AdminMain()
        {
            InitializeComponent();

            panel2.Enabled = false;
        }


        private void button_AddClass_Next_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false; // disable the class info so that it cannot be altered while sections are being added
            panel2.Enabled = true; // enable the section info so that it can be specified for each section to be added
            string sections = numericUpDown_Sections.Value.ToString();
            label_SectionsRight.Text = sections;
            label_NumberDynamic.Text = Count.ToString();
        }

        

        private void button_AddClass_Submit_Click(object sender, EventArgs e)
        {
            int sectionsNeeded = (int)Convert.ChangeType(label_SectionsRight.Text, typeof(int));
            Count++;
            if (Count <= sectionsNeeded)
            {

                label_NumberDynamic.Text = Count.ToString();
                // send info to database
                panel2.Refresh();
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                numericUpDown1.Value = 0;
            }

            else if (Count > sectionsNeeded)
            {
                Count = 0;
                // Reset objects and disable/enable panels
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                panel2.Enabled = false;
                
                textBox_ClassTitle.ResetText();
                comboBox_Subject.ResetText();
                textBox_ClassNumber.ResetText();
                numericUpDown_Sections.Value = 0;
                panel1.Enabled = true;
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;

            if (checkBox1.Checked == false)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
        }
    }
}
