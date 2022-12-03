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

        public Catalog Catalog { get; set; }
        public Library Library { get; set; }
        public Account Account { get; set; }
    }
}
