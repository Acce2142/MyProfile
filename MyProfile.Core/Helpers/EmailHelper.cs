using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MyShop.Core.Helpers
{
    
    public class EmailHelper
    {
        public EmailHelper ()
        {

        }

        public void Send(string recipientParam, string body, string title)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailAddress Recipient = new MailAddress(recipientParam);
                MailAddress sender = new MailAddress("sli43503@gmail.com");
                NetworkCredential GmailCredential = new NetworkCredential("sli43503@gmail.com", "zXc123456");
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = GmailCredential;
                MailMessage msg = new MailMessage();
                msg.To.Add(Recipient);
                msg.From = sender;
                msg.Subject = title;
                msg.Body = body;
                client.Send(msg);

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }


        static void main(string[] args)
        {
            EmailHelper helper = new EmailHelper();
        }
    }
}
