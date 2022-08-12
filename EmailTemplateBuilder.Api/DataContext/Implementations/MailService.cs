using EmailTemplateBuilder.Api.Entities;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text;
using System;
using EmailTemplateBuilder.Api.Commands;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.DataContext.Implementations
{
    public static class MailService 
        
        { 
        
        private static string Host = "smtp-relay.sendinblue.com";
        private static int Port = 587;
        private static string MailSenderUserName = "andrew.xero2pi@gmail.com";
        private static string MailAccountPassword = "avq4nQgMcCRXx5h1";

        public static void SendMail(EmailSendCommand emailSendCommand)
        {
          
            // EmailTemplate emailTemplate = _context.EmailTemplates.SingleOrDefault(x => x.TemplateName == emailDataDto.EmailTemplateName);


            if (emailSendCommand != null )
            {
                string to = emailSendCommand.To; //To address    
                string from = "email.builder@github.com"; //From address    
                MailMessage message = new MailMessage(from, to);
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                };

                string templateBody = emailSendCommand.TemplateHtml;
                string _mailbody = Regex.Unescape(templateBody);      // unescape  Mailtemaplate 



                // formate Mailtemaplate with place holder 


                message.Subject = "Approval Email";

                message.Body = _mailbody;
             
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient(Host, Port); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential(MailSenderUserName, MailAccountPassword);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                    
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // _logger.LogError(ex.Message);
                }
            }

        }
    }
}
