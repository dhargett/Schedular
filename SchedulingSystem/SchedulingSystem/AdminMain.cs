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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
            groupBox2.Hide();
            button_Delete.Hide();
            button_Edit.Hide();
            button_DoneEdit.Hide();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddClass addClass = new AddClass();
            addClass.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddProfessor addProfessor = new AddProfessor();
            addProfessor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //
            //  Create schedule
            //
            button1.Hide();
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
            dataGridView1.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView1.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("Tuesday");
            dataGridView1.Rows.Add("LA 101", "CS 170-001", "MATH 135 - 001", "PHYS 101", "MATH 175", "MATH 152", "CS 380");
            dataGridView1.Rows.Add("LA 103", "data", "data", "data", "data", "data", "data");
            dataGridView1.Rows.Add("LA 109", "data", "data", "data", "data", "data", "data");

            // change day cells background colors to Red
            dataGridView1.Rows[0].Cells[0].Style.BackColor = Color.Red;
            dataGridView1.Rows[4].Cells[0].Style.BackColor = Color.Red;

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_RoomType.Checked = false;
            checkBox_TTHF.Checked = false;
            checkBox_MWF.Checked = false;
            checkBox_RoomNum.Checked = false;
            checkBox_Professor.Checked = false;
            checkBox_ClearAll.Checked = false;
            comboBox_ProfessorName.Text = "Professor Name";
            comboBox_RoomType.Text = "Room Type";
        }

        private void button3_Click(object sender, EventArgs e)
        {   //
            // class Info
            //
            button_Delete.Hide();   // May need to comment these lines for 
            button_Edit.Hide();    // editing/ deleting class info.

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //View Schedule
            button_Delete.Hide();
            button_Edit.Hide();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;

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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ReadOnly = true;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {   //
            // View Professors
            //
            button_Delete.Show();
            button_Edit.Show();           
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;

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

        private void button_Edit_Click(object sender, EventArgs e)
        {   //
            // Add functionality to edit professor info
            //
            button_Edit.Hide();
            button_Delete.Hide();
            button_DoneEdit.Show();

            if (dataGridView1.SelectedRows.Count >= 1)
            {

                if (button_DoneEdit.Visible == true)
                {
                    dataGridView1.ReadOnly = false;
                }

                else
                {
                    MessageBox.Show("Error 1.13_2.5.3"); 
                }
            }

            else
            {
                button_Edit.Show();
                MessageBox.Show("Please select a record to edit.");// please select a record message                
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {   //
            // Allows Admin to delete professor records
            //
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string message = "Do you wish to delete the selected record(s)?";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                if (MessageBox.Show(message, caption, buttons) == DialogResult.Yes)
                {
                    int count = 0;
                    dataGridView1.AllowUserToDeleteRows = true;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                            dataGridView1.Rows.Remove(row);
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

        private void button_DoneEdit_Click(object sender, EventArgs e)
        {
            button_DoneEdit.Hide();
            button_Edit.Show();
            MessageBox.Show("Done editing");
            dataGridView1.ReadOnly = true;
            button_Delete.Show();
        }


        /*
         * 
         * The following methods are used to validate data that has been entered into 
         *      the dataGridView object. Forms of input include: Edit features.
         *              ---- M E T H O D S ----
         *      1) Professor edit feature
         * 
         * 
         * 
         * 
         */


        

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //
            // This method validates updated changes made to professor data. It will check
            //      for: null entries, multiple spaces, and phone #'s that are too long.
            //

            // Empty
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = "Must not be empty!";
                e.Cancel = true;
            }


                 // ######################## //
                // UNDER CONSTRUCTION       //
               // ######################## //

            /*string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            if (headerText.Equals("Office Phone #"))
            {
                // validate that phone # is of correct length
            }

            else if (headerText.Equals("Office Phone #"))
            {
                // validate that phone # is of correct length
            }*/
                // ######################### //
               // ### END CONSTRUCTION #### //
              // ######################### //
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {   //
            // This method validates updated changes made to professor data. It will check
            //      for: null entries, multiple spaces, and phone #'s that are too long.
            //
            
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;

        }


    }
}
