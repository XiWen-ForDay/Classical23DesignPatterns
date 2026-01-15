using P23_VisitorLibrary.SpecificDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.VisitorInterface
{
    // 1. 定义访问者接口（声明对每种设备的操作）
    public interface IDeviceVisitor
    {
        void VisitPlc(PlcDevice plc);       // 访问PLC设备
        void VisitSensor(SensorDevice sensor); // 访问传感器
        void VisitAlarm(AlarmDevice alarm);   // 访问报警器
    }
}
