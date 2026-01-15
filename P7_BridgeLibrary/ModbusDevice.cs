using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 具体抽象1：Modbus设备
    public class ModbusDevice : IndustrialDevice
    {
        public ModbusDevice(ICommunication communication) : base(communication)
        {
        }

        public override void ExecuteOperation(string command)
        {
            ConsoleBox.WriteLine("\n=== Modbus设备操作 ===");
            _communication.SendCommand($"Modbus指令：{command}");
            _communication.ReceiveData();
        }
    }

}
