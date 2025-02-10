using System.Net;
using System.Net.Mail;
namespace ATM.ClassLibrary.Classes
{
    public class EmailNotification
    {
        private readonly string sender = "ipz233_goo@student.ztu.edu.ua";
        public EmailNotification(string recipient, string topic, string message)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(sender, "#####"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
            smtpClient.Send(sender, recipient, topic, message);
        }
    }
}