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
    public partial class Modify_Book : Form
    {
        Classes.LibraryContext ctx = new Classes.LibraryContext();
       // Classes.Book_Item item = 
        public Modify_Book()
        {
            InitializeComponent();
            foreach (var a in ctx.BookItems)
            {
                comboBox1.Items.Add(a.Title);
            }
            //textBox1.Text = ctx.BookItems.Where(x => x.Title == comboBox1.SelectedItem.ToString()).Single().Title;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Modify_Book_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = ctx.BookItems.Where(x => x.Title == comboBox1.SelectedItem).SingleOrDefault();
            if (radioButton1.Checked)
            {
                b.Title = textBox1.Text;
            }
            else if (radioButton2.Checked)
            {
                b.Summary = textBox1.Text;

            }
            else if (radioButton3.Checked)
            {
                b.Publisher = textBox1.Text;
            }
            else
            {
                b.Language = textBox1.Text;
            }
           
            ctx.SaveChanges();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
