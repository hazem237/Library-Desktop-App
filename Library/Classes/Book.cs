using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Classes
{
    public abstract class Book 
    {
       [Key]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Publisher { get; set; }
        public string Publication_data { get; set; }
        public int Number_of_pages { get; set; }
        public string Language { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
