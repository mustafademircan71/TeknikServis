using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeknikServis.Business.Abstract;
using TeknikServis.Model.Entity;
using TeknikServis.Model.ViewModels.AdminPanel;
using TeknikServis.MVCUI.Aspects;

namespace TeknikServis.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    public class FaultController : Controller
    {
        private readonly IFaultBs _faultBs;
        public FaultController(IFaultBs faultBs)
        {
            _faultBs = faultBs;
        }
        [HttpGet]
        public IActionResult FaultList()
        {
            List<Fault> faults = _faultBs.FaultList();
            return View(faults);
        }
        [HttpPost]
        public IActionResult NewFault(NewFaultVm vm)
        {
            Fault fault = new Fault();
            fault.IsActive = vm.IsActive;
            fault.FaultName = vm.FaultName;
            _faultBs.Insert(fault);
            return Json(new { Result = true,Message="Arıza Tipi Eklendi" });
        }
        [HttpPost]
        public IActionResult FaultDetails(int id)
        {
            Fault fault = _faultBs.GetByFault(id);
            FaultDetailsVm vm = new FaultDetailsVm();
            vm.Id = fault.Id;
            vm.IsActive = fault.IsActive;
            vm.FaultName = fault.FaultName;
            return Json(new { FaultInfo = vm });
        }
        [HttpPost]
        public IActionResult FaultUpdate(FaultUpdateVm vm)
        {
            Fault fault = _faultBs.GetByFault(vm.Id);
            fault.FaultName = vm.FaultName;
            fault.IsActive = vm.IsActive;
            _faultBs.Update(fault);
            return Json(new { Resul = true, Message = "Arıza Tipi Güncellendi" });
        }
    }
}
