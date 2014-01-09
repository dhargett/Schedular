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
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
            groupBox2.Hide();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox2.Checked = false;
            checkBox9.Checked = false;
            checkBox1.Checked = false;
            comboBox1.Text = "Professor Name";
            comboBox2.Text = "Room Type";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {   //
            // View Schedule
            //
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Add Column headers
            dataGridView1.Columns.Add("Room #", "Room #");
            dataGridView1.Columns.Add("8", "8:00am");
            dataGridView1.Columns.Add("9", "9:10");
            dataGridView1.Columns.Add("10", "10:20");
            dataGridView1.Columns.Add("11", "11:30am");
            dataGridView1.Columns.Add("12", "12:40pm");
            dataGridView1.Columns.Add("1", "1:50pm");
            dataGridView1.Columns.Add("3", "3:00pm");

            // Add items
            dataGridView1.Rows.Add("Monday");
            dataGridView1.Rows.Add("LA 101", "CS 170 - 001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView1.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("Tuesday");
            dataGridView1.Rows.Add("LA 101", "CS 170 - 001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView1.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");

            // change day cells background colors to Red
            dataGridView1.Rows[0].Cells[0].Style.BackColor = Color.Red;
            dataGridView1.Rows[4].Cells[0].Style.BackColor = Color.Red;

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {   //
            // View Classes
            //
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

                    // Add Column headers
                    dataGridView1.Columns.Add("subject", "Subject");
                    dataGridView1.Columns.Add("classNum", "Class #");
                    dataGridView1.Columns.Add("section", "Section");
                    dataGridView1.Columns.Add("title", "Title");
                    dataGridView1.Columns.Add("professor", "Professor");

             dataGridView1.Rows.Add("MATH", "152", "001", "College Algebra", "Chris Schroder");
             dataGridView1.Rows.Add("CS", "170", "001", "Intro. to Computer Science", "Sherif Rashad");
             dataGridView1.Rows.Add("MATH", "308", "001", "Discrete Mathematics", "Duane Skaggs");


            dataGridView1.ForeColor = Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {   //
            // View Faculty
            //

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Add Column headers
            dataGridView1.Columns.Add("lastName", "Last Name");
            dataGridView1.Columns.Add("firstName", "First Name");
            dataGridView1.Columns.Add("officeNum", "Office #");
            dataGridView1.Columns.Add("officePhoneNum", "Office Phone #");
            dataGridView1.Columns.Add("mobilePhoneNum", "Mobile Phone #");

            dataGridView1.Rows.Add("Ahmadi", "Dora", "LA 108", "555-5555", "444-4444");
            dataGridView1.Rows.Add("Skaggs", "Duane", "LA 205B", "555-5555", "444-4444");


            dataGridView1.ForeColor = Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //
            //  Displays class info in a new groupBox object. This allows for additional class
            //      info to be seen by the Admin.
            //
            groupBox2.Show();
            groupBox2.ForeColor = Color.White;

            label_ClassRight.Text = "Intro to Computer Science";
            label_professorRight.Text = "Sherif Rashad";
            label_roomNumberRight.Text = "LA 101";
            label_sectionRight.Text = "001";
            label_timeRight.Text = "8:00am";
        }

        private void label_close_Click(object sender, EventArgs e)
        {   // 
            // Simply hides the groupBox2 item
            //
            groupBox2.Hide();
        }


            // temporary. will remove. Tests professor preferences form
        private void button3_Click(object sender, EventArgs e)
        {
            // Check if form is opened if so send message.


            ProfessorPreferences professorPrefs = new ProfessorPreferences();
            professorPrefs.Show();
        }
        
    }
}