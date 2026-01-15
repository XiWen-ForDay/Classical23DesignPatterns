using P23_VisitorLibrary.SpecificDevices;
using P23_VisitorLibrary.VisitorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.SpecificVisitor
{
    // 4. 具体访问者1：设备自检访问者
    public class SelfCheckVisitor : IDeviceVisitor
    {
        // 对PLC的自检逻辑
        public void VisitPlc(PlcDevice plc)
        {
            Console.WriteLine($"=== {plc.PlcId} 自检 ===");
            Console.WriteLine($"1. 检查固件版本：{plc.FirmwareVersion}（要求V2.0以上）");
            Console.WriteLine($"2. 检查通信链路：正常");
            Console.WriteLine($"3. 自检结果：合格\n");
        }

        // 对传感器的自检逻辑
        public void VisitSensor(SensorDevice sensor)
        {
            Console.WriteLine($"=== {sensor.SensorId} 自检 ===");
            Console.WriteLine($"1. 检查测量类型：{sensor.MeasureType}（匹配硬件）");
            Console.WriteLine($"2. 检查校准状态：已校准（有效期至2026-12-31）");
            Console.WriteLine($"3. 自检结果：合格\n");
        }

        // 对报警器的自检逻辑
        public void VisitAlarm(AlarmDevice alarm)
        {
            Console.WriteLine($"=== {alarm.AlarmId} 自检 ===");
            Console.WriteLine($"1. 检查激活状态：{(alarm.IsActive ? "已激活" : "未激活")}");
            Console.WriteLine($"2. 测试蜂鸣器：正常");
            Console.WriteLine($"3. 测试指示灯：正常");
            Console.WriteLine($"4. 自检结果：{(alarm.IsActive ? "合格" : "不合格，需激活")}\n");
        }
    }
}
