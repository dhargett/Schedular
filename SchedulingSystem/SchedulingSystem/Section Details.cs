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
    public partial class Section_Details : Form
    {
        int Count = 1;
        public Section_Details(string classTitle, string subject, string classNumber, string sections)
        {
            InitializeComponent();
            label_ClassTitleRight.Text = classTitle;
            label_SubjectRight.Text = subject;
            label_ClassNumberRight.Text = classNumber;
            label_SectionsRight.Text = sections;
            label_NumberDynamic.Text = Count.ToString();
        }

        //ADDED
        private void update_Sections()
        {
            int count = 1;
            label_NumberDynamic.Text = count.ToString();
        }
        // END ADDED

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
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
        
        private void button_Submit_Click(object sender, EventArgs e)
        {
            
            int sectionsNeeded = (int)Convert.ChangeType(label_SectionsRight.Text, typeof(int));
            Count++;
            if(Count <= sectionsNeeded)
            {
                
                label_NumberDynamic.Text = Count.ToString();
                // send info to database
                this.Refresh();
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                numericUpDown1.Value = 0;
            }

            else if(Count > sectionsNeeded)
            {
                Count = 0;
                this.Close();
            }
            
        }


    }
}
