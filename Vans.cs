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
    public partial class Vans : Form
    {
        public static Form10 Instance21;
        public static Vitolongtourer Instance71;
        public static Classev Instance70;
        public static Vans Instance33;
        public Vans()
        {
            InitializeComponent();
            Instance33 = this;
        }

        private void Vans_Load(object sender, EventArgs e)
        {

        }

        private void butClassev_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance70 = new Classev();
            Instance70.Show();
        }

        private void butVitolongtourer_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance71 = new Vitolongtourer();
            Instance71.Show();
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
            Instance21 = new Form10();
            Instance21.Show();
        }
    }
}
