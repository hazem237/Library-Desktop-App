using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Classes;
using Library.Classes.Basic_Classes;
using Library.Classes.Operation_Classes;

namespace Library.Forms.Admin
{
    public partial class Add_Library : Form
    {
        
        public Add_Library()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Library_Class ll =new Library_Class();
            ll.Name = textBox1.Text;
            ll.Address = textBox2.Text;
            Library_Operation l2 = new Library_Operation();
            l2.Add_Library(ll);
        }
    }
}
