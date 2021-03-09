using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Model.Entity;
using TeknikServis.Model.ViewModels.HomePage;

namespace TeknikServis.MVCUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageBs _messageBs;
        public ContactController(IMessageBs messageBs)
        {
            _messageBs = messageBs;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerSendMessage(CustomerSendMessageVm vm)
        {
            Message message = new Message();
            message.Id = vm.Id;
            message.FullName = vm.FullName;
            message.IsActive = true;
            message.Email = vm.Email;
            message.Messages = vm.Messages;

            string mailMailMessage = $"Sayın {message.FullName} Mesajınız Alınmıştır En Yakın Sürede Size Geri Dönüş Yapılacaktır.";

            MailSender.Send(message.Email, "Bildirim Mesajı", mailMailMessage);
            _messageBs.Insert(message);
            return Json(new { Result = true, Message = "Mesaj Gönderilmiştir " });
        }
    }
}
