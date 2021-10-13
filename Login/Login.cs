using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        protected string mailtxt;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new ResetPassword(mailtxt);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            ResetPassword fmr = new ResetPassword(mailtxt);
            fmr.ShowDialog();
        }

        private void kryptonLinkLabel2_LinkClicked(object sender, EventArgs e)
        {

        }
    }
}
