﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    internal class AccountState
    {

        public enum State_type { 
            Active  = 0,
            Frozem = 1,
            Closed= 2
        }

         /*protected AccountState (bool Active, string name) => (Id, Name) = (id, name);

            public override string ToString() => state;

            public int CompareTo(object other) => Id.CompareTo(((AccountState)other).state);

            // Other utility methods ... */
        
    }
}