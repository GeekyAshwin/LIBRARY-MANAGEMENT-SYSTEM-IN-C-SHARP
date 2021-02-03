using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            String sno= textBox1.Text.ToString();
            String book_Name= textBox2.Text.ToString();
            String publisher_Name = textBox3.Text.ToString();
            String quantity = textBox4.Text.ToString();
            int issued = 0;


            SqlConnection sqlConnection = Conn.open_Connection();
            String query = "INSERT INTO BOOKS(SNO,NAME,PUBLISHER,QUANTITY) VALUES('"+sno+"','"+book_Name+"','"+publisher_Name+"','"+quantity+"') ";
            String query2 = "UPDATE BOOKS SET AVAILABLE='"+quantity+"',ISSUED='"+issued+"'  WHERE SNO='"+sno+"'   ";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
                SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);

                /* Dislaying MessageBox*/

                String title = "AddBook";
                String message = "Do You want to add the book in Database ? ";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show(message,title,messageBoxButtons);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("Book inserted successfuly...");

                }
                    
                
                    


            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibrarianSection().Show();
        }
    }
}
