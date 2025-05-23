using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace GoDrive__Guna_
{
    public partial class HomePage : Form
    {
        public static Form2 Instance2;
        public static HomePage Instance1;
        public HomePage()
        {
            InitializeComponent();
            Instance1 = this;
        }

        private void piclogologin_Click(object sender, EventArgs e)
        {

        }

        private void butlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {

                MessageBox.Show("Both Username and Password fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                //MessageBox.Show("Welcome", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Instance2 = new Form2();
                Instance2.Show();
                Instance2.lbl1.Text = txtusername.Text;
            }
        }

        private void butclosehome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butminimizehome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                txtpassword.PasswordChar = '*';
            }
            else
            {
                txtpassword.PasswordChar = '\0';
            }
        }
    }
    
}
