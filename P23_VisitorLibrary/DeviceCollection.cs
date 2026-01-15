using P23_VisitorLibrary.DeviceElementInterface;
using P23_VisitorLibrary.VisitorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary
{
    // 6. 设备集合（管理所有设备，支持批量访问）
    public class DeviceCollection
    {
        private List<IDeviceElement> _devices = new List<IDeviceElement>();

        public void AddDevice(IDeviceElement device)
        {
            _devices.Add(device);
        }

        // 批量让所有设备接受访问者操作
        public void AcceptVisitor(IDeviceVisitor visitor)
        {
            foreach (var device in _devices)
            {
                device.Accept(visitor);
            }
        }
    }
}
