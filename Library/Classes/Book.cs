using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public abstract class Book 
    {
        private string ISBN { get; set; }
        private string title { get; set; }
        private string summary { get; set; }
        private string publisher { get; set; }
        private string publication_data { get; set; }
        private int number_of_pages { get; set; }
        private string language { get; set; }


    }
}
