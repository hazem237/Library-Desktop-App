using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes.Operation_Classes
{
    public class Book_operations:Search
    {
        LibraryContext Book_ctx = new LibraryContext();
        public void Add_Book_item(Book_Item B)
        {
            Book_ctx.BookItems.Add(B);
            Book_ctx.SaveChanges();
        }
        public void Delete_Book_Item(Book_Item B)
        {
            Book_ctx.BookItems.Remove(B);
            Book_ctx.SaveChanges();
        }
        public void Modify_Book_Item(Book_Item B, string new_value, string key)
        {
            switch (key)
            {
                case "Title":
                    B.Title = new_value;
                    break;
                case "Summary":
                    B.Summary = new_value;
                    break;
                case "Publisher":
                    B.Publisher = new_value;
                    break;
                case "Publication_data":
                    B.Publication_data = new_value;
                    break;
                case "Number_of_pages":
                    B.Number_of_pages = Convert.ToInt32(new_value);
                    break;
                case "Language":
                    B.Language = new_value;
                    break;
                case "BarCode":
                    B.BarCode = new_value;
                    break;
                case "Tag":
                    B.Tag = Convert.ToInt32(new_value);
                    break;
                case "IsReferenceOnly":
                    B.IsReferenceOnly = Convert.ToBoolean(new_value);
                    break;
                    default: throw new ArgumentException();
            }
            Book_ctx.SaveChanges();
        }

        public string Search_Book(int ISBN)
        {
            string a = "Not Found";
            var book = Book_ctx.Books.Where(b => b.ISBN == ISBN).SingleOrDefault();
           if (book != null)
            {
                a= " Found ";
            }
            return a;
        }
    }
}
