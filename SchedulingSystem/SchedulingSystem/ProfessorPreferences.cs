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
    public partial class ProfessorPreferences : Form
    {
        public ProfessorPreferences()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.HorizontalScrollbar = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // List list upcoming classes for each department for the semester.
            // 
            //  LINK class info here.
            if (comboBox1.SelectedIndex.Equals(0))
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("MATH 091 \"Introductory Algebra\"");
                checkedListBox1.Items.Add("MATH 093 \"Intermediate Algebra\"");
                checkedListBox1.Items.Add("MATH 152 \"College Algebra\"");
                checkedListBox1.Items.Add("MATH 175 \"Calculus 1\"");
                checkedListBox1.Items.Add("MATH 275 \"Calculus 2\"");
                checkedListBox1.Items.Add("MATH 300 \"Introduction to Mathematical Proof\"");
            }

            else if (comboBox1.SelectedIndex.Equals(1))
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("CS 170 \"Introduction to Computer Science\"");
                checkedListBox1.Items.Add("CS 303 \"Data Structures 1\"");
                checkedListBox1.Items.Add("CS 310 \"Data Structures 2\"");
                checkedListBox1.Items.Add("CS 335 \"Theory of Programming Languages\"");
                checkedListBox1.Items.Add("CS 380 \"Software Engineering\"");
            }

            else if (comboBox1.SelectedIndex.Equals(2))
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("PHYS 101 \"History of The Universe\"");
                checkedListBox1.Items.Add("PHYS 201 College Physics 1");
                checkedListBox1.Items.Add("PHYS 202 College Physics 2");
                checkedListBox1.Items.Add("PHYS 231 \"Engineering Physics 1\"");
                checkedListBox1.Items.Add("PHYS 232 \"Engineering Physics 2\"");
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

    }
}
