using System;
using System.Net.Mail;

namespace InspiringIPTomar
{
    internal class SendGridMessage
    {
        public SendGridMessage()
        {
        }

        public MailAddress From { get; internal set; }
        public string Html { get; internal set; }
        public string Subject { get; internal set; }
        public string Text { get; internal set; }

        internal void AddTo(string destination)
        {
            throw new NotImplementedException();
        }
    }
}