using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //simulate the admin entry 
            if (username_tb.Text == "admin" && password_tb.Text == "admin123")
            {
                AdminHome adminHome = new AdminHome();
                adminHome.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Username or Password not correct");
            }
        }
    }
}
