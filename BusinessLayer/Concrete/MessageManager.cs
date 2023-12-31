﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.GetAll(x => x.MessageID == id);
        }

        public List<Message> GetMessagesInbox()
        {
            return _messageDal.GetFind(x => x.Receiver == "admin@gmail.com");
        }

        public List<Message> GetMessagesSendbox()
        {
            return _messageDal.GetFind(x => x.Sender == "admin@gmail.com");
        }

        public void MessageAdd(Message message)
        {
            _messageDal.Add(message);
        }

        public void MessageRemove(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
