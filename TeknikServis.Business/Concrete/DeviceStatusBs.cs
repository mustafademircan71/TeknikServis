using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class DeviceStatusBs : IDeviceStatusBs
    {
        private readonly IDeviceStatusRepository _repo;
        public DeviceStatusBs(IDeviceStatusRepository repo)
        {
            _repo = repo;
        }
        

        public List<DeviceStatus> DeviceStatusList(params string[] includeList)
        {
          return  _repo.GetAll(includeList);
        }

        public void Insert(DeviceStatus deviceStatus)
        {
            _repo.Insert(deviceStatus);
        }

        public void Update(DeviceStatus deviceStatus)
        {
            _repo.Update(deviceStatus);
        }
    }
}
