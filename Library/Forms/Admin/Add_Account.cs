using Library.Classes;
using Library.Classes.Basic_Classes;
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
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            LibraryContext ctx = new LibraryContext();
            InitializeComponent();
            foreach (Library_Class a in ctx.Libraries)
            {
                comboBox1.Items.Add(a.Name);
            }
        }

        private void Add_Account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
