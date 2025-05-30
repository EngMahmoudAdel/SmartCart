using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace SmartCart.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // هنا يمكنك إضافة منطق إرسال البريد الإلكتروني باستخدام خدمة حقيقية
            // في الوقت الحالي نرسل رسالة إلى الكونسول فقط.
            return Task.CompletedTask;

        }
    }
}
