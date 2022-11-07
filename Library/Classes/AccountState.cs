using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    internal class AccountState
    {
       
            public bool Active { get; private set; }

        public bool Frozen { get; private set; }
        public bool Frozen { get; private set; }


        protected AccountState (int id, string name) => (Id, Name) = (id, name);

            public override string ToString() => Name;

            public int CompareTo(object other) => Id.CompareTo(((AccountState)other).Id);

            // Other utility methods ...
        
    }
}
