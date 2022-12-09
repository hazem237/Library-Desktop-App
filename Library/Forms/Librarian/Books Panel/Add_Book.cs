using Library.Classes;
using Library.Classes.Basic_Classes;
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
    public partial class Add_Book : Form
    {
        LibraryContext ctx = new LibraryContext();
        List<BookAuthor> AuthorsList = new List<BookAuthor>();
        public Add_Book()
        {
            InitializeComponent();
            foreach (Catalog g in ctx.Catalogs)
            {
                comboBox1.Items.Add(g.Catalog_Name);
            }
            foreach (Library_Class l in ctx.Libraries)

            {
                comboBox2.Items.Add(l.Name);
            }
            foreach (Account a in ctx.Accounts)
            {
                comboBox3.Items.Add(a.Account_number);
            }
            foreach (Classes.Librarian l in ctx.Librarians)
            {
                comboBox4.Items.Add(l.Name);
            }
            foreach (Classes.Author a in ctx.Authors)
            {
                comboBox5.Items.Add(a.Author_ID);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Book_Item book = new Classes.Book_Item();
            book.Title = textBox1.Text;
            book.Summary = textBox2.Text;
            book.Publisher = textBox3.Text;
            book.Publication_data = textBox4.Text;
            book.Number_of_pages = Convert.ToInt32(textBox5.Text);
            book.Language = textBox6.Text;
            book.BarCode = textBox7.Text;
            book.Tag = Convert.ToInt32(textBox8.Text);
            if (radioButton1.Checked)
            {
                book.IsReferenceOnly = true;
            }
            else
            {
                book.IsReferenceOnly = true;
            }
            book.CatalogID = ctx.Catalogs.Where(x => x.Catalog_Name == comboBox1.SelectedItem.ToString()).Single().CatalogID;
            book.libraryID = ctx.Libraries.Where(x => x.Name == comboBox2.SelectedItem.ToString()).Single().Library_ID;
            book.AccountID = null;
            book.librarianID = ctx.Librarians.Where(x => x.Name == comboBox4.SelectedItem.ToString()).Single().Librarian_ID;
            book.BookAuthors = AuthorsList;

            Book_operations bo = new Book_operations();
            bo.Add_Book_item(book);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var a = ctx.Authors.Where(x => x.Authour_Name == (comboBox4.SelectedItem.ToString())).Single();
            //  BookAuthor a2 = new BookAuthor() { ISBN = 1, Author_Id = 2 };
            //AuthorsList.Add(a2);
            var r = ctx.Authors.ToList();
            var v = ctx.BookItems.ToList();
            for (int i = 0; i < r.Count; i++)
            {
                if (r[i].Author_ID == Convert.ToInt32(comboBox5.SelectedItem))
                {
                    AuthorsList.Add(new BookAuthor() { Author_Id = r[i].Author_ID, ISBN = v.Count + 1 });
                }
            }

        }
    }
}
