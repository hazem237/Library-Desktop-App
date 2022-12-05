using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Operation_Classes
{
    public class Librarin_Operation
    {
        LibraryContext Librarin_ctx = new LibraryContext();
        public void Add_Librarian(Librarian l)
        {
            Librarin_ctx.Librarians.Add(l);
            Librarin_ctx.SaveChanges();
        }
    }
}
