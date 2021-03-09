using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
     public interface ISendMessageBs
    {
        List<SendMessage> SendMessageList(params string[] includeList);
        void Insert(SendMessage sendMessage);

        void Delete(int id);
    }
}
