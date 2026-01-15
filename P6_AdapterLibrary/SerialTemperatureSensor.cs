using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_AdapterLibrary
{
    // ===== 2. 适配者：旧的串口温度传感器（接口不兼容，返回字符串） =====
    public class SerialTemperatureSensor
    {
        // 旧传感器的方法：返回带单位的字符串，如 "25.5℃"
        public string GetRawTemperatureData()
        {
            // 模拟串口读取的原始数据
            return "25.5℃";
        }
    }
}
