using Microsoft.AspNetCore.Mvc;
using SmartCart.Models;
using SmartCart.Data.Interfaces;

namespace SmartCart.Controllers
{
    public class ContactMessageController : Controller
    {
        private readonly IUnitOfWork myUnit;
        public ContactMessageController(IUnitOfWork _myUnit)
        {
            myUnit = _myUnit;
        }


        public IActionResult Index()
        {
            return View(new ContactMessage()); // نموذج فارغ للعرض
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(ContactMessage msg)
        {
            ViewBag.ReceivedName = msg.Name;
            ViewBag.ReceivedMessage = msg.Message;
            ViewBag.ReceivedEmail = msg.Email;

            // التحقق من صحة النموذج
            if (!ModelState.IsValid)
            {
                return View("Index", msg);
            }

            msg.SentDate = DateTime.Now;

            // إضافة الرسالة إلى قاعدة البيانات
            myUnit.ContactMessages.AddOne(msg);
            await myUnit.CompleteAsync();

            TempData["Success"] = "تم إرسال رسالتك بنجاح!";
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> ShowMessages()
        {
            // استرجاع جميع الرسائل (استخدم FindAllAsync بدلاً من FindAll)
            var messages = await myUnit.ContactMessages.FindAllAsync();  // استخدام await هنا
            return View(messages);
        }




    }
}
