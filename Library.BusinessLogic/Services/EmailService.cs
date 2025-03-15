using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Configuration;


namespace Library.BusinessLogic.Services
{
    public class EmailService
    {

        public void SendDuedateReminder(string toEmail, string bookTitle, DateTime dueDate)
        {

            try
            {
                string emailAddress = ConfigurationManager.AppSettings["EmailAddress"];
                string emailPassword = ConfigurationManager.AppSettings["EmailPassword"];

                TimeSpan timeLeft = dueDate - DateTime.Now.Date;
                if (timeLeft.Days == 1)
                {
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(emailAddress, "Library Reminder Service"),
                        Subject = "Reminder: Book Due Date",
                        Body = $@"
                        <h2>📚 Reminder: Book Due Date</h2>
                        <p>Dear reader,</p>
                        <p>This is a friendly reminder that your book <strong>'{bookTitle}'</strong> is due on <strong>{dueDate:dddd, MMMM dd, yyyy}</strong>.</p>
                        <p>Please ensure to return it on time to avoid any penalties.</p>
                        <br/>
                        <p>Happy reading!<br/>📘 <em>Your Library Team</em></p>",
                        IsBodyHtml = true

                    };

                    mail.To.Add(toEmail);

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(emailAddress, emailPassword),
                        EnableSsl = true
                    };

                    int retries = 3;
                    int delay = 2000;
                    while (retries > 0)
                    {
                        try
                        {
                            smtp.Send(mail);
                            Console.WriteLine("Email sent successfully!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            retries--;
                            Console.WriteLine($"Failed to send email. Retries left: {retries}. Error: {ex.Message}");
                            Thread.Sleep(delay);
                            delay *= 2;
                            if (retries == 0) Console.WriteLine("All retries failed.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email: {ex.Message}");
            }
        }
    }
}