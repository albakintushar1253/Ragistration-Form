using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {

        public TextBox NAME
        {
            get { return this.nametextBox; }
        }

        public TextBox UserName
        {
            get { return this.usernametextBox; }
        }

        public TextBox Password
        {
            get { return this.passwordtextBox; }
        }
        public TextBox ConfirmPasword
        {
            get { return this.cpasswordtextBox; }
        }

        public TextBox Email
        {
            get { return this.emailtextBox; }
        }

        public DateTimePicker DOB 
        {
            get { return this.dateTimePicker; }
        }

        public Label Gender
        {
            get { return this.gender; }
        }

        public RadioButton Male
        {
            get { return this.maleradioButton; }
        }

        public RadioButton Female
        {
            get { return this.femaleradioButton; }
        }

        public ComboBox BloodGroup
        {
            get { return this.comboBox; }
        }

        public CheckBox Check
        {
            get { return this.checkBox; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 inf = new Form2(this);

            inf.Show();
            this.Hide();

        }
    }
}
