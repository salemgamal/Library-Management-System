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
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BorrowRecord> BorrowRecords { get; set; }
        public virtual DbSet<LogAction> LogActions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            if (string.IsNullOrEmpty(con))
            {
                throw new Exception("Connection String is missing");
            }
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(con);
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=LAPTOP-D5LRBLH1\\DEV;Database=LibraryDB;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BorrowRecord>()
            //    .HasKey(br => new { br.BookId, br.MemberId });

            modelBuilder.Entity<Book>()
                .HasMany(b => b.BorrowRecords)
                .WithOne(br => br.Book)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.LogActions)
                .WithOne(br => br.Book)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.BorrowRecords)
                .WithOne(br => br.Member)
                .HasForeignKey(br => br.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.LogActions)
                .WithOne(br => br.Member)
                .HasForeignKey(br => br.MemberId)
                .OnDelete(DeleteBehavior.Restrict);

            //User name unique
            modelBuilder.Entity<User>()
            .HasIndex(u => u.UserName)
            .IsUnique();

            //User email unique
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();

            modelBuilder.Entity<LogAction>()
                .Property(l => l.Action)
                .HasConversion<string>();

            
            //Admin
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
            //Member
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        UserId = 2,
                        UserName = "ahmedMohamed",
                        Password = "member",
                        Role = UserRole.Member,
                        Name = "Ahmed",
                        Email = "ahmed@gmail.com",
                        Phone = "01026299485"
                    }
             );
            //Librarian
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        UserId = 3,
                        UserName = "malak",
                        Password = "librarian",
                        Role = UserRole.Librarian,
                        Name = "Malak",
                        Email = "malak@gmail.com",
                        Phone = "01553462979"
                    }
             );
        }
    }
}
