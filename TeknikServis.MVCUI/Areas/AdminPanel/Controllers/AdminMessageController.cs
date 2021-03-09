using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Model.Entity;
using TeknikServis.Model.ViewModels.AdminPanel;

namespace TeknikServis.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminMessageController : Controller
    {
        private readonly IMessageBs _messageBs;
        private readonly ISendMessageBs _sendMessageBs;
        public AdminMessageController(IMessageBs messageBs, ISendMessageBs sendMessageBs)
        {
            _sendMessageBs = sendMessageBs;
            _messageBs = messageBs;
        }
        public IActionResult MessageList()
        {
            List<Message> messageList = _messageBs.MessageList();
            return View(messageList);
        }
        [HttpGet]
        public IActionResult SendMessageList()
        {
            List<SendMessage> messages = _sendMessageBs.SendMessageList();

            return View(messages);
        }
        [HttpPost]
        public IActionResult MessageDetails(int id)
        {
            Message message = _messageBs.MessageById(id);

            MessageDetailsVm vm = new MessageDetailsVm();

            vm.Email = message.Email;
            vm.Id = message.Id;
            vm.FullName = message.FullName;
            
            return Json(new { MessageInfo = vm });
        }
        [HttpPost]
        public IActionResult NewMessage(NewMessageAdminVm vm)
        {
            SendMessage send = new SendMessage();
            send.Email = vm.Mail;
            send.IsActive = true;
            send.FullName = vm.FullName;
            send.Messages = vm.Message;
            _sendMessageBs.Insert(send);
            string mailMessage = $"Sayın {send.FullName} {send.Messages}";
            MailSender.Send(send.Email,"Gönderilen Mesaj" , mailMessage);
            return Json(new { Result = true, Message = "Mesaj Gönderildi" });

        }
        [HttpPost]
        public IActionResult MessageDelete(int id)
        {
            _messageBs.Delete(id);

            return Json(new { Result = true, Message = "Başarıyla Silindi" });
        }
        [HttpPost]
        public IActionResult SendMessageDelete(int id)
        {
            _sendMessageBs.Delete(id);

            return Json(new { Result = true, Message = "Başarıyla Silindi" });
        }
    }
}
