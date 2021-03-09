using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.Entity
{
    public class SendMessage:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Messages { get; set; }
    }
}
