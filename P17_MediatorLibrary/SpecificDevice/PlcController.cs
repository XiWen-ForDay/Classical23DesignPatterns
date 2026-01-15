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
    // 具体设备2：PLC控制器
    public class PlcController : Device
    {
        public PlcController(string name, DeviceMediator mediator)
            : base(name, mediator) { }

        // PLC接收消息后执行相应动作
        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} 接收消息：{message}");
            if (message.Contains("温度过高"))
            {
                // 执行降温动作，并通知中介者结果
                Console.WriteLine($"{Name}：启动风扇降温");
                Send("风扇已启动，正在降温...");
            }
            else if (message.Contains("温度正常"))
            {
                Console.WriteLine($"{Name}：无需操作，保持待机");
            }
        }
    }
}
