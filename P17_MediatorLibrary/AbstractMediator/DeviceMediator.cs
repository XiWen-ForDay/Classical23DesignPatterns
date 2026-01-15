using P17_MediatorLibrary.AbstractDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_MediatorLibrary.AbstractMediator
{
    // 抽象中介者：定义设备间通信的接口
    public abstract class DeviceMediator
    {
        // 注册设备到中介者
        public abstract void RegisterDevice(Device device);
        // 转发消息：从一个设备发送消息到目标设备（或所有设备）
        public abstract void SendMessage(string message, Device sender);
    }
}
