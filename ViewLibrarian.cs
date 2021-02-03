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
    public partial class ViewLibrarian : Form
    {
        public ViewLibrarian()
        {
            InitializeComponent();
        }

        private void ViewLibrarian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIB_MAN_SYSDataSet1.LIBRARIANS_INFO' table. You can move, or remove it, as needed.
            this.lIBRARIANS_INFOTableAdapter.Fill(this.lIB_MAN_SYSDataSet1.LIBRARIANS_INFO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminSection().Show();
        }
    }
}
