using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    internal class Account_State {
        private string state { get; set; }
        public Account_State(string state ) { this.state = state; }
    }


    internal class Account
    {
        private int Account_number { get; set; }
        private string History { get; set; }
        private Date opened { get; set; }
        private Account_State state { get; set;}
    }
}
