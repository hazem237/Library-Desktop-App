﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Classes
{
    public class Patron
    {
        [Key]
       public int Patron_ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        
      
        public  Account Account { get; set; }
    }
}
