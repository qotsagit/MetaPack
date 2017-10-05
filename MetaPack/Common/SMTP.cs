using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;

namespace MetaPack.Common
{

    class SMTP : SmtpClient 
    {
        
        public MailMessage Mail;

        public SMTP() 
        {
            Host = Settings.SMTPHost;
            Credentials = new System.Net.NetworkCredential(Settings.SMTPUser, Settings.SMTPPassword);
            Port = Settings.SMTPPort;
            Mail = new MailMessage();
        }

        public void SendTestEmail(string from, string to) 
        {
            Mail.From = new MailAddress(from);
            Mail.To.Add(to);
            Mail.Subject = "Test Mail";
            Mail.Body = "Test Body";
            Send(Mail);
        }

        public void SendOrderEmail(string subject,string order) 
        {
            Mail.From = new MailAddress(Settings.SMTPEmailFrom);
            Mail.To.Add(Settings.SMTPEmailTo);
            Mail.Subject = subject;
            Mail.Body = order;
            Send(Mail);
        }
        
    }
}
