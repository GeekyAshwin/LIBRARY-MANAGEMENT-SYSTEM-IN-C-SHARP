using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {             
            String username = textBox1.Text.ToString();
            String password = textBox2.Text.ToString();
            if (username=="ASHWIN RAWAT"&&password=="12345678")
            {
                this.Hide();
                new AdminSection().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainActivity().Show();
        }
    }
}
