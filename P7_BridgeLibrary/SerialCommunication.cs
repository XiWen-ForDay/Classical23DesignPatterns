using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 具体实现1：串口通信
    public class SerialCommunication : ICommunication
    {
        public bool SendCommand(string command)
        {
            ConsoleBox.WriteLine($"[串口通信] 发送指令：{command}");
            return true;
        }

        public string ReceiveData()
        {
            string data = "串口返回：设备状态正常";
            ConsoleBox.WriteLine(data);
            return data;
        }
    }

}
