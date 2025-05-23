using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoDrive__Guna_
{
    public partial class CustomerCarePage : Form
    {
        public static Form2 Instance2;
        public static CustomerCarePage Instance5;
        public CustomerCarePage()
        {
            InitializeComponent();
            Instance5 = this;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.FromArgb(113, 90, 206);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_MouseLeave(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2CustomGradientPanel)sender).ShadowDecoration.Color = Color.FromArgb(60, 74, 94);
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance2 = new Form2();
            Instance2.Show();
        }

        private void butclosedash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CirclePictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void butsend_Click(object sender, EventArgs e)
        {
           lbltext.Text = txttext.Text;
        }
    }
}
