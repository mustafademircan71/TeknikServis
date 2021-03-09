using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class NewMessageAdminVm
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Message { get; set; }
    }
}
