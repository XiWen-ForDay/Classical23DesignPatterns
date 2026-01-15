using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 具体抽象2：Profinet设备
    public class ProfinetDevice : IndustrialDevice
    {
        public ProfinetDevice(ICommunication communication) : base(communication)
        {
        }

        public override void ExecuteOperation(string command)
        {
            ConsoleBox.WriteLine("\n=== Profinet设备操作 ===");
            _communication.SendCommand($"Profinet指令：{command}");
            _communication.ReceiveData();
        }
    }

}
