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
    public partial class Sedan : Form
    {
        public static Form10 Instance21;
        public static HondaAccord Instance43;
        public static VolkswagenJetta Instance42;
        public static ChevroletMalibu Instance41;
        public static Chrysler300 Instance40;
        public static Sedan Instance30;
        public Sedan()
        {
            InitializeComponent();
            Instance30 = this;
        }

        private void Sedan_Load(object sender, EventArgs e)
        {
            
        }

        private void butChrysler300_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance40 = new Chrysler300();
            Instance40.Show();
        }

        private void butChevroletmalibu_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance41 = new ChevroletMalibu();
            Instance41.Show();
        }

        private void butVolkswagenjetta_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance42 = new VolkswagenJetta();
            Instance42.Show();
        }

        private void butHondaaccord_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance43 = new HondaAccord();
            Instance43.Show();
        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void butclosedash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance21 = new Form10();
            Instance21.Show();
        }
    }
}
