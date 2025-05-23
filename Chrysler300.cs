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
    public partial class Chrysler300 : Form
    {
        public static PManagement Instance85;
        public static Sedan Instance30;
        public static Chrysler300 Instance40;
        public Chrysler300()
        {
            InitializeComponent();
            Instance40 = this;
        }

        private void Chrysler300_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.paymentDatabaseDataSet.Customers);

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

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paymentDatabaseDataSet);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance85 = new PManagement();
            Instance85.Show();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paymentDatabaseDataSet);
        }
    }
}
