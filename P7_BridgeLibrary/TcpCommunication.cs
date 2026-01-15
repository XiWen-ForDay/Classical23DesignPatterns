using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 具体实现2：TCP通信
    public class TcpCommunication : ICommunication
    {
        public bool SendCommand(string command)
        {
            Console.WriteLine($"[TCP通信] 发送指令：{command}");
            return true;
        }

        public string ReceiveData()
        {
            string data = "TCP返回：设备参数更新成功";
            Console.WriteLine(data);
            return data;
        }
    }
}
