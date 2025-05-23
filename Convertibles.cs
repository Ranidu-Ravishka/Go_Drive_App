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
    public partial class Convertibles : Form
    {
        public static Form10 Instance21;
        public static Seriesconvertible4 Instance63;
        public static CLEcabirolet Instance62;
        public static MercedesAMGSL Instance61;
        public static MazdaMX5 Instance60;
        public static Convertibles Instance32;
        public Convertibles()
        {
            InitializeComponent();
            Instance32 = this;
        }

        private void Convertibles_Load(object sender, EventArgs e)
        {

        }

        private void butMazdamx5_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance60 = new MazdaMX5();
            Instance60.Show();
        }

        private void butMercedesamgsl_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance61 = new MercedesAMGSL();
            Instance61.Show();
        }

        private void butClecabirolet_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance62 = new CLEcabirolet();
            Instance62.Show();
        }

        private void but4Seriesconvertible_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance63 = new Seriesconvertible4();
            Instance63.Show();
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
