using P17_MediatorLibrary.AbstractDevice;
using P17_MediatorLibrary.AbstractMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P17_MediatorLibrary.SpecificDevice
{
    // 具体设备3：报警器
    public class Alarm : Device
    {
        public Alarm(string name, DeviceMediator mediator)
            : base(name, mediator) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} 接收消息：{message}");
            if (message.Contains("温度过高") || message.Contains("异常"))
            {
                Console.WriteLine($"{Name}：⚠️ 发出声光警报！");
            }
            else if (message.Contains("温度正常") || message.Contains("已启动"))
            {
                Console.WriteLine($"{Name}：警报解除");
            }
        }
    }
}
