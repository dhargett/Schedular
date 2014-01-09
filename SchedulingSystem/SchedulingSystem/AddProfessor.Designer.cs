namespace SchedulingSystem
{
    partial class AddProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.maskedTextBox_MsuIDRight = new System.Windows.Forms.MaskedTextBox();
            this.textBox_LastNameRight = new System.Windows.Forms.TextBox();
            this.textBox_FirstNameRight = new System.Windows.Forms.TextBox();
            this.label_MsuIDLeft = new System.Windows.Forms.Label();
            this.label_LastNameLeft = new System.Windows.Forms.Label();
            this.label_FirstNameLeft = new System.Windows.Forms.Label();
            this.label_OfficeRoomNumberLeft = new System.Windows.Forms.Label();
            this.label_OfficePhoneNumberLeft = new System.Windows.Forms.Label();
            this.label_CellPhoneNumberLeft = new System.Windows.Forms.Label();
            this.textBox_OfficeRoomNumberRight = new System.Windows.Forms.TextBox();
            this.maskedTextBox_CellPhoneNumberRight = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_CellPhoneNumberNA = new System.Windows.Forms.CheckBox();
            this.checkBox_OfficePhoneNumberNA = new System.Windows.Forms.CheckBox();
            this.maskedTextBox_OfficePhoneNumberRight = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_OfficePhoneNumberNA);
            this.groupBox1.Controls.Add(this.checkBox_CellPhoneNumberNA);
            this.groupBox1.Controls.Add(this.button_Submit);
            this.groupBox1.Controls.Add(this.maskedTextBox_OfficePhoneNumberRight);
            this.groupBox1.Controls.Add(this.maskedTextBox_CellPhoneNumberRight);
            this.groupBox1.Controls.Add(this.maskedTextBox_MsuIDRight);
            this.groupBox1.Controls.Add(this.textBox_LastNameRight);
            this.groupBox1.Controls.Add(this.textBox_OfficeRoomNumberRight);
            this.groupBox1.Controls.Add(this.textBox_FirstNameRight);
            this.groupBox1.Controls.Add(this.label_CellPhoneNumberLeft);
            this.groupBox1.Controls.Add(this.label_OfficePhoneNumberLeft);
            this.groupBox1.Controls.Add(this.label_MsuIDLeft);
            this.groupBox1.Controls.Add(this.label_OfficeRoomNumberLeft);
            this.groupBox1.Controls.Add(this.label_LastNameLeft);
            this.groupBox1.Controls.Add(this.label_FirstNameLeft);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(40, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professor Info";
            // 
            // button_Submit
            // 
            this.button_Submit.ForeColor = System.Drawing.Color.Black;
            this.button_Submit.Location = new System.Drawing.Point(454, 139);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // maskedTextBox_MsuIDRight
            // 
            this.maskedTextBox_MsuIDRight.Location = new System.Drawing.Point(116, 79);
            this.maskedTextBox_MsuIDRight.Name = "maskedTextBox_MsuIDRight";
            this.maskedTextBox_MsuIDRight.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox_MsuIDRight.TabIndex = 2;
            // 
            // textBox_LastNameRight
            // 
            this.textBox_LastNameRight.Location = new System.Drawing.Point(116, 54);
            this.textBox_LastNameRight.Name = "textBox_LastNameRight";
            this.textBox_LastNameRight.Size = new System.Drawing.Size(134, 20);
            this.textBox_LastNameRight.TabIndex = 1;
            // 
            // textBox_FirstNameRight
            // 
            this.textBox_FirstNameRight.Location = new System.Drawing.Point(116, 29);
            this.textBox_FirstNameRight.Name = "textBox_FirstNameRight";
            this.textBox_FirstNameRight.Size = new System.Drawing.Size(134, 20);
            this.textBox_FirstNameRight.TabIndex = 1;
            // 
            // label_MsuIDLeft
            // 
            this.label_MsuIDLeft.AutoSize = true;
            this.label_MsuIDLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MsuIDLeft.Location = new System.Drawing.Point(44, 83);
            this.label_MsuIDLeft.Name = "label_MsuIDLeft";
            this.label_MsuIDLeft.Size = new System.Drawing.Size(57, 16);
            this.label_MsuIDLeft.TabIndex = 0;
            this.label_MsuIDLeft.Text = "MSU ID:";
            // 
            // label_LastNameLeft
            // 
            this.label_LastNameLeft.AutoSize = true;
            this.label_LastNameLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastNameLeft.Location = new System.Drawing.Point(25, 58);
            this.label_LastNameLeft.Name = "label_LastNameLeft";
            this.label_LastNameLeft.Size = new System.Drawing.Size(76, 16);
            this.label_LastNameLeft.TabIndex = 0;
            this.label_LastNameLeft.Text = "Last Name:";
            // 
            // label_FirstNameLeft
            // 
            this.label_FirstNameLeft.AutoSize = true;
            this.label_FirstNameLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstNameLeft.Location = new System.Drawing.Point(25, 33);
            this.label_FirstNameLeft.Name = "label_FirstNameLeft";
            this.label_FirstNameLeft.Size = new System.Drawing.Size(76, 16);
            this.label_FirstNameLeft.TabIndex = 0;
            this.label_FirstNameLeft.Text = "First Name:";
            // 
            // label_OfficeRoomNumberLeft
            // 
            this.label_OfficeRoomNumberLeft.AutoSize = true;
            this.label_OfficeRoomNumberLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OfficeRoomNumberLeft.Location = new System.Drawing.Point(294, 33);
            this.label_OfficeRoomNumberLeft.Name = "label_OfficeRoomNumberLeft";
            this.label_OfficeRoomNumberLeft.Size = new System.Drawing.Size(95, 16);
            this.label_OfficeRoomNumberLeft.TabIndex = 0;
            this.label_OfficeRoomNumberLeft.Text = "Office Room #:";
            // 
            // label_OfficePhoneNumberLeft
            // 
            this.label_OfficePhoneNumberLeft.AutoSize = true;
            this.label_OfficePhoneNumberLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OfficePhoneNumberLeft.Location = new System.Drawing.Point(292, 58);
            this.label_OfficePhoneNumberLeft.Name = "label_OfficePhoneNumberLeft";
            this.label_OfficePhoneNumberLeft.Size = new System.Drawing.Size(97, 16);
            this.label_OfficePhoneNumberLeft.TabIndex = 0;
            this.label_OfficePhoneNumberLeft.Text = "Office Phone #:";
            // 
            // label_CellPhoneNumberLeft
            // 
            this.label_CellPhoneNumberLeft.AutoSize = true;
            this.label_CellPhoneNumberLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CellPhoneNumberLeft.Location = new System.Drawing.Point(303, 83);
            this.label_CellPhoneNumberLeft.Name = "label_CellPhoneNumberLeft";
            this.label_CellPhoneNumberLeft.Size = new System.Drawing.Size(86, 16);
            this.label_CellPhoneNumberLeft.TabIndex = 0;
            this.label_CellPhoneNumberLeft.Text = "Cell Phone #:";
            // 
            // textBox_OfficeRoomNumberRight
            // 
            this.textBox_OfficeRoomNumberRight.Location = new System.Drawing.Point(395, 29);
            this.textBox_OfficeRoomNumberRight.Name = "textBox_OfficeRoomNumberRight";
            this.textBox_OfficeRoomNumberRight.Size = new System.Drawing.Size(134, 20);
            this.textBox_OfficeRoomNumberRight.TabIndex = 1;
            // 
            // maskedTextBox_CellPhoneNumberRight
            // 
            this.maskedTextBox_CellPhoneNumberRight.Location = new System.Drawing.Point(395, 79);
            this.maskedTextBox_CellPhoneNumberRight.Mask = "(999) 000-0000";
            this.maskedTextBox_CellPhoneNumberRight.Name = "maskedTextBox_CellPhoneNumberRight";
            this.maskedTextBox_CellPhoneNumberRight.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox_CellPhoneNumberRight.TabIndex = 2;
            // 
            // checkBox_CellPhoneNumberNA
            // 
            this.checkBox_CellPhoneNumberNA.AutoSize = true;
            this.checkBox_CellPhoneNumberNA.Location = new System.Drawing.Point(535, 84);
            this.checkBox_CellPhoneNumberNA.Name = "checkBox_CellPhoneNumberNA";
            this.checkBox_CellPhoneNumberNA.Size = new System.Drawing.Size(46, 17);
            this.checkBox_CellPhoneNumberNA.TabIndex = 4;
            this.checkBox_CellPhoneNumberNA.Text = "N/A";
            this.checkBox_CellPhoneNumberNA.UseVisualStyleBackColor = true;
            this.checkBox_CellPhoneNumberNA.CheckedChanged += new System.EventHandler(this.checkBox_CellPhoneNumberNA_CheckedChanged);
            // 
            // checkBox_OfficePhoneNumberNA
            // 
            this.checkBox_OfficePhoneNumberNA.AutoSize = true;
            this.checkBox_OfficePhoneNumberNA.Location = new System.Drawing.Point(535, 56);
            this.checkBox_OfficePhoneNumberNA.Name = "checkBox_OfficePhoneNumberNA";
            this.checkBox_OfficePhoneNumberNA.Size = new System.Drawing.Size(46, 17);
            this.checkBox_OfficePhoneNumberNA.TabIndex = 4;
            this.checkBox_OfficePhoneNumberNA.Text = "N/A";
            this.checkBox_OfficePhoneNumberNA.UseVisualStyleBackColor = true;
            this.checkBox_OfficePhoneNumberNA.CheckedChanged += new System.EventHandler(this.checkBox_OfficePhoneNumberNA_CheckedChanged);
            // 
            // maskedTextBox_OfficePhoneNumberRight
            // 
            this.maskedTextBox_OfficePhoneNumberRight.Location = new System.Drawing.Point(395, 54);
            this.maskedTextBox_OfficePhoneNumberRight.Mask = "000-0000";
            this.maskedTextBox_OfficePhoneNumberRight.Name = "maskedTextBox_OfficePhoneNumberRight";
            this.maskedTextBox_OfficePhoneNumberRight.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox_OfficePhoneNumberRight.TabIndex = 2;
            // 
            // AddProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(669, 269);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProfessor";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_MsuIDRight;
        private System.Windows.Forms.TextBox textBox_LastNameRight;
        private System.Windows.Forms.TextBox textBox_FirstNameRight;
        private System.Windows.Forms.Label label_MsuIDLeft;
        private System.Windows.Forms.Label label_LastNameLeft;
        private System.Windows.Forms.Label label_FirstNameLeft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CellPhoneNumberRight;
        private System.Windows.Forms.TextBox textBox_OfficeRoomNumberRight;
        private System.Windows.Forms.Label label_CellPhoneNumberLeft;
        private System.Windows.Forms.Label label_OfficePhoneNumberLeft;
        private System.Windows.Forms.Label label_OfficeRoomNumberLeft;
        private System.Windows.Forms.CheckBox checkBox_OfficePhoneNumberNA;
        private System.Windows.Forms.CheckBox checkBox_CellPhoneNumberNA;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_OfficePhoneNumberRight;
    }
}