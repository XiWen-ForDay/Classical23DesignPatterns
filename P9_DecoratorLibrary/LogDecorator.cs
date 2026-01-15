using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_DecoratorLibrary
{
    // 5. 具体装饰器2：日志记录装饰器（给串口通信添加发送/接收日志）
    public class LogDecorator : SerialCommDecorator
    {
        public LogDecorator(ISerialComm serialComm) : base(serialComm)
        {
        }

        public override bool SendData(byte[] data)
        {
            // 记录发送日志（可写入本地文件或数据库）
            ConsoleBox.WriteLine($"[日志装饰器] 记录发送日志：时间={DateTime.Now:HH:mm:ss}，数据={BitConverter.ToString(data)}");
            // 调用底层发送逻辑
            return _serialComm.SendData(data);
        }

        public override byte[] ReceiveData()
        {
            // 调用底层接收逻辑
            byte[] data = _serialComm.ReceiveData();
            // 记录接收日志（可写入本地文件或数据库）
            if (data != null)
            {
                ConsoleBox.WriteLine($"[日志装饰器] 记录接收日志：时间={DateTime.Now:HH:mm:ss}，数据={BitConverter.ToString(data)}");
            }
            else
            {
                ConsoleBox.WriteLine($"[日志装饰器] 记录接收日志：时间={DateTime.Now:HH:mm:ss}，数据=NULL（CRC校验失败）");
            }
            return data;
        }

        public override string GetCommDescription()
        {
            return $"{_serialComm.GetCommDescription()} + 日志记录";
        }
    }

}
