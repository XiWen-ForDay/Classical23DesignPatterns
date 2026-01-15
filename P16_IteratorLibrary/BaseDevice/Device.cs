using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.BaseDevice
{
    // 设备实体类（PLC、传感器共用）
    public class Device
    {
        public string Name { get; set; }
        public string Type { get; set; } // "PLC"或"Sensor"
        public string Status { get; set; } // 设备状态

        public Device(string name, string type, string status)
        {
            Name = name;
            Type = type;
            Status = status;
        }
    }
}
