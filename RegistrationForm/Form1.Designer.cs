namespace RegistrationForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.femaleradioButton);
            this.groupBox1.Controls.Add(this.maleradioButton);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cpasswordtextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usernametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(51, 414);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(180, 17);
            this.checkBox.TabIndex = 17;
            this.checkBox.Text = "I agree all the term and condition";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBox.Location = new System.Drawing.Point(192, 364);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(174, 21);
            this.comboBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Group";
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Location = new System.Drawing.Point(292, 310);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleradioButton.TabIndex = 14;
            this.femaleradioButton.TabStop = true;
            this.femaleradioButton.Text = "Female";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Location = new System.Drawing.Point(214, 310);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(48, 17);
            this.maleradioButton.TabIndex = 13;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(45, 311);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(59, 16);
            this.gender.TabIndex = 12;
            this.gender.Text = "Gender";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(192, 255);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(192, 205);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(175, 20);
            this.emailtextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // cpasswordtextBox
            // 
            this.cpasswordtextBox.Location = new System.Drawing.Point(192, 157);
            this.cpasswordtextBox.Name = "cpasswordtextBox";
            this.cpasswordtextBox.PasswordChar = '*';
            this.cpasswordtextBox.Size = new System.Drawing.Size(175, 20);
            this.cpasswordtextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(192, 117);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(175, 20);
            this.passwordtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(192, 77);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(175, 20);
            this.usernametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "User name";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(192, 37);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(175, 20);
            this.nametextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::RegistrationForm.Properties.Resources.BOOK_COVER;
            this.ClientSize = new System.Drawing.Size(445, 535);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton femaleradioButton;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpasswordtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
    }
}

