using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
 
    public class Account
    {
        [Key]
        public int Account_number { get; set; }
        public string History { get; set; }
        public string Date_opened { get; set; }
       // public AccountState state { get; set;}

        public Library Library { get; set; }

        public Patron Patron { get; set; }
    }
}
