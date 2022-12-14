using Library.Forms;
using Library.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public string Email = "a";
        public string Password = "1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == Email && textBox3.Text == Password)
            {
                Admin_Form admin = new Admin_Form();
                admin.ShowDialog();
            }
            else
            {
                Classes.LibraryContext ctx = new Classes.LibraryContext();
                var a = ctx.Librarians.Where(a2 => a2.Email == textBox2.Text && a2.Password == textBox3.Text).Single();
                if (a != null)
                {
                    Librarian_Panel r = new Librarian_Panel();
                    r.ShowDialog();
                }
            }
        }
    }
}
