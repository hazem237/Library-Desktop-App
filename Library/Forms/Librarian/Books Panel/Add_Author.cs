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
    public partial class Add_Author : Form
    {
        public Add_Author()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Author a = new Classes.Author();
            a.Authour_Name = textBox1.Text;
            a.Author_biography = textBox2.Text;
            Classes.LibraryContext ctx =  new Classes.LibraryContext ();
            ctx.Authors.Add(a);
            ctx.SaveChanges();

        }
    }
}
