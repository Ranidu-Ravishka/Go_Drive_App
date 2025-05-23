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
    public partial class Form2 : Form
    {
        public static PManagement Instance85;
        public static HomePage Instance1;
        public static Ratings Instance24;
        public static Admin Instance23;
        public static Form10 Instance21;
        public static ClientManagement Instance20;
        public static CustomerCarePage Instance5;
        public static SettingsPage Instance4;
        public static MapPage Instance3;
        public static Form2 Instance2;
        public Label lbl1;
        public Form2()
        {
            InitializeComponent();
            Instance2 = this;
            lbl1 = lbldisplayUsername;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbldisplayUsername_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance5 = new CustomerCarePage(); 
            Instance5.Show();
        }

        private void butcm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance20 = new ClientManagement();
            Instance20.Show();
        }

        private void butvm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance21 = new Form10();
            Instance21.Show();           
        }

        private void butpm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance85 = new PManagement();
            Instance85.Show();
        }

        private void butadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance23 = new Admin();
            Instance23.Show();
        }

        private void butlocation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Instance3 = new MapPage();
            Instance3.Show();   
        }

        private void butfeedbacks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance24 = new Ratings();
            Instance24.Show();
        }

        private void butsettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance4 = new SettingsPage();
            Instance4.Show();   
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance1 = new HomePage();
            Instance1.Show();
        }
    }
}
