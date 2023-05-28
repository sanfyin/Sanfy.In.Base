using System;
namespace Sanfy.In.Base.App.Email
{
    public interface IEmailSender
    {
        void SendEmail(EmailMessage message);
    }
}
