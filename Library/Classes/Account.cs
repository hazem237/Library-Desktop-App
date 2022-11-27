using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
 
    internal class Account
    {
        private int Account_number { get; set; }
        private string History { get; set; }
        private Date opened { get; set; }
        private AccountState state { get; set;}

        public Library Library { get; set; }
    }
}
