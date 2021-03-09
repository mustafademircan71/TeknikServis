using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class MessageBs : IMessageBs
    {
        private readonly IMessageRepository _repo;
        public MessageBs(IMessageRepository repo)
        {
            _repo = repo;
        }
        public void Delete(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Message message)
        {
            _repo.Insert(message);
        }

        public Message MessageById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Message> MessageList(params string[] includeList)
        {
            return _repo.GetAll();
        }
    }
}
