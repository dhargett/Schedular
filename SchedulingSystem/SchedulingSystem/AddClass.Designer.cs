namespace SchedulingSystem
{
    partial class AddClass
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ClassTitle = new System.Windows.Forms.TextBox();
            this.textBox_ClassNumber = new System.Windows.Forms.TextBox();
            this.numericUpDown_Sections = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sections)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sections:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(78, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Class #:";
            // 
            // textBox_ClassTitle
            // 
            this.textBox_ClassTitle.Location = new System.Drawing.Point(140, 50);
            this.textBox_ClassTitle.Name = "textBox_ClassTitle";
            this.textBox_ClassTitle.Size = new System.Drawing.Size(266, 20);
            this.textBox_ClassTitle.TabIndex = 6;
            // 
            // textBox_ClassNumber
            // 
            this.textBox_ClassNumber.Location = new System.Drawing.Point(139, 102);
            this.textBox_ClassNumber.Name = "textBox_ClassNumber";
            this.textBox_ClassNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClassNumber.TabIndex = 6;
            // 
            // numericUpDown_Sections
            // 
            this.numericUpDown_Sections.Location = new System.Drawing.Point(140, 128);
            this.numericUpDown_Sections.Name = "numericUpDown_Sections";
            this.numericUpDown_Sections.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_Sections.TabIndex = 3;
            this.numericUpDown_Sections.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Items.AddRange(new object[] {
            "MATH",
            "CS",
            "PHYS",
            "BIO",
            "CHEM"});
            this.comboBox_Subject.Location = new System.Drawing.Point(139, 75);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(101, 21);
            this.comboBox_Subject.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(453, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_Sections);
            this.Controls.Add(this.textBox_ClassNumber);
            this.Controls.Add(this.comboBox_Subject);
            this.Controls.Add(this.textBox_ClassTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClass";
            this.Text = "Eagle Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ClassTitle;
        private System.Windows.Forms.TextBox textBox_ClassNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sections;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Button button1;

    }
}