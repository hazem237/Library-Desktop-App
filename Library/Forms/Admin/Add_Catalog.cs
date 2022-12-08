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
                comboBox1.Items.Add(a.Library_ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalog c = new Catalog();
            c.Catalog_Name = textBox1.Text;
            int key = Convert.ToInt32(comboBox1.SelectedItem);
            // var a = ctx.Libraries.Where(x => x.Name == key).Single();
            // c.library = a;
            // c.library_ID = key;
            c.libraryID = key;


            ctx.Catalogs.Add(c);
            ctx.SaveChanges();

            //Catalogs_Operation c2 = new Catalogs_Operation();
           // c2.Add_Catalog(c);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
