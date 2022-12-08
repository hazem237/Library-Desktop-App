using Library.Classes.Operation_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.Librarian.Books_Panel
{
    public partial class Delete_Book : Form
    {
        public Delete_Book()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Classes.LibraryContext ctx = new Classes.LibraryContext();
            var b = ctx.BookItems.Where(x => x.ISBN == Convert.ToInt32(textBox1.Text)).Single();
            var b2 = ctx.BookAuthors.Where(x => x.ISBN == Convert.ToInt32(textBox1.Text)).ToList();
            foreach (var t in b2)
            {
                ctx.BookAuthors.Remove(t);
            }
            ctx.BookItems.Remove(b);
            ctx.SaveChanges();

        }
    }
}
