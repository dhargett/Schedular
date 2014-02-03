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
            // View Faculty
            //

            dataGridView_Class.Columns.Clear();
            dataGridView_Class.Rows.Clear();

            // Add Column headers
            dataGridView_Class.Columns.Add("lastName", "Last Name");
            dataGridView_Class.Columns.Add("firstName", "First Name");
            dataGridView_Class.Columns.Add("officeNum", "Office #");
            dataGridView_Class.Columns.Add("officePhoneNum", "Office Phone #");
            dataGridView_Class.Columns.Add("mobilePhoneNum", "Mobile Phone #");

            dataGridView_Class.Rows.Add("Ahmadi", "Dora", "LA 108", "555-5555", "444-4444");
            dataGridView_Class.Rows.Add("Skaggs", "Duane", "LA 205B", "555-5555", "444-4444");


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
            //
            // View Faculty
            //

            dataGridView_Class.Columns.Clear();
            dataGridView_Class.Rows.Clear();

            // Add Column headers
            dataGridView_Class.Columns.Add("lastName", "Last Name");
            dataGridView_Class.Columns.Add("firstName", "First Name");
            dataGridView_Class.Columns.Add("officeNum", "Office #");
            dataGridView_Class.Columns.Add("officePhoneNum", "Office Phone #");
            dataGridView_Class.Columns.Add("mobilePhoneNum", "Mobile Phone #");

            dataGridView_Class.Rows.Add("Ahmadi", "Dora", "LA 108", "555-5555", "444-4444");
            dataGridView_Class.Rows.Add("Skaggs", "Duane", "LA 205B", "555-5555", "444-4444");


            dataGridView_Class.ForeColor = Color.Black;
            dataGridView_Class.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Class.ReadOnly = true;


            button_AddClass_Edit.Visible = true;
            button_AddClass_Delete.Visible = true;
        }

        private void button_AddProfessor_Edit_Click(object sender, EventArgs e)
        {

        }

        private void button_AddProfessor_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_AddProfessor_DoneEditing_Click(object sender, EventArgs e)
        {

        }
    }
}
