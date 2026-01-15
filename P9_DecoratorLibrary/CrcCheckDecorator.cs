using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_DecoratorLibrary
{
    // 4. 具体装饰器1：CRC校验装饰器（给串口通信添加CRC16校验功能）
    public class CrcCheckDecorator : SerialCommDecorator
    {
        public CrcCheckDecorator(ISerialComm serialComm) : base(serialComm)
        {
        }

        // 发送前添加CRC校验码
        public override bool SendData(byte[] data)
        {
            // 1. 计算原始数据的CRC16校验码
            byte[] crc = CalculateCrc16(data);
            // 2. 拼接原始数据 + CRC 码
            byte[] dataWithCrc = new byte[data.Length + crc.Length];
            Array.Copy(data, dataWithCrc, data.Length);
            Array.Copy(crc, 0, dataWithCrc, data.Length, crc.Length);
            // 3. 调用底层串口发送带CRC的数据
            ConsoleBox.WriteLine($"[CRC装饰器] 给原始数据添加CRC：{BitConverter.ToString(crc)}");
            return _serialComm.SendData(dataWithCrc);
        }

        // 接收后验证CRC校验码
        public override byte[] ReceiveData()
        {
            // 1. 接收底层数据（含CRC码）
            byte[] dataWithCrc = _serialComm.ReceiveData();
            // 2. 分离原始数据和CRC码（取前N-2字节为数据，后2字节为CRC）
            byte[] rawData = new byte[dataWithCrc.Length - 2];
            Array.Copy(dataWithCrc, rawData, rawData.Length);
            byte[] receivedCrc = new byte[2];
            Array.Copy(dataWithCrc, rawData.Length, receivedCrc, 0, 2);
            // 3. 验证CRC是否匹配
            byte[] calculatedCrc = CalculateCrc16(rawData);
            bool crcValid = BitConverter.ToString(receivedCrc) == BitConverter.ToString(calculatedCrc);
            ConsoleBox.WriteLine($"[CRC装饰器] 验证CRC：{(crcValid ? "通过" : "失败")}");
            // 4. 返回剥离CRC后的原始数据（业务层无需关心CRC）
            return crcValid ? rawData : null;
        }

        public override string GetCommDescription()
        {
            return $"{_serialComm.GetCommDescription()} + CRC16校验";
        }

        // 模拟CRC16计算（实际可使用Modbus库中的CRC方法）
        private byte[] CalculateCrc16(byte[] data)
        {
            // 此处简化逻辑，实际项目需替换为标准CRC16算法
            return new byte[] { 0x12, 0x34 };
        }
    }
}
