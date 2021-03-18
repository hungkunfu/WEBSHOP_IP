using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WebShopIP.Models.EmailModel;

namespace WebShopIP.EmailUtilities
{
    public class EmailUtilities
    {
        public static bool SenMail(EmailModel model, bool isBodyHtml = false)
        {
            using (MailMessage newEmail = new MailMessage(from: model.Email, to: model.EmailTo, subject: model.EmailSubject, body: model.EmailContent))
            {
                if (model.EmailAttachment != null)
                {
                    if (model.EmailAttachment.Length > 0)
                    {
                        string fileName = Path.GetFileName(model.EmailAttachment.FileName);
                        Attachment newAttachMent = new Attachment(model.EmailAttachment.OpenReadStream(), fileName);
                        newEmail.Attachments.Add(newAttachMent);
                    }
                }
                newEmail.IsBodyHtml = isBodyHtml;
                using (SmtpClient smtp = new SmtpClient())
                {
                    try
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        NetworkCredential networdCre = new NetworkCredential(userName: model.Email, password: model.Password);
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = networdCre;
                        smtp.Port = 587;
                        smtp.Send(newEmail);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

        }
    }
}