using System;
using System.Collections; // for arraylist
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

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
            dataGridView_Class.AllowUserToAddRows = false;
            dataGridView_Professor.AllowUserToAddRows = false;
            dataGridView_Schedule.AllowUserToAddRows = false;
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
            /*dataGridView_Class.Columns.Add("subject", "Subject");
            dataGridView_Class.Columns.Add("classNum", "Class #");
            dataGridView_Class.Columns.Add("section", "Section");
            dataGridView_Class.Columns.Add("title", "Title");
            dataGridView_Class.Columns.Add("professor", "Professor");


            dataGridView_Class.Rows.Add("MATH", "152", "001", "College Algebra", "Chris Schroder");
            dataGridView_Class.Rows.Add("CS", "170", "001", "Intro. to Computer Science", "Sherif Rashad");
            dataGridView_Class.Rows.Add("MATH", "308", "001", "Discrete Mathematics", "Duane Skaggs");
            */
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DYLAN-PC\DYLAN;Initial Catalog=MCSP_Scheduler;Integrated Security=True");
            sqlCon.Open();

            SqlDataAdapter loadSectionList = new SqlDataAdapter("SELECT * FROM Section", sqlCon);
            DataTable dt = new DataTable();
            loadSectionList.Fill(dt);
            dataGridView_Class.DataSource = dt;

            sqlCon.Close(); 

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
            dataGridView_Professor.Refresh();
            dataGridView_Professor.Refresh();

            SqlConnection sqlCon = new SqlConnection(@"Data Source=DYLAN-PC\DYLAN;Initial Catalog=MCSP_Scheduler;Integrated Security=True");
            //SqlCommand loadProfessorList = new SqlCommand("SELECT * FROM Professor", sqlCon);


            try
            {
                //dataGridView_Professor.Columns.Clear();
                //dataGridView_Professor.Rows.Clear();

                sqlCon.Open();
                
                SqlDataAdapter loadProfessorList = new SqlDataAdapter("SELECT * FROM Professor", sqlCon);
                DataTable dt = new DataTable();
                loadProfessorList.Fill(dt);
                dataGridView_Professor.DataSource = dt;
                
                sqlCon.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("In Exception"); // DELETE
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           /* // Add Column headers
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
            dataGridView_Professor.Rows.Add("Yess", "Capp", "LA 401B", "555-5555", "444-4444");*/


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
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DYLAN-PC\DYLAN;Initial Catalog=MCSP_Scheduler;Integrated Security=True");
            //string professorID = "";
            string firstName = "";
            string lastName = "";
            string officeNumber = "";
            string cellPhoneNumber = "";
            string officePhoneNumber = "";
            string fullName = "";
            int i = 0;
            SqlCommand updateProfessorInfo = new SqlCommand
                        ("UPDATE dbo.Professor " +
                         "SET Professor.FirstName = " + firstName + ", Professor.LastName = " + lastName + ", Professor.OfficeNumber = " + officeNumber + ", Professor.CellPhoneNumber = " + cellPhoneNumber + ", Professor.OfficePhoneNumber =" + officePhoneNumber + ", Professor.FullName = " + fullName +
                         " WHERE Professor.ProfessorID = " + dataGridView_Professor.Rows[i].Cells[0] + ";", sqlCon);
            /*SqlCommand test = new SqlCommand("UPDATE dbo.Professor " +
                         "SET Professor.FirstName = 'Duane' WHERE Professor.ProfessorID = 1;", sqlCon1);*/
            try
            {
                //Professor.ProfessorID = " + professorID + ", 
                sqlCon.Open();
                //MessageBox.Show("Before");
                //test.ExecuteNonQuery();
                foreach (DataGridViewRow row in dataGridView_Professor.Rows)
                {
                    
                    //professorID = dataGridView_Professor.Rows[i].Cells[0].ToString();
                    firstName = dataGridView_Professor.Rows[i].Cells[1].Value.ToString();
                    lastName = dataGridView_Professor.Rows[i].Cells[2].Value.ToString();
                    officeNumber = dataGridView_Professor.Rows[i].Cells[3].Value.ToString();
                    cellPhoneNumber = dataGridView_Professor.Rows[i].Cells[4].Value.ToString();
                    officePhoneNumber = dataGridView_Professor.Rows[i].Cells[5].Value.ToString();
                    fullName = dataGridView_Professor.Rows[i].Cells[6].Value.ToString();

                    updateProfessorInfo = new SqlCommand
                        ("UPDATE dbo.Professor " +
                         "SET Professor.FirstName = '" + firstName + "', Professor.LastName = '" + lastName + "', Professor.OfficeNumber = '" + officeNumber + "', Professor.CellPhoneNumber = '" + cellPhoneNumber + "', Professor.OfficePhoneNumber ='" + officePhoneNumber + "', Professor.FullName = '" + fullName +
                         "' WHERE Professor.ProfessorID = " + dataGridView_Professor.Rows[i].Cells[0].Value.ToString() + ";", sqlCon);
                    MessageBox.Show("Before");
                    updateProfessorInfo.ExecuteNonQuery();
                    MessageBox.Show("After!");
                    i++;
                    
                }
                sqlCon.Close();
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        
        
        
        }
        
        private void button_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete 1");
            string professorID = maskedTextBox_MsuIDRight.Text;
            string firstName = textBox_FirstNameRight.Text;
            string lastName = textBox_LastNameRight.Text;
            string officeNumber = textBox_OfficeRoomNumberRight.Text;
            string fullName = firstName + " " + lastName;
            string officePhoneNumber = maskedTextBox_OfficePhoneNumberRight.Text;
            string cellPhoneNumber = maskedTextBox_CellPhoneNumberRight.Text;

            SqlConnection sqlCon = new SqlConnection(@"Data Source=DYLAN-PC\DYLAN;Initial Catalog=MCSP_Scheduler;Integrated Security=True");

            SqlCommand insertProfessorInfo = new SqlCommand("INSERT INTO dbo.Professor(ProfessorID, FirstName, LastName, OfficeNumber, CellPhoneNumber, OfficePhoneNumber, FullName) VALUES ('" + professorID + "','" + firstName + "', '" + lastName + "', '" + officeNumber + "', '" + cellPhoneNumber + "', '" + officePhoneNumber + "', '" + fullName + "');", sqlCon);

            try
            {
                
                sqlCon.Open();

                insertProfessorInfo.ExecuteNonQuery();
                
                sqlCon.Close();
                
            }

            catch (Exception ex)
            {
                ex.ToString();
            }
            

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
            /*dataGridView_Professor.Columns.Clear();
            dataGridView_Professor.Rows.Clear();

            // Add Column headers
            dataGridView_Professor.Columns.Add("Preferred times", "Preferred Time(s)");
            dataGridView_Professor.Columns.Add("Excludes times", "Excluded Time(s)");
            dataGridView_Professor.Columns.Add("Preferred classes", "Preferred Class(es)");
            dataGridView_Professor.Columns.Add("ITV", "ITV Classes");
            dataGridView_Professor.Columns.Add("Online", "Online");

            // Add Rows
            dataGridView_Professor.Rows.Add("Any", "10:20", "CS 170", "No", "No");*/
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mCSP_SchedulerDataSet.Professor' table. You can move, or remove it, as needed.
            this.professorTableAdapter.Fill(this.mCSP_SchedulerDataSet.Professor);

        }



        /* /////////////////////////////////// 
         *     Make Schedule
         * 
         */
        //////////////////////////////////

        private void button_MakeSchedule_ViewClasses_Click(object sender, EventArgs e)
        {
             SqlConnection sqlCon = new SqlConnection(@"Data Source=DYLAN-PC\DYLAN;Initial Catalog=MCSP_Scheduler;Integrated Security=True");
            //SqlCommand loadProfessorList = new SqlCommand("SELECT * FROM Professor", sqlCon);
             dataGridView1.AllowUserToAddRows = false;

            try
            {
                //dataGridView1.ReadOnly = true;
                dataGridView1.Columns.Clear();
                //dataGridView_Professor.Rows.Clear();
                DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
                //chk.Width.Equals(15);
                dataGridView1.Columns.Add(check);

                sqlCon.Open();

                SqlDataAdapter loadClassList = new SqlDataAdapter("SELECT Course.Subject, Course.CourseNumber, Course.CourseTitle FROM Course", sqlCon);
                DataTable dt = new DataTable();
                loadClassList.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                sqlCon.Close();
                /*DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
                for (int i = 0; i < 15; i++)
                {
                    combo.Items.Add(i+1);
                }

                dataGridView1.AllowUserToAddRows = false;
                combo.HeaderText = "# of Sections";
                dataGridView1.Columns.Add(combo);*/

                //combo.ValueMember.Equals(combo.Selected.ToString()); // maybe???
                //combo.DisplayMember.Equals(combo.Selected.ToString());
                DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
                text.HeaderText = "# of Sections";
                text.ReadOnly = false;
                dataGridView1.Columns.Add(text);
                dataGridView1.Columns[0].Width = 25;
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("In Exception"); // DELETE
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        ArrayList sectionNumbers = new ArrayList(); // global-ish??

        private void button_MakeSchedule_EditSectionDetails_Click(object sender, EventArgs e)
        {
            int i = 0;
            int total = 0;
            
            //int[] numbers = ;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    total++;
                    MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());

                    sectionNumbers.Add(dataGridView1.Rows[i].Cells[4].Value);



                    //MessageBox.Show("Yes");
                }
                else
                {
                    //break;
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    MessageBox.Show("Nope");
                }
                i++;
            }
             // DEBUG LOOP
            for (int h = 0; h < sectionNumbers.Count; h++)
            {
                MessageBox.Show("SectionNumbers[" + h + "] = " + sectionNumbers[h].ToString());
            }
            MessageBox.Show("total boxes checked: " + total);
        }

        private void button_MakeSchedule_SubmitAndEditOtherSections_Click(object sender, EventArgs e)
        {
              // DEBUG loop
            for (int h = 0; h < sectionNumbers.Count; h++)
            {
                MessageBox.Show("SectionNumbers[" + h + "] = " + sectionNumbers[h].ToString());
            }

            //MessageBox.Show("total boxes checked: " + total);


            
            int i = 1;
            // Combo Boxes
            int cmboBox_Professorx = 65, cmboBox_Professory = 35;
            int cmboBox_Computersx = 255, cmboBox_Computersy = 35;
            int cmboBox_SoundSystemx = 255, cmboBox_SoundSystemy = 60;
            int cmboBox_Projectorx = 255, cmboBox_Projectory = 85;

            // Labels
            int label_Professorx = 10, label_Professory = 37;
            int label_Computersx = 175, label_Computersy = 37;
            int label_SoundSystemx = 175, label_SoundSystemy = 62;
            int label_Projectorx = 175, label_Projectory = 87;
            int label_ClassSizex = 9, label_ClassSizey = 87;
            int label_Footerx = 150, label_Footery = 155;
            int label_Course_headerx = 10, label_Course_headery = 12;
                // numeric up-down
            int numUpDown_ClassSizex = 65, numUpDown_ClassSizey = 85;

                // check box 
            int checkBox_Onlinex = 245, checkBox_Onliney = 115;
            for (int j = 0; j < sectionNumbers.Count; j++)
            {
                
                // Removed label coordinates from the loop to keep from writing over pre existing controls (yay?? Nay????)
                int numberOfSections = (int)System.Convert.ChangeType(sectionNumbers[j], typeof(int));


                //int box1x = 5, box1y = 5;
                //int label_Section_headerx = 155, label_Section_headery = 12;

                


                panel8.AutoScroll = true;
                for (i = 1; i <= numberOfSections; i++)
                {


                    ///////////////////////////
                    // create combo boxes
                    //////////////////////////
                    ComboBox cmboBox_Professor = new ComboBox();
                    cmboBox_Professor.Name = "cmboBox_Professor" + i.ToString();
                    cmboBox_Professor.Location = new Point(cmboBox_Professorx, cmboBox_Professory);
                    cmboBox_Professor.Height = 20;
                    cmboBox_Professor.Width = 65;
                    panel8.Controls.Add(cmboBox_Professor);

                    ComboBox cmboBox_Computers = new ComboBox();
                    cmboBox_Computers.Name = "cmboBox_Computers" + i.ToString();
                    cmboBox_Computers.Location = new Point(cmboBox_Computersx, cmboBox_Computersy);
                    cmboBox_Computers.Height = 20;
                    cmboBox_Computers.Width = 65;

                    panel8.Controls.Add(cmboBox_Computers);

                    ComboBox cmboBox_SoundSystem = new ComboBox();
                    cmboBox_SoundSystem.Name = "cmboBox_SoundSystem" + i.ToString();
                    cmboBox_SoundSystem.Location = new Point(cmboBox_SoundSystemx, cmboBox_SoundSystemy);
                    cmboBox_SoundSystem.Height = 20;
                    cmboBox_SoundSystem.Width = 65;
                    panel8.Controls.Add(cmboBox_SoundSystem);

                    ComboBox cmboBox_Projector = new ComboBox();
                    cmboBox_Projector.Name = "cmboBox_Projector" + i.ToString();
                    cmboBox_Projector.Location = new Point(cmboBox_Projectorx, cmboBox_Projectory);
                    cmboBox_Projector.Height = 20;
                    cmboBox_Projector.Width = 65;
                    panel8.Controls.Add(cmboBox_Projector);

                    // create numeric up down 
                    NumericUpDown numUpDown_ClassSize = new NumericUpDown();
                    numUpDown_ClassSize.Name = "numUpDown_ClassSize" + i.ToString();
                    numUpDown_ClassSize.Location = new Point(numUpDown_ClassSizex, numUpDown_ClassSizey);
                    numUpDown_ClassSize.Width = 41;
                    numUpDown_ClassSize.Height = 20;
                    panel8.Controls.Add(numUpDown_ClassSize);


                    ///////////////////////////
                    // create checkbox
                    //////////////////////////
                    CheckBox checkBox_Online = new CheckBox();
                    checkBox_Online.Text = "Online class";
                    checkBox_Online.Name = "checkBox_Online" + i.ToString();
                    checkBox_Online.Location = new Point(checkBox_Onlinex, checkBox_Onliney);
                    checkBox_Online.Click += new EventHandler(checkBox_Online_Click);
                    panel8.Controls.Add(checkBox_Online);

                    //////////////////////////
                    // create labels
                    //////////////////////////
                    Label label_Professor = new Label();
                    label_Professor.Text = "Professor:";
                    label_Professor.Name = "label_Professor" + i.ToString();
                    label_Professor.Location = new Point(label_Professorx, label_Professory);
                    panel8.Controls.Add(label_Professor);


                    Label label_Computers = new Label();
                    label_Computers.Text = "Computers:";
                    label_Computers.Name = "label_Computers" + i.ToString();
                    label_Computers.Location = new Point(label_Computersx, label_Computersy);
                    panel8.Controls.Add(label_Computers);


                    Label label_SoundSystem = new Label();
                    label_SoundSystem.Text = "Sound System:";
                    label_SoundSystem.Name = "label_SoundSystem" + i.ToString();
                    label_SoundSystem.Location = new Point(label_SoundSystemx, label_SoundSystemy);
                    panel8.Controls.Add(label_SoundSystem);


                    Label label_ClassSize = new Label();
                    label_ClassSize.Text = "Size:";
                    label_ClassSize.Name = "label_ClassSize" + i.ToString();
                    label_ClassSize.Location = new Point(label_ClassSizex, label_ClassSizey);
                    panel8.Controls.Add(label_ClassSize);


                    Label label_Projector = new Label();
                    label_Projector.Text = "Projector:";
                    label_Projector.Name = "label_Projector" + i.ToString();
                    label_Projector.Location = new Point(label_Projectorx, label_Projectory);
                    panel8.Controls.Add(label_Projector);


                    Label label_Footer = new Label();
                    label_Footer.Text = "";
                    label_Footer.Name = "label_Footer" + i.ToString();
                    label_Footer.Location = new Point(label_Footerx, label_Footery);
                    panel8.Controls.Add(label_Footer);


                    Label label_Course_header = new Label();
                    label_Course_header.Text = "Course - 00" + (i).ToString();
                    label_Course_header.Name = "label_Course_header" + i.ToString();
                    label_Course_header.Location = new Point(label_Course_headerx, label_Course_headery);
                    panel8.Controls.Add(label_Course_header);

                    //--------------------------
                    // UPDATE Y-Coordinates
                    //--------------------------
                    // combo boxes
                    cmboBox_Professory += 150;
                    cmboBox_Computersy += 150;
                    cmboBox_SoundSystemy += 150;
                    cmboBox_Projectory += 150;

                    // labels
                    label_Professory += 150;
                    label_Computersy += 150;
                    label_SoundSystemy += 150;
                    label_Projectory += 150;
                    label_ClassSizey += 150;
                    label_Footery += 150;
                    label_Course_headery += 150;
                    //label_Section_headery += 150;

                    // numeric up down
                    numUpDown_ClassSizey += 150;

                    // checkbox
                    checkBox_Onliney += 150;

                }


            }

        }


        void checkBox_Online_Click(object sender, EventArgs e)
        {

            CheckBox cb = sender as CheckBox;
            string cb_temp = cb.Name.Remove(15); // gets original name :D (excludes the number)

            if (cb.Checked == true)
            {

                cb.Name = cb.Name.Remove(0, 15);
                int length = cb.Name.Length; // gets the length of the name (of the checkbox control.
                string controlNumber = ""; // will be used to "build" the controls # (accounts for multiple digits)

                for (int i = 0; i < length; i++)
                {
                    string index = (string)System.Convert.ChangeType(cb.Name[i], typeof(string));
                    controlNumber = string.Concat(controlNumber, index);
                    controlNumber.Insert(i, index);
                }

                string name = string.Concat("cmboBox_Computers", controlNumber);
                ComboBox cmb1 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;//(ComboBox)System.Convert.ChangeType(panel1.Controls.Find(name, true), typeof(ComboBox));

                cmb1.Text = "";
                cmb1.Enabled = false;

                name = string.Concat("cmboBox_SoundSystem", controlNumber);
                ComboBox cmb2 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;

                cmb2.Text = "";
                cmb2.Enabled = false;

                name = string.Concat("cmboBox_Projector", controlNumber);
                ComboBox cmb3 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;

                cmb3.Text = "";
                cmb3.Enabled = false;

                cb.Name = string.Concat(cb_temp, cb.Name); // rebuilds the original checkbox string
            }

            else if (cb.Checked == false)
            {
                cb.Name = cb.Name.Remove(0, 15);
                int length = cb.Name.Length; // gets the length of the name (of the checkbox control.
                string controlNumber = ""; // will be used to "build" the controls # (accounts for multiple digits)

                for (int i = 0; i < length; i++)
                {
                    string index = (string)System.Convert.ChangeType(cb.Name[i], typeof(string));
                    controlNumber = string.Concat(controlNumber, index);
                    controlNumber.Insert(i, index);
                }

                string name = string.Concat("cmboBox_Computers", controlNumber);
                ComboBox cmb1 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;

                cmb1.Text = "";
                cmb1.Enabled = true;

                name = string.Concat("cmboBox_SoundSystem", controlNumber);
                ComboBox cmb2 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;

                cmb2.Text = "";
                cmb2.Enabled = true;

                name = string.Concat("cmboBox_Projector", controlNumber);
                ComboBox cmb3 = panel8.Controls.Find(name, true).FirstOrDefault() as ComboBox;

                cmb3.Text = "";
                cmb3.Enabled = true;
                cb.Name = string.Concat(cb_temp, cb.Name);
            }


        }








    }
}
