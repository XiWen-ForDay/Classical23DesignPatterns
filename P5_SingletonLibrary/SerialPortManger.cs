using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P5_SingletonLibrary
{
    // 串口管理器单例类：全局唯一实例，管理串口的打开、关闭、发送数据
    public sealed class SerialPortManager
    {
        // 1. Lazy<T> 实现延迟初始化 + 线程安全
        private static readonly Lazy<SerialPortManager> _instance =
            new Lazy<SerialPortManager>(() => new SerialPortManager(), LazyThreadSafetyMode.ExecutionAndPublication);

        // 2. 串口核心对象
        private readonly SerialPort _serialPort;

        // 3. 私有构造函数：禁止外部 new 实例
        private SerialPortManager()
        {
            // 初始化串口参数（可根据工控需求调整）
            _serialPort = new SerialPort
            {
                PortName = "COM1",
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                ReadTimeout = 500,
                WriteTimeout = 500
            };
        }

        // 4. 对外提供唯一实例的访问入口
        public static SerialPortManager Instance => _instance.Value;

        // ===== 串口操作方法（封装工控常用功能） =====
        /// <summary>
        /// 打开串口
        /// </summary>
        public bool OpenPort()
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                    ConsoleBox.WriteLine($"串口 {_serialPort.PortName} 打开成功");
                    return true;
                }
                ConsoleBox.WriteLine("串口已处于打开状态");
                return true;
            }
            catch (Exception ex)
            {
                ConsoleBox.WriteLine($"串口打开失败：{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        public void ClosePort()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                ConsoleBox.WriteLine($"串口 {_serialPort.PortName} 关闭成功");
            }
        }

        /// <summary>
        /// 发送工控指令（如 Modbus 指令）
        /// </summary>
        public bool SendCommand(byte[] command)
        {
            if (!_serialPort.IsOpen) return false;

            try
            {
                _serialPort.Write(command, 0, command.Length);
                ConsoleBox.WriteLine($"发送指令：{BitConverter.ToString(command)}");
                return true;
            }
            catch (Exception ex)
            {
                ConsoleBox.WriteLine($"发送指令失败：{ex.Message}");
                return false;
            }
        }
    }
}
