using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddLibrarian : Form
    {
        public AddLibrarian()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String id=textBox1.Text.ToString();
            String name=textBox2.Text.ToString();
            String password=textBox3.Text.ToString();
            String gender=null;
            String email= textBox4.Text.ToString();
            String contact= textBox5.Text.ToString();

            if (radioButton1.Checked)
                gender = "Male";
            else
                gender = "Female";

            SqlConnection sqlConnection = null;
            String query = "INSERT INTO LIBRARIANS_INFO VALUES('"+id+ "','" + name + "','" + password+ "','" + gender+ "','" + email + "','" + contact+ "')";
            
            try
            {
                sqlConnection = Conn.open_Connection();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Librarian Inserted Successfuly");
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
