using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AdminSection : Form
    {
        public AdminSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddLibrarian().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewLibrarian().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DeleteLibrarian().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainActivity().Show();
        }
    }
}
