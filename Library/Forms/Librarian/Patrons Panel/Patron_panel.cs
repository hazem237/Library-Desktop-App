using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.Librarian.Patron_Panel
{
    public partial class Patron_panel : Form
    {
        Classes.LibraryContext ctx = new Classes.LibraryContext();
        public Patron_panel()
        {
            InitializeComponent();
        }

        private void Patron_panel_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = ctx.Accounts.Where(x => x.patronID == Convert.ToInt32(textBox1.Text)).Single();
            if (radioButton1.Checked)
            {
                a.History = textBox2.Text;
            }
            else if (radioButton2.Checked)
            {
                a.Date_opened = textBox2.Text;
            }
            else
            {
                switch (textBox2.Text)
                {
                    case "Frozen":
                        a.account_State = (Classes.Basic_Classes.Account_State)0;
                        break;
                    case "Active":
                        a.account_State = (Classes.Basic_Classes.Account_State)1;
                        break;
                    case "Closed":
                        a.account_State = (Classes.Basic_Classes.Account_State)2;
                        break;
                }
            }
            ctx.SaveChanges();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patrons = ctx.Patrons.ToList();
            string a = "";
            foreach (Classes.Patron a2 in patrons)
            {
                a = a + "Name : " +
                    a2.Name + " " +
                    "ID : " +
                    a2.Patron_ID + '\n';
            }
            richTextBox1.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frozen = ctx.Accounts.Where(x => x.account_State == 0).ToList();
            string a = "";
            foreach (var a2 in frozen)
            {
                a = a + ctx.Patrons.Where(p => p.Patron_ID == a2.patronID).Single().Name + '\n';
            }
            richTextBox2.Text=a;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var patron = ctx.Patrons.Where(x => x.Patron_ID == Convert.ToInt32(textBox3.Text)).SingleOrDefault();
            var acount = ctx.Accounts.Where(a => a.Account_number == Convert.ToInt32(textBox3.Text)).SingleOrDefault();
            var book = ctx.BookItems.Where(b => b.ISBN == Convert.ToInt32(textBox5.Text)).SingleOrDefault();
            book.AccountID = acount.Account_number;
            ctx.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var acount = ctx.Accounts.Where(a => a.Account_number == Convert.ToInt32(textBox4.
                Text)).SingleOrDefault();
            var patron = ctx.Patrons.Where(p => p.Patron_ID == acount.patronID).Single();
            richTextBox4.Text = "Patron Name : " + patron.Name;
            var Books = ctx.BookItems.Where(b => b.AccountID == acount.Account_number).ToList();
            string s = "";
            foreach (var b in Books)
            {
                s = s + b.Title + '\n';
            }
            richTextBox3.Text = s;

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var book = ctx.BookItems.Where(b => b.ISBN == Convert.ToInt32(textBox6.Text)).SingleOrDefault();
            var account = ctx.Accounts.Where(a => a.Account_number == book.AccountID).SingleOrDefault();
            var patron = ctx.Patrons.Where(p => p.Patron_ID == account.patronID).SingleOrDefault();
            if (book.AccountID !=null)
            {
               
                richTextBox5.Text = "The Book Reserved By Patron : " + patron.Name;
                richTextBox8.Text = "Book Name : " + book.Title;
                book.AccountID = null;
                ctx.SaveChanges();
            }
            else
            {
                richTextBox5.Text = "The Book is Un-Borrowerd ";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = "";
            var b = ctx.BookItems.Where(x => x.AccountID != null).ToList();
            foreach (var b2 in b)
            {
                a = a + b2.Title + " , ISBN : " + b2.ISBN + '\n';
            }
            richTextBox6.Text = a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "";
            var b = ctx.BookItems.Where(x => x.AccountID ==null).ToList();
            foreach (var b2 in b)
            {
                a = a + b2.Title + " , ISBN : " + b2.ISBN + '\n';
            }
            richTextBox7.Text = a;
        }
    }
}
