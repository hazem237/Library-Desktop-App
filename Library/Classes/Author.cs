﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public int Author_ID { get; set; }
        public string Authour_Name { get; set; }
        public string Author_biography { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
