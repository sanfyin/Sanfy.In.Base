using System;
namespace Sanfy.In.Base.App.Email
{
    public struct EmailMessage
    {
        public string To { get; }

        public string Subject { get; }

        public string Content { get; }

        public EmailMessage(
            string to,
            string subject,
            string content)
        {
            this.To = to;
            this.Subject = subject;
            this.Content = content;
        }
    }
}
