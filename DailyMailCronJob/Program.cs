// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Method call at" + DateTime.Now);
MailMessage message = new MailMessage();
MailMessage mail = new SmtpClient("smtp.gmail.com");
SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

mail.From = new MailAddress("theofficialabdulali@gmail.com");
mail.To.Add("abdulghafurali9@gmail.com");
mail.Subject = "Test Mail";
mail.Body = "This is for testing of crone-job";

SmtpServer.Port = 587;
SmtpServer.Credentials = new System.Net.NetworkCredential("theofficialabdulali@gmail.com", "getoutofmyaccount");
SmtpServer.Send(mail);
Console.WriteLine("Mail sent at" + DateTime.Now);
Console.ReadLine();

