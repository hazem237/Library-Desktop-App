using Library.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Catalog ad = new Add_Catalog();
            ad.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Library ad = new Add_Library();
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Librarians_Form librarians_Form = new Librarians_Form();
            librarians_Form.ShowDialog();
        }
    }
}
