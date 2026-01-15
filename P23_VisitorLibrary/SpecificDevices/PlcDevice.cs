using P23_VisitorLibrary.DeviceElementInterface;
using P23_VisitorLibrary.VisitorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.SpecificDevices
{
    // 3. 具体设备类（实现元素接口）
    // PLC设备
    public class PlcDevice : IDeviceElement
    {
        public string PlcId { get; set; }
        public string FirmwareVersion { get; set; }

        public PlcDevice(string plcId, string firmwareVersion)
        {
            PlcId = plcId;
            FirmwareVersion = firmwareVersion;
        }

        // 接受访问者，将自己传入访问者的对应方法
        public void Accept(IDeviceVisitor visitor)
        {
            visitor.VisitPlc(this);
        }

        // PLC自身的基础方法（无需修改）
        public void ReadData() => Console.WriteLine($"{PlcId} 读取生产数据");
    }
}
