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
    public partial class SUV : Form
    {
        public static Form10 Instance21;
        public static Mazdacx70 Instance53;
        public static Sportback300 Instance52;
        public static NewDefender Instance51;
        public static Mazdacx90 Instance50;
        public static SUV Instance31;
        public SUV()
        {
            InitializeComponent();
            Instance31 = this;
        }

        private void SUV_Load(object sender, EventArgs e)
        {
           
        }

        private void butMazdacx_90_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance50 = new Mazdacx90();
            Instance50.Show();
        }

        private void butNewdefender_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance51 = new NewDefender(); 
            Instance51.Show();
        }

        private void butSportback300_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance52 = new Sportback300();  
            Instance52.Show();
        }

        private void butMazdacx70_Click(object sender, EventArgs e)
        {
            this.Close();
            Instance53 = new Mazdacx70();
            Instance53.Show();
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
