using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Book_Item : Book
    {
        private string barCode { get; set; }
        private int tag { get; set; }

        private bool isReferenceOnly { get; set; }  

        public Catalog Catalog { get; set; }
    }
}
