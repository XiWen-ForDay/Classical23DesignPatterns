using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_DecoratorLibrary
{
    // 1. 抽象组件：定义工控串口通信的核心行为
    public interface ISerialComm
    {
        // 发送数据（返回是否成功）
        bool SendData(byte[] data);
        // 接收数据（返回接收到的字节数组）
        byte[] ReceiveData();
        // 获取通信描述（比如带校验/日志等标识）
        string GetCommDescription();
    }
}
