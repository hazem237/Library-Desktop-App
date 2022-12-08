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
            foreach (Patron p in ctx.Patrons)
            {
                comboBox3.Items.Add(p.Patron_ID);
            }
        }

        private void Add_Account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Account a = new Classes.Account();
            LibraryContext ctx = new LibraryContext();
            a.History = textBox1.Text;
            a.Date_opened = textBox2.Text;
            a.patronID = Convert.ToInt32(comboBox3.SelectedItem.ToString());
            string key = comboBox1.SelectedItem.ToString();
            var a2 = ctx.Libraries.Where(Library => Library.Name == key).Single();
            a.libraryID = a2.Library_ID;
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Frozen":
                    a.account_State = (Account_State)0;
                    break;
                case "Active":
                    a.account_State = (Account_State)1;
                    break;
                case "Closed":
                    a.account_State = (Account_State)2;
                    break;

            }
            ctx.Accounts.Add(a);
            ctx.SaveChanges();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
