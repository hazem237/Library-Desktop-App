using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Operation_Classes
{
    public class Catalogs_Operation
    {
        LibraryContext Catalog_ctx = new LibraryContext();
        public void Add_Catalog(Catalog c)
        {
            Catalog_ctx.Catalogs.Add(c);
            Catalog_ctx.SaveChanges();
        }
    }
}
