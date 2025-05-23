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
    public partial class Mazdacx90 : Form
    {
        public static PManagement Instance85;
        public static SUV Instance31;
        public static Mazdacx90 Instance50;
        public Mazdacx90()
        {
            InitializeComponent();
            Instance50 = this;
        }

        private void Mazdacx90_Load(object sender, EventArgs e)
        {

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
            Instance31 = new SUV();
            Instance31.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance85 = new PManagement();
            Instance85.Show();
        }
    }
}
