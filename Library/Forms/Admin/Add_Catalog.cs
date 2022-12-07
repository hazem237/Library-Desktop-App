using Library.Classes;
using Library.Classes.Basic_Classes;
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
    public partial class Add_Catalog : Form
    {
        LibraryContext ctx =new LibraryContext();
        public Add_Catalog()
        {
            InitializeComponent();
            foreach (Library_Class a in ctx.Libraries)
            {
                comboBox1.Items.Add(a.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalog c = new Catalog();
            c.Catalog_Name = textBox1.Text;
            string key = comboBox1.SelectedItem.ToString();
            int a = ctx.Libraries.Where(x => x.Name == key).Single().Library_ID;
          
            Catalogs_Operation c2 = new Catalogs_Operation();
            c2.Add_Catalog(c);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
