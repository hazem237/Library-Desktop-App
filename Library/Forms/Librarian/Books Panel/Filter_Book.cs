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
    public partial class Filter_Book : Form
    {
        Classes.LibraryContext ctx = new Classes.LibraryContext();
        public Filter_Book()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Book_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Operation_Classes.Book_operations b = new Classes.Operation_Classes.Book_operations();
            richTextBox1.Text= b.Search_Book(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var b = ctx.BookItems.Max(x => x.Number_of_pages);
            var b2 = ctx.BookItems.First(x => x.Number_of_pages == b);
            richTextBox2.Text = b2.Title;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r = ctx.BookItems.Where(x => x.Language == "French").ToList();
            string a="";
            foreach (var book in r)
            {
                a = a + book.Title + '\n';
            }
            richTextBox3.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var b = ctx.BookItems.Min(x => x.Number_of_pages);
            var b2 = ctx.BookItems.First(x => x.Number_of_pages == b);
            richTextBox4.Text = b2.Title;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //var a = ctx.BookItems.Last();
           // richTextBox6.Text = a.Title;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Books = ctx.BookAuthors.Where(x => x.ISBN == Convert.ToInt32(textBox2.Text)).ToList();
            string s = "";
            foreach (var a in Books)
            {
                s = s + ctx.Authors.Where(x => x.Author_ID == a.Author_Id).Single().Authour_Name + '\n';
            }
            richTextBox5.Text = s;
        }
    }
}
