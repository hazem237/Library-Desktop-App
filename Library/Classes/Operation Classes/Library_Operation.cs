using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Operation_Classes
{
    public class Library_Operation
    {
        LibraryContext Library_ctx = new LibraryContext();
        public void Add_Library(Library l)
        {
            Library_ctx.Libraries.Add(l);
            Library_ctx.SaveChanges();
        }
    }
}
