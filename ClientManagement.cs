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
    public partial class ClientManagement : Form
    {
        public static Form2 Instance2;
        public static ClientManagement Instance20;
        public ClientManagement()
        {
            InitializeComponent();
            Instance20 = this; 
        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientManagementDataSet.CMdatabase' table. You can move, or remove it, as needed.
            this.cMdatabaseTableAdapter.Fill(this.clientManagementDataSet.CMdatabase);

        }

        private void lbl1_Click(object sender, EventArgs e)
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

        private void cMdatabaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cMdatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientManagementDataSet);

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cMdatabaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientManagementDataSet);
        }

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance2 = new Form2();
            Instance2.Show();
        }
    }
}
