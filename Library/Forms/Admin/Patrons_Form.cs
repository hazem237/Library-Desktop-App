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
    public partial class Patrons_Form : Form
    {
        public Patrons_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Patron patron = new Classes.Patron();
            patron.Name = textBox1.Text;
            patron.Address = textBox2.Text;
            Patron_Operation p = new Patron_Operation();
            p.Add_Patron(patron);
        }
    }
}
