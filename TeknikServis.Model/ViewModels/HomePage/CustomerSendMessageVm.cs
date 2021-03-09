using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.ViewModels.HomePage
{
    public class CustomerSendMessageVm

    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Messages { get; set; }
    }
}
