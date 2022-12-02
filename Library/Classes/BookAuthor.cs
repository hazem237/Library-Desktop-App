using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class BookAuthor
    {
        public int ISBN { get; set; }
        public Book Book { get; set; }
        public int Author_Id { get; set; }
        public Author Author { get; set; }
    }
}
