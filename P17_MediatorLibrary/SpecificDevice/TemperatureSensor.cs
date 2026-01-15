using P17_MediatorLibrary.AbstractDevice;
using P17_MediatorLibrary.AbstractMediator;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P17_MediatorLibrary.SpecificDevice
{
    // 具体设备1：温度传感器
    public class TemperatureSensor : Device
    {
        public TemperatureSensor(string name, DeviceMediator mediator)
            : base(name, mediator) { }

        // 模拟检测温度并发送消息
        public void DetectTemperature(float temperature)
        {
            if (temperature > 50)
            {
                Send($"温度过高：{temperature}℃");
            }
            else
            {
                Send($"温度正常：{temperature}℃");
            }
        }

        // 传感器一般只接收控制指令（比如校准）
        public override void Receive(string message)
        {
            ConsoleBox.WriteLine($"{Name} 接收消息：{message}");
            if (message.Contains("校准"))
            {
                ConsoleBox.WriteLine($"{Name}：开始校准温度传感器...");
            }
        }
    }
}
