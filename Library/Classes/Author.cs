using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Classes
{
    public class Author
    {
        [Key]
        public int Author_ID { get; set; }
        public string Authour_Name { get; set; }
        public string Author_biography { get; set; }

       public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
