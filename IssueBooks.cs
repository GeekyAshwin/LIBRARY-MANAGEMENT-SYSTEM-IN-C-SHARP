using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sno = comboBox1.Text.ToString();
            String book_Name = comboBox2.Text.ToString();
            String student_ID = textBox3.Text.ToString();
            String student_Name = textBox4.Text.ToString();
            String contact = textBox5.Text.ToString();
            String date_of_Issue = dateTimePicker1.Value.ToString();

            SqlConnection sqlConnection = Conn.open_Connection();
            String query1 = "INSERT INTO ISSUEDBOOKS VALUES('"+sno+ "','" + book_Name+ "','" + student_ID+ "','" + student_Name+ "','" + contact+ "','" + date_of_Issue+ "') ";
            String query2 = "UPDATE BOOKS SET AVAILABLE=AVAILABLE-1,ISSUED=ISSUED+1 WHERE SNO='"+sno+"'  ";
            try
            {
                SqlCommand sqlCommand1 = new SqlCommand(query1,sqlConnection);
                sqlCommand1.ExecuteNonQuery();
                SqlCommand sqlCommand2 = new SqlCommand(query2,sqlConnection);
                sqlCommand2.ExecuteNonQuery();
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            MessageBox.Show("Book Issued Successfuly..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibrarianSection().Show();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet3.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.lIB_MAN_SYSDataSet3.BOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lIB_MAN_SYSDataSet2.BOOKS);

        }
    }
}
