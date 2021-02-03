using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet3.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter1.Fill(this.lIB_MAN_SYSDataSet3.BOOKS);
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lIB_MAN_SYSDataSet2.BOOKS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LibrarianSection().Show();
        }
    }
}
