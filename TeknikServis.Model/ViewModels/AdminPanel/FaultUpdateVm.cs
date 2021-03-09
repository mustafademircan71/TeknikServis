using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class FaultUpdateVm
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string FaultName { get; set; }
    }
}
