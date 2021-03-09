using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface IDeviceStatusBs
    {
        List<DeviceStatus> DeviceStatusList(params string[] includeList);
      



        void Update(DeviceStatus deviceStatus);
        void Insert(DeviceStatus deviceStatus);
    }
}
