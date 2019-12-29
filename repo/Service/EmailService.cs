using System;
using System.Net;
using System.Net.Mail;

namespace repo.Service
{
    public class EmailService
    {
        private SmtpClient _client;
        public EmailService()
        {
            CreateClient();
        }

        private void CreateClient()
        {
            _client = new SmtpClient();
            _client.EnableSsl = true;
            _client.Host = "smtp.gmail.com";
            _client.Port = 587;
            _client.UseDefaultCredentials = true;
            _client.Credentials = new NetworkCredential("XXXX", "XXXX");
        }
        public MailMessage CreateMessage()
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("XXXX");
            message.To.Add("XXXX");
            message.Subject = "Uwaga zmiana";
            message.Body = "Przypisano pracownika do samochodu" + Environment.NewLine + DateTime.Now.ToShortDateString();
            return message;

        }
        public void SendMessage(MailMessage message)
        {
            _client.Send(message);
        }


    }
}