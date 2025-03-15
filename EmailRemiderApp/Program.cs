using MailKit;
using System.Data.SqlClient;
using Library.BusinessLogic.Services;
using Library.DataAccess;
using Library.DataAccess.Models;
using Library.DataAccess.Repositry;
using Library.DataAccess.Repositories;

namespace EmailRemiderApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                BookRepository book = new BookRepository(context);
                BorrowRecordRepository b = new BorrowRecordRepository(context);
                LogActionRepositry log = new LogActionRepositry(context);
                BorrowRecordService bs = new BorrowRecordService(b,book,log);
                    var emailService = new EmailService();

                    var tomorrow = DateTime.Now.Date.AddDays(1);

                    var dueBooks = context.BorrowRecords      
                        .Where(b => b.DueDate.Date == tomorrow)
                        .Select(b => new
                        {
                            UserEmail = b.Member.Email,
                            BookTitle = b.Book.Title,
                            DueDate = b.DueDate
                        })
                        .ToList();

                if (dueBooks.Any())
                    {
                        foreach (var item in dueBooks)
                        {
                            emailService.SendDuedateReminder(item.UserEmail, item.BookTitle, item.DueDate);
                        }

                        Console.WriteLine("All reminders sent successfully!");
                    }
                    else
                    {
                        Console.WriteLine("No due books for tomorrow.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Email reminder app finished.");
        }
    }
}
