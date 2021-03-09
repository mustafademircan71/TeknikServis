using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface  IMessageBs
    {
        List<Message> MessageList(params string[] includeList);
        Message MessageById(int id);
        void Insert(Message message);
        void Delete(int id);
    }
}
