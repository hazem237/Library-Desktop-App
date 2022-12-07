using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes.Basic_Classes;
using Library.Interfaces;

namespace Library.Classes
{
    public class Catalog { 
        public int  CatalogID { get; set; }
        public string Catalog_Name { get; set; }
        public List <Book_Item> Book_Items { get; set; }
        public int library_ID { get; set; }
    }
}
