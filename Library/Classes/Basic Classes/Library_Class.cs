using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Basic_Classes
{
    public class Library_Class
    {
        [Key]
        public int Library_ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Account> Accounts { get; set; }
        public List<Book_Item> Book_Items { get; set; }

        public List<Catalog> Catalogs { get; set; }


    }
}
