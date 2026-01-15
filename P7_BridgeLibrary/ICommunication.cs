using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 一、定义实现层：通信方式接口（桥接的核心，与设备类型解耦）
    public interface ICommunication
    {
        // 发送指令
        bool SendCommand(string command);
        // 接收数据
        string ReceiveData();
    }
}
