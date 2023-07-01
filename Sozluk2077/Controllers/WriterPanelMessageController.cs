using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sozluk2077.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        // GET: WriterPanelMessage
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator validationRules = new MessageValidator();
        public ActionResult Inbox()
        {
            var messageList = messageManager.GetMessagesInbox();
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messageList = messageManager.GetMessagesSendbox();
            return View(messageList);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }

    }
}