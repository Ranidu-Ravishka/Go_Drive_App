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
    public partial class VolkswagenJetta : Form
    {
        public static PManagement Instance85;
        public static Sedan Instance30;
        public static VolkswagenJetta Instance42;
        public VolkswagenJetta()
        {
            InitializeComponent();
            Instance42 = this;
        }

        private void VolkswagenJetta_Load(object sender, EventArgs e)
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
            Instance30 = new Sedan();
            Instance30.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance85 = new PManagement();
            Instance85.Show();
        }
    }
}
