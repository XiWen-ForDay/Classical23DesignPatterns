using P23_VisitorLibrary.DeviceElementInterface;
using P23_VisitorLibrary.VisitorInterface;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.SpecificDevices
{
    // 传感器设备
    public class SensorDevice : IDeviceElement
    {
        public string SensorId { get; set; }
        public string MeasureType { get; set; } // 测量类型：温度/压力等

        public SensorDevice(string sensorId, string measureType)
        {
            SensorId = sensorId;
            MeasureType = measureType;
        }

        public void Accept(IDeviceVisitor visitor)
        {
            visitor.VisitSensor(this);
        }

        // 传感器自身的基础方法（无需修改）
        public void CollectData() => ConsoleBox.WriteLine($"{SensorId} 采集{MeasureType}数据");
    }
}
