using Microsoft.EntityFrameworkCore;

namespace ContactManager12876.Models
{
    //00012876
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category { CategoryId = 1, Name = "Friend" },
              new Category { CategoryId = 2, Name = "Work" },
              new Category { CategoryId = 3, Name = "Family" }
            );

            modelBuilder.Entity<Contact>().HasData(
              new Contact
                  {
                     ContactId = 1,
                     FirstName = "Adam",
                     LastName = "Azizov",
                     PhoneNumber = "93534323",
                     Email = "12876@gmail.com",
                     CategoryId = 1,
                     },
              new Contact
              {
                  ContactId = 2,
                  FirstName = "Aziz",
                  LastName = "Sengaev",
                  PhoneNumber = "96342342423",
                  Email = "2342@gmail.com",
                  CategoryId = 1,
              },
              new Contact
              {
                  ContactId = 3,
                  FirstName = "Oleg",
                  LastName = "Danarov",
                  PhoneNumber = "7122323424",
                  Email = "gsgsg@gmail.com",
                  CategoryId = 2,
              }
         );
        }
    }   
   
}
