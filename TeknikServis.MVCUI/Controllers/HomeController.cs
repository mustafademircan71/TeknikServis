using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TeknikServis.Business.Abstract;
using TeknikServis.Model.Entity;
using TeknikServis.Model.ViewModels.HomePage;
using TeknikServis.MVCUI.Models;

namespace TeknikServis.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceBs _serviceBs;
        private readonly IFaultBs _faultBs;
        private readonly IDeviceStatusBs _deviceStatusBs;
        private readonly IMessageBs _messageBs;
        public HomeController(IServiceBs serviceBs, IFaultBs faultBs, IDeviceStatusBs deviceStatusBs, IMessageBs messageBs)
        {
            _serviceBs = serviceBs;
            _faultBs = faultBs;
            _deviceStatusBs = deviceStatusBs;
            _messageBs = messageBs;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ServiceQueryVm vm = new ServiceQueryVm();
            vm.Faults = _faultBs.FaultList().Select(x => new SelectListItem()
            {
                Text = x.FaultName,
                Value = x.Id.ToString()
            }).ToList();
            vm.DeviceStatuses = _deviceStatusBs.DeviceStatusList().Select(x => new SelectListItem()
            {
                Text = x.CihazDurumu,
                Value = x.Id.ToString()
            }).ToList();

            return View(vm);
        }
    
    
        [HttpPost]
        public IActionResult ServiceDetails(string serviceCode)
        {
            Service service = _serviceBs.ServiceByCode(serviceCode,"Fault","DeviceStatus");

             ServiceQueryVm vm = new ServiceQueryVm();
            vm.FullName = service.FullName;
            vm.ServiceCode = service.ServiceCode;
            vm.Brand = service.Brand;
            vm.Model = service.Model;
            vm.FaultId = service.FaultId;
            vm.DeviceStatusId = service.DeviceStatusId;

            return Json(new { ServiceDetailsInfo=vm});
        }
       
    }
}
