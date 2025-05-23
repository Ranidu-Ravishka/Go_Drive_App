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
    public partial class MazdaMX5 : Form
    {
        public static PManagement Instance85;
        public static Convertibles Instance32;
        public static MazdaMX5 Instance60;
        public MazdaMX5()
        {
            InitializeComponent();
            Instance60 = this;
        }

        private void MazdaMX5_Load(object sender, EventArgs e)
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
            Instance32 = new Convertibles();
            Instance32.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance85 = new PManagement();
            Instance85.Show();
        }
    }
}
