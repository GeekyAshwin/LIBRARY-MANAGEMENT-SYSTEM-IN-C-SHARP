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
    public partial class LibrarianSection : Form
    {
        public LibrarianSection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //isuue book
        {
            this.Hide();
            new IssueBooks().Show();
        }

        private void button6_Click(object sender, EventArgs e) // viewissued books
        {
            this.Hide();
            new ViewIssuedBooks().Show();
        }

        private void button1_Click(object sender, EventArgs e) //addbook btn
        {
            this.Hide();
            new AddBooks().Show();
        }

        private void button2_Click(object sender, EventArgs e) //viewbook btn
        {
            this.Hide();
            new ViewBooks().Show();
        }

        private void button4_Click(object sender, EventArgs e) //return book
        {
            this.Hide();
            new ReturnBooks().Show();
        }

        private void button5_Click(object sender, EventArgs e) //logout btn
        {
            this.Hide();
            new MainActivity().Show();
        }
    }
}
