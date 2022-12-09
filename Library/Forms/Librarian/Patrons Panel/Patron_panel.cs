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
    }
}
