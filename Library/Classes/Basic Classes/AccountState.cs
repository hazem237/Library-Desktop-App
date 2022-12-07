using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class AccountState
    {
        [Key]
       public int State_ID { get; set; }
        public enum State_type { 
            Active  = 0,
            Frozem = 1,
            Closed= 2
        }
        
    }
}
