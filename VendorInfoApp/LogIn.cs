using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "BlakeGamber" && txtPasswords.Text == "Password")
            {
                new VendorInfo().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
                txtPasswords.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPasswords.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
    }
}
