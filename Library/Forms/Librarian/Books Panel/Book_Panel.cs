﻿using Library.Forms.Librarian.Books_Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.Librarian
{
    public partial class Book_Panel : Form
    {
        public Book_Panel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_Author a = new Add_Author();
            a.ShowDialog();
        }
    }
}
