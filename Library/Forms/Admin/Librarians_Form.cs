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

namespace Library.Forms.Admin
{
    public partial class Librarians_Form : Form
    {
        public Librarians_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Librarian l = new Classes.Librarian();
            l.Email = textBox2.Text;
            l.Password = textBox7.Text;
            l.Name = textBox6.Text;
            l.Address = textBox4.Text;
            l.Position = textBox5.Text;
            Librarin_Operation l2 = new Librarin_Operation();
            l2.Add_Librarian(l);
        }
    }
}
