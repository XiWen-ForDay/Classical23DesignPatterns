using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_DecoratorLibrary
{
    // 2. 具体组件：基础串口通信（不带任何附加功能，核心传输逻辑）
    public class BaseSerialComm : ISerialComm
    {
        // 模拟串口发送（实际开发中替换为 SerialPort.Write 逻辑）
        public bool SendData(byte[] data)
        {
            ConsoleBox.WriteLine($"[基础串口] 发送原始数据：{BitConverter.ToString(data)}");
            return true; // 模拟发送成功
        }

        // 模拟串口接收（实际开发中替换为 SerialPort.Read 逻辑）
        public byte[] ReceiveData()
        {
            // 模拟接收到原始数据（比如 Modbus 设备返回的响应）
            byte[] rawData = { 0x01, 0x03, 0x02, 0x00, 0x1A };
            ConsoleBox.WriteLine($"[基础串口] 接收原始数据：{BitConverter.ToString(rawData)}");
            return rawData;
        }

        public string GetCommDescription()
        {
            return "基础串口通信（无校验/无日志）";
        }
    }
}
