﻿using System;
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
    public partial class Ratings : Form
    {
        public static Form2 Instance2;
        public static Ratings Instance24;
        public Ratings()
        {
            InitializeComponent();
            Instance24 = this;
        }

        private void Ratings_Load(object sender, EventArgs e)
        {

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

        private void butback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instance2 = new Form2();
            Instance2.Show();
        }
    }
}
