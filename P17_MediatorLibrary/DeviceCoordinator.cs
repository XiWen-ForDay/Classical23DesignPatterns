using P17_MediatorLibrary.AbstractDevice;
using P17_MediatorLibrary.AbstractMediator;
using P17_MediatorLibrary.SpecificDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_MediatorLibrary
{
    // 具体中介者：设备协调器（实现具体的消息转发逻辑）
    public class DeviceCoordinator : DeviceMediator
    {
        private TemperatureSensor _sensor;
        private PlcController _plc;
        private Alarm _alarm;

        // 注册设备时记录引用
        public override void RegisterDevice(Device device)
        {
            if (device is TemperatureSensor sensor)
                _sensor = sensor;
            else if (device is PlcController plc)
                _plc = plc;
            else if (device is Alarm alarm)
                _alarm = alarm;
        }

        // 根据发送者和消息内容，决定转发给哪些设备
        public override void SendMessage(string message, Device sender)
        {
            if (sender == _sensor)
            {
                // 传感器的消息转发给PLC和报警器
                _plc?.Receive(message);
                _alarm?.Receive(message);
            }
            else if (sender == _plc)
            {
                // PLC的消息转发给报警器（更新状态）
                _alarm?.Receive(message);
            }
            // 可以继续扩展其他设备的消息转发规则
        }
    }
}
