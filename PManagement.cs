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
    public partial class PManagement : Form
    {
        public static Form2 Instance2;
        public static PManagement Instance85;
        public PManagement()
        {
            InitializeComponent();
            Instance85 = this;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paymentDatabaseDataSet);

        }

        private void PManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.paymentDatabaseDataSet.Customers);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paymentDatabaseDataSet);
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance2 = new Form2();
            Instance2.Show();
        }

        private void butclosedash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butminimizedash_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
