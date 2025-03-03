using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess.Models
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(con);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowRecord>()
                .HasKey(br => new { br.BookId, br.MemberId });

            modelBuilder.Entity<Book>()
                .HasMany(b => b.BorrowRecords)
                .WithOne(br => br.Book)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();

            modelBuilder.Entity<User>()
                .HasMany(u => u.BorrowRecords)
                .WithOne(br => br.Member)
                .HasForeignKey(br => br.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        UserId = 1,
                        UserName = "salemgamall",
                        Password = "admin",
                        Role = UserRole.Admin,
                        Name = "Salem",
                        Email = "salem.g.salem.m@gmail.com",
                        Phone = "01026299485"
                    }
             );
        }
    }
}
