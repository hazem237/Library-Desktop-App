using Library.Forms.Librarian.Books_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.Librarian
{
    public partial class Book_Panel : Form
    {
        public Book_Panel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Author a = new Add_Author();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_Book d = new Delete_Book();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filter_Book f = new Filter_Book();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modify_Book m = new Modify_Book();
            m.ShowDialog();
        }
    }
}
