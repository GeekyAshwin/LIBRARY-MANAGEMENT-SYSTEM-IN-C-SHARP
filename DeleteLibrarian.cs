using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class DeleteLibrarian : Form
    {
        public DeleteLibrarian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text.ToString();
            SqlConnection sqlConnection = null;
            String query = "DELETE LIBRARIANS_INFO WHERE ID='"+id+"'";

            try
            {
                sqlConnection = Conn.open_Connection();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Librarian "+id+" DeletedSuccessfuly");
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminSection().Show();
        }
    }
}
