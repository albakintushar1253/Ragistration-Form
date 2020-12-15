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
    public partial class Form2 : Form
    {

        Form1 f;
        public Form2(Form1 f)
        {
            this.f = f;
            InitializeComponent();
            label1.Text += f.NAME.Text;
            label2.Text += f.UserName.Text;
            label3.Text += f.Password.Text;
            label4.Text += f.ConfirmPasword.Text;
            label5.Text += f.Email.Text;
            label6.Text += f.DOB.Text;
           // label7.Text += f.Male.Text;
           // label7.Text += f.Female.Text;

            label8.Text += f.BloodGroup.Text;

            label9.Text += f.Password.Text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }
    }
}
