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
    public partial class Form10 : Form
    {
        public static Form2 Instance2;
        public static Vans Instance33;
        public static Convertibles Instance32;
        public static SUV Instance31;
        public static Sedan Instance30;
        public static Form10 Instance21;
        public Form10()
        {
            InitializeComponent();
            Instance21 = this;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void butSedanVM_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance30 = new Sedan();
            Instance30.Show();
        }

        private void butSuvVM_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance31 = new SUV();
            Instance31.Show();
        }

        private void butConveribleVM_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance32 = new Convertibles();
            Instance32.Show();
        }

        private void butVansVM_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance33 = new Vans();
            Instance33.Show();
        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void butclosedash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance2 = new Form2();
            Instance2.Show();
        }
    }
}
