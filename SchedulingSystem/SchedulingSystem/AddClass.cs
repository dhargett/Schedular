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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classTitle = textBox_ClassTitle.Text;
            string subject = comboBox_Subject.Text;
            string classNumber = textBox_ClassNumber.Text;
            string sections = numericUpDown_Sections.Value.ToString();
            Section_Details section_details = new Section_Details(classTitle, subject, classNumber, sections);
            section_details.Show();
                                                                    // Add code to allow for back tracking????
        }


    }
}
