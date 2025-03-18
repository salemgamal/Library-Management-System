using System;
using System.Linq;
using Library.BusinessLogic.Services;
using Library.DataAccess;
using Library.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        try
        {
            using (var db = new LibraryDbContext())
            {
                var today = DateTime.Now.Date;
                var tomorrow = today.AddDays(1);

                var dueBooks = db.BorrowRecords
                       .Where(b => b.DueDate.Date == tomorrow || b.DueDate.Date <= DateTime.Now.Date)
                       .Select(b => new
                       {
                           UserEmail = b.Member.Email,
                           BookTitle = b.Book.Title,
                           DueDate = b.DueDate
                       })
                       .ToList();

                if (!dueBooks.Any())
                {
                    Console.WriteLine("No reminders to send today.");
                    return;
                }

                EmailService emailService = new EmailService();

                foreach (var borrow in dueBooks)
                {
                    var timePass = DateTime.Now.Date - borrow.DueDate;
                    emailService.SendDuedateReminder(borrow.UserEmail, borrow.BookTitle, borrow.DueDate,timePass);
                    Console.WriteLine($"Reminder sent to {borrow.UserEmail} for book '{borrow.BookTitle}'");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
