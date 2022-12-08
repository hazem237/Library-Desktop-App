using Library.Classes.Basic_Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class LibraryContext : DbContext
    {

        public DbSet<Book_Item> BookItems { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Library_Class> Libraries { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
       public DbSet<Account> Accounts { get; set; }
        public DbSet <Patron> Patrons { get; set;  }
        public DbSet<Book> Books { get; set; }
         public DbSet<Author> Authors { get; set; }
         public DbSet<BookAuthor> BookAuthors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>()
                .HasKey(bc => new { bc.ISBN, bc.Author_Id });
            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(bc => bc.ISBN);
            modelBuilder.Entity<BookAuthor>()
                .HasOne(bc => bc.Author)
                .WithMany(c => c.BookAuthors)
                .HasForeignKey(bc => bc.Author_Id);

            modelBuilder.Entity<Account>()
            .HasOne(a => a.Patron)
            .WithOne(a => a.Account)
            .HasForeignKey<Patron>(c => c.Accountnumber);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9VUPGQP;Database=LibraryDB; Integrated Security=True;");
        }
        
    }
}
