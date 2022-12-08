﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms.Librarian;
using Library.Forms.Librarian.Patron_Panel;

namespace Library.Forms.Librarian
{
    public partial class Librarian_Panel : Form
    {
        public Librarian_Panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Panel b = new Book_Panel();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patron_panel p = new Patron_panel();
            p.ShowDialog();
        }
    }
}
