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
            button_AddClass_Edit.Visible = false;
            button_AddClass_Delete.Visible = false;
            button_AddClass_DoneEditing.Visible = false;
            button_AddProfessor_Edit.Visible = false;
            button_AddProfessor_Delete.Visible = false;
            button_AddProfessor_DoneEditing.Visible = false;
            button_AddProfessor_ViewEditPreferences.Visible = false;
        }

        /*////////////////////////////////
         * `Add class tab
         * 
         *//////////////////////////////

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

        private void button_AddClass_ViewClasses_Click(object sender, EventArgs e)
        {
            //
            // View Classes
            //
            pictureBox_AddClass_Eagle.Hide(); // ADDED 3:07
            dataGridView_Class.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_Class.Columns.Clear();
            dataGridView_Class.Rows.Clear();

            // Add Column headers
            dataGridView_Class.Columns.Add("subject", "Subject");
            dataGridView_Class.Columns.Add("classNum", "Class #");
            dataGridView_Class.Columns.Add("section", "Section");
            dataGridView_Class.Columns.Add("title", "Title");
            dataGridView_Class.Columns.Add("professor", "Professor");


            dataGridView_Class.Rows.Add("MATH", "152", "001", "College Algebra", "Chris Schroder");
            dataGridView_Class.Rows.Add("CS", "170", "001", "Intro. to Computer Science", "Sherif Rashad");
            dataGridView_Class.Rows.Add("MATH", "308", "001", "Discrete Mathematics", "Duane Skaggs");


            dataGridView_Class.ForeColor = Color.Black;
            dataGridView_Class.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Class.ReadOnly = true;


            button_AddClass_Edit.Visible = true;
            button_AddClass_Delete.Visible = true;

        }

        private void button_AddClass_Edit_Click(object sender, EventArgs e)
        {
            button_AddClass_Edit.Hide();
            button_AddClass_Delete.Hide();
            button_AddClass_DoneEditing.Show();

            if (dataGridView_Class.SelectedRows.Count >= 1)
            {

                if (button_AddClass_DoneEditing.Visible == true)
                {
                    dataGridView_Class.ReadOnly = false;
                }

                else
                {
                    MessageBox.Show("Error 1.13_2.5.3");
                }
            }

            else
            {
                button_AddClass_Edit.Show();
                MessageBox.Show("Please select a record to edit.");                
            }
        }

        private void button_AddClass_DoneEditing_Click(object sender, EventArgs e)
        {
            button_AddClass_DoneEditing.Hide();
            button_AddClass_Edit.Show();
            dataGridView_Class.ReadOnly = true;
            button_AddClass_Delete.Show();
        }

        private void button_AddClass_Delete_Click(object sender, EventArgs e)
        {   //
            // Allows Admin to delete professor records
            //
            if (dataGridView_Class.SelectedRows.Count > 0)
            {
                string message = "Do you wish to delete the selected record(s)?";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                if (MessageBox.Show(message, caption, buttons) == DialogResult.Yes)
                {
                    int count = 0;
                    dataGridView_Class.AllowUserToDeleteRows = true;
                    foreach (DataGridViewRow row in dataGridView_Class.SelectedRows)
                    {
                        if (!row.IsNewRow)
                            dataGridView_Class.Rows.Remove(row);
                        count++;
                    }

                    MessageBox.Show(count + " record(s) deleted.");
                }

                else
                {
                    MessageBox.Show("0 records deleted."); // Error message. Numbers represent first letters in form and method
                }                                        //   each seperated by an underscore.
            }

            else
                MessageBox.Show("Please select a record to delete."); 
        }

        /*/////////////////////////////////////////////
         *  Add professor Tab
         * 
         *////////////////////////////////////////////

        private void button_AddProfessor_ViewProfessors_Click(object sender, EventArgs e)
        {
            button_AddProfessor_ViewProfessors.Text = "Refresh";
            button_AddProfessor_ViewEditPreferences.Visible = true;
            pictureBox_AddProfessor_Eagle.Visible = false;
            //
            // View Faculty
            //
            dataGridView_Professor.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_Professor.Columns.Clear();
            dataGridView_Professor.Rows.Clear();

            // Add Column headers
            dataGridView_Professor.Columns.Add("lastName", "Last Name");
            dataGridView_Professor.Columns.Add("firstName", "First Name");
            dataGridView_Professor.Columns.Add("officeNum", "Office #");
            dataGridView_Professor.Columns.Add("officePhoneNum", "Office Phone #");
            dataGridView_Professor.Columns.Add("mobilePhoneNum", "Mobile Phone #");

            dataGridView_Professor.Rows.Add("Ahmadi", "Dora", "LA 108", "555-5555", "444-4444");
            dataGridView_Professor.Rows.Add("Skaggs", "Duane", "LA 205B", "555-5555", "444-4444");
            dataGridView_Professor.Rows.Add("O'Brien", "Tim", "LA 203A", "555-5555", "444-4444");
            dataGridView_Professor.Rows.Add("Schroder", "Chris", "LA 203C", "555-5555", "444-4444");
            dataGridView_Professor.Rows.Add("Cyrus", "Vivian", "LA 205D", "555-5555", "444-4444");
            dataGridView_Professor.Rows.Add("Yess", "Capp", "LA 401B", "555-5555", "444-4444");


            dataGridView_Professor.ForeColor = Color.Black;
            dataGridView_Professor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Professor.ReadOnly = true;


            button_AddProfessor_Edit.Visible = true;
            button_AddProfessor_Delete.Visible = true;

        }

        private void button_AddProfessor_Edit_Click(object sender, EventArgs e)
        {
            button_AddProfessor_Edit.Hide();
            button_AddProfessor_Delete.Hide();
            button_AddProfessor_DoneEditing.Show();

            if (dataGridView_Professor.SelectedRows.Count >= 1)
            {

                if (button_AddProfessor_DoneEditing.Visible == true)
                {
                    dataGridView_Professor.ReadOnly = false;
                }

                else
                {
                    MessageBox.Show("Error 1.13_2.5.3");
                }
            }

            else
            {
                button_AddProfessor_Edit.Show();
                MessageBox.Show("Please select a record to edit.");
            }
        }

        private void button_AddProfessor_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Professor.SelectedRows.Count > 0)
            {
                string message = "Do you wish to delete the selected record(s)?";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                if (MessageBox.Show(message, caption, buttons) == DialogResult.Yes)
                {
                    int count = 0;
                    dataGridView_Class.AllowUserToDeleteRows = true;
                    foreach (DataGridViewRow row in dataGridView_Professor.SelectedRows)
                    {
                        if (!row.IsNewRow)
                            dataGridView_Professor.Rows.Remove(row);
                        count++;
                    }

                    MessageBox.Show(count + " record(s) deleted.");
                }

                else
                {
                    MessageBox.Show("0 records deleted."); // Error message. Numbers represent first letters in form and method
                }                                        //   each seperated by an underscore.
            }

            else
                MessageBox.Show("Please select a record to delete."); 
        }

        private void button_AddProfessor_DoneEditing_Click(object sender, EventArgs e)
        {
            button_AddProfessor_DoneEditing.Hide();
            button_AddProfessor_Edit.Show();
            dataGridView_Professor.ReadOnly = true;
            button_AddProfessor_Delete.Show();
        }

        /* /////////////////////////////////// 
         *      Schedule
         * 
         *///////////////////////////////////

        private void button_Schedule_ViewSchedule_Click(object sender, EventArgs e)
        {
            //
            //  Create schedule
            //
            //button_Schedule_ViewSchedule.Hide();
            pictureBox1.Hide();
            label_Schedule_MCSPScheduler.Hide();
            dataGridView_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_Schedule.Columns.Clear();
            dataGridView_Schedule.Rows.Clear();

            // Add Column headers
            dataGridView_Schedule.Columns.Add("Room #", "Room #");
            dataGridView_Schedule.Columns.Add("8", "8:00am");
            dataGridView_Schedule.Columns.Add("9", "9:10");
            dataGridView_Schedule.Columns.Add("10", "10:20");
            dataGridView_Schedule.Columns.Add("11", "11:30am");
            dataGridView_Schedule.Columns.Add("12", "12:40pm");
            dataGridView_Schedule.Columns.Add("1", "1:50pm");
            dataGridView_Schedule.Columns.Add("3", "3:00pm");

            // Add items
            dataGridView_Schedule.Rows.Add("Monday");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("Tuesday");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("Wednesday");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("Thursday");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("Friday 1");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("Friday 2");
            dataGridView_Schedule.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView_Schedule.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView_Schedule.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");

            // change day cells background colors to Red
            dataGridView_Schedule.Rows[0].Cells[0].Style.BackColor = Color.Red;
            dataGridView_Schedule.Rows[4].Cells[0].Style.BackColor = Color.Red;
            dataGridView_Schedule.Rows[8].Cells[0].Style.BackColor = Color.Red;
            dataGridView_Schedule.Rows[12].Cells[0].Style.BackColor = Color.Red;
            dataGridView_Schedule.Rows[16].Cells[0].Style.BackColor = Color.Red;
            dataGridView_Schedule.Rows[20].Cells[0].Style.BackColor = Color.Red;


            dataGridView_Schedule.ForeColor = Color.Black;
            dataGridView_Schedule.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Schedule.ReadOnly = true;
        }

        private void label_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddProfessor_ViewEditPreferences_Click(object sender, EventArgs e)
        {
            button_AddProfessor_ViewEditPreferences.Visible = false;
            dataGridView_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView_Professor.Columns.Clear();
            dataGridView_Professor.Rows.Clear();

            // Add Column headers
            dataGridView_Professor.Columns.Add("Preferred times", "Preferred Time(s)");
            dataGridView_Professor.Columns.Add("Excludes times", "Excluded Time(s)");
            dataGridView_Professor.Columns.Add("Preferred classes", "Preferred Class(es)");
            dataGridView_Professor.Columns.Add("ITV", "ITV Classes");
            dataGridView_Professor.Columns.Add("Online", "Online");

            // Add Rows
            dataGridView_Professor.Rows.Add("Any", "10:20", "CS 170", "No", "No");
        }
    }
}
