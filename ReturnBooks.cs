using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String student_ID= textBox1.Text.ToString();
            String student_Name = textBox2.Text.ToString();
            String sno = comboBox1.Text;
            String book_Name= comboBox2.Text;

            SqlConnection sqlConnection = Conn.open_Connection();
            String query1 = "DELETE ISSUEDBOOKS WHERE STUDENT_ID='"+student_ID+"' AND SNO='"+sno+"' ";
            String query2 = "UPDATE BOOKS SET AVAILABLE=AVAILABLE+1,ISSUED=ISSUED-1  WHERE SNO='" + sno + "' ";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query1,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("Book returned Successfuly..");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibrarianSection().Show();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet7.ISSUEDBOOKS' table. You can move, or remove it, as needed.
            this.iSSUEDBOOKSTableAdapter2.Fill(this.lIB_MAN_SYSDataSet7.ISSUEDBOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet3.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.lIB_MAN_SYSDataSet3.BOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lIB_MAN_SYSDataSet2.BOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet6.ISSUEDBOOKS' table. You can move, or remove it, as needed.
            this.iSSUEDBOOKSTableAdapter1.Fill(this.lIB_MAN_SYSDataSet6.ISSUEDBOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet5.ISSUEDBOOKS' table. You can move, or remove it, as needed.
            this.iSSUEDBOOKSTableAdapter.Fill(this.lIB_MAN_SYSDataSet5.ISSUEDBOOKS);

        }

        
    }
}
