using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public abstract class Book 
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Publisher { get; set; }
        public string Publication_data { get; set; }
        public int Number_of_pages { get; set; }
        public string Language { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

    }
}
