using P17_MediatorLibrary.AbstractMediator;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_MediatorLibrary.AbstractDevice
{
    // 抽象设备类：所有设备的基类
    public abstract class Device
    {
        protected DeviceMediator _mediator; // 持有中介者引用
        public string Name { get; } // 设备名称

        public Device(string name, DeviceMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            mediator.RegisterDevice(this); // 初始化时自动注册到中介者
        }

        // 发送消息（通过中介者转发）
        public void Send(string message)
        {
            ConsoleBox.WriteLine($"{Name} 发送消息：{message}");
            _mediator.SendMessage(message, this);
        }

        // 接收消息（由中介者调用）
        public abstract void Receive(string message);
    }
}
