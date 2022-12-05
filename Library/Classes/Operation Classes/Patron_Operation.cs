using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Operation_Classes
{
    public class Patron_Operation
    {
        LibraryContext Patron_ctx = new LibraryContext();
        public void Add_Patron(Patron p)
        {
            //Patron_ctx.patrons.add(p);
        }
    }
}
