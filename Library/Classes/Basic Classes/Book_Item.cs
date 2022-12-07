using Library.Classes.Basic_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Book_Item:Book
    {
        public string BarCode { get; set; }
        public int Tag { get; set; }

        public bool IsReferenceOnly { get; set; }  

        public int Catalog_ID { get; set; }
        public Catalog Catalog { get; set; }

        public int library_ID { get; set; }
        public Library_Class Library { get; set; }

        public int Account_ID { get; set; }
        public Account Account { get; set; }

        public int librarian_ID { get; set; }
        public Librarian Librarian { get; set; }
    }
}
