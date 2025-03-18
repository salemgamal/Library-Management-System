using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;


namespace Library.BusinessLogic.Services
{
    public class EmailService
    {

        public void SendDuedateReminder(string toEmail, string bookTitle, DateTime dueDate ,TimeSpan timePass)
        {

            try
            {
                string emailAddress = ConfigurationManager.AppSettings["EmailAddress"];
                string emailPassword = ConfigurationManager.AppSettings["EmailPassword"];

                TimeSpan timeLeft = dueDate - DateTime.Now.Date;
                string emailBody = "";
                if (timeLeft.Days == 1)
                {
                    emailBody = $@"
                        <h2>📚 Reminder: Book Due Tomorrow!</h2>
                        <p>Dear reader,</p>
                        <p>Your book <strong>'{bookTitle}'</strong> is due <strong>tomorrow</strong> ({dueDate:dddd, MMMM dd, yyyy}).</p>
                        <p>Please return it on time to avoid any penalties.</p>
                        <br/>
                        <p>Happy reading!<br/>📘 <em>Your Library Team</em></p>";
                }else if (timePass.Days > 0)
                {
                    emailBody = $@"
                        <h2>📚 Overdue Reminder: Book Not Returned</h2>
                        <p>Dear reader,</p>
                        <p>Your book <strong>'{bookTitle}'</strong> was due <strong>{timePass.Days}</strong> day(s) ago on <strong>{dueDate:dddd, MMMM dd, yyyy}</strong>.</p>
                        <p>Please return it as soon as possible to avoid further penalties.</p>
                        <br/>
                        <p>Best regards,<br/>📘 <em>Your Library Team</em></p>";
                }
                if (timeLeft.Days == 1 || timePass.Days > 0)
                {
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(emailAddress, "Library Reminder Service"),
                        Subject = "Reminder: Book Due Date",
                        Body = emailBody,
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