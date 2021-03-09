using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.MVCUI.Controllers
{
    public class OurServicesController : Controller
    {
        private readonly IFaultBs _faultBs;
        public OurServicesController(IFaultBs faultBs)
        {
            _faultBs = faultBs;
        }
        public IActionResult Index()
        {
            List<Fault> faults= _faultBs.FaultList();
            return View(faults);
        }
    }
}
