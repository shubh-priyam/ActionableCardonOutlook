using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApiHandson.TestAction
{
    public class Action
    {
        public void ActionableMessage()
        {
            var message = new MailMessage();

            // message.To.Add(new MailAddress(_savingIdeaConfiguration.ToEmailId1));

            message.From = new MailAddress("Sender id");

            //message.Bcc.Add(new MailAddress(_savingIdeaConfiguration.FromEmailId));
            message.Subject = "Actionable Card Demo";

            var html = System.IO.File.ReadAllText(@".\card.html");
            message.Body = html;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                smtp.Host = "smtp.office365.com";
                smtp.Port = 587;
                //configure your mail id and password
                smtp.Credentials = new System.Net.NetworkCredential("id", "pass");//Configure your mail ID and Password for testing
                
                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(message);
                Task.FromResult(0);
                Console.WriteLine("Message Successfully Sent");

            }
        }
    }
}
