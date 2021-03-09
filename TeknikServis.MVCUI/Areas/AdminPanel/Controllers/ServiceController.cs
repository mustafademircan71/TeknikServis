using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;
using TeknikServis.Model.ViewModels.AdminPanel;
using TeknikServis.MVCUI.Aspects;

namespace TeknikServis.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    public class ServiceController : Controller
    {
        private readonly IServiceBs _serviceBs;
        private readonly IFaultBs _faultBs;
        private readonly IDeviceStatusBs _deviceStatusBs;
        private readonly ICustomerTypeBs _customerTypeBs;

        public ServiceController(IServiceBs serviceBs,IFaultBs faultBs, IDeviceStatusBs deviceStatusBs, ICustomerTypeBs customerTypeBs)
        {
            _serviceBs = serviceBs;
            _faultBs = faultBs;
            _deviceStatusBs = deviceStatusBs;
            _customerTypeBs = customerTypeBs;
        }
        [HttpGet]
        public IActionResult List()
        {
            ServiceListVm vm = new ServiceListVm();

            vm.Services = _serviceBs.ServiceList("Fault","DeviceStatus","CustomerType");
            vm.Faults = _faultBs.FaultList().Select(x => new SelectListItem()
            {
                Text = x.FaultName,
                Value = x.Id.ToString()
            }).ToList();

            vm.Faults.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.DeviceStatus = _deviceStatusBs.DeviceStatusList().Select(x => new SelectListItem()
            {
                Text = x.CihazDurumu,
                Value = x.Id.ToString()
            }).ToList();

            vm.DeviceStatus.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.CustomerTypes = _customerTypeBs.CustomerTypeList().Select(x => new SelectListItem()
            {
                Text = x.CustomerTypeName,
                Value = x.Id.ToString()
            }).ToList();

            vm.CustomerTypes.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);

        }
        [HttpPost]
        public IActionResult New(NewServiceVm vm)
        {

            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br/>";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }
            Service service = new Service();
            service.IsActive = true;
            service.FullName = vm.FullName;
            service.Brand = vm.Brand;
            service.CustomerTypeId = vm.CustomerTypeId;
            service.UnitPrice = vm.UnitPrice;
            service.Model = vm.Model;
            service.ServiceCode = RandomValueGenerator.GenerateServiceCode(8);
            service.FaultId = vm.FaultId;
            service.DeviceStatusId = vm.DeviceStatusId;
            _serviceBs.Insert(service);
            return Json(new { Result = true, Message = "Kayıt Eklendi" });
        }
        [HttpPost]
        public IActionResult ServiceDetails(int id)
        {
            Service service = _serviceBs.ServiceById(id);

            ServiceDetailsVm vm =new ServiceDetailsVm();
            vm.Id = service.Id;
            vm.FullName = service.FullName;
            vm.Brand = service.Brand;
            vm.UnitPrice = service.UnitPrice;
            vm.CustomerTypeId = service.CustomerTypeId;
            vm.Model = service.Model;
            vm.FaultId = service.FaultId;
            vm.DeviceStatusId = service.DeviceStatusId;
            return Json(new { ServiceInfo = vm });

        }
        [HttpPost]
        public IActionResult ServiceUpdate(ServiceUpdateVm vm)
        {
            if (!ModelState.IsValid)
            {
                string errorMessage = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessage += error.ErrorMessage + "<br/>";
                    }
                }
                return Json(new { Result = false, Message = errorMessage });
            }
            Service service = _serviceBs.ServiceById(vm.Id);

            service.FullName = vm.FullName;
            service.Brand = vm.Brand;
            service.Model = vm.Model;
            service.CustomerTypeId = vm.CustomerTypeId;
            service.UnitPrice = vm.UnitPrice;
            service.FaultId = vm.FaultId;
            service.DeviceStatusId = vm.DeviceStatusId;
            _serviceBs.Update(service);
            return Json(new { Result = true, Message = "Servis Kaydı Güncellendi" });
        }
        [HttpPost]
        public IActionResult ServiceDelete(int id)
        {
            _serviceBs.Delete(id);

            return Json(new { Result = true, Message = "Servis Kaydı Silindi" });
        }
    }
}
