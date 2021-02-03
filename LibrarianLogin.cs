
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
    public partial class LibrarianLogin : Form
    {
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        private void LibrarianLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.ToString();
            String password = textBox2.Text.ToString();

            SqlConnection sqlConnection = Conn.open_Connection();
            String query = "SELECT COUNT(*) FROM LIBRARIANS_INFO WHERE NAME='"+name+"' and PASS_WORD='"+password+"'  ";

            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

            if (sqlCommand.ExecuteScalar().ToString() == "1")
            {
                this.Hide();
                new LibrarianSection().Show();
            }
            else
            {
                MessageBox.Show("Denied");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainActivity().Show();
        }
    }
}
