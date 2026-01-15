using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary.CommandReceiver
{
    // 2. 接收者：实际执行设备操作的类（比如PLC、传感器）
    public class IndustrialDevice
    {
        private string _deviceName;
        private bool _isRunning;
        private int _speed;

        public IndustrialDevice(string deviceName)
        {
            _deviceName = deviceName;
            _isRunning = false;
            _speed = 0;
        }

        // 设备启动操作
        public void Start()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                ConsoleBox.WriteLine($"[{_deviceName}] 设备已启动");
            }
            else
            {
                ConsoleBox.WriteLine($"[{_deviceName}] 设备已处于运行状态");
            }
        }

        // 设备停止操作
        public void Stop()
        {
            if (_isRunning)
            {
                _isRunning = false;
                _speed = 0;
                ConsoleBox.WriteLine($"[{_deviceName}] 设备已停止");
            }
            else
            {
                ConsoleBox.WriteLine($"[{_deviceName}] 设备已处于停止状态");
            }
        }

        // 调整设备速度
        public void SetSpeed(int speed)
        {
            if (_isRunning)
            {
                _speed = speed;
                ConsoleBox.WriteLine($"[{_deviceName}] 速度已调整至: {speed} rpm");
            }
            else
            {
                ConsoleBox.WriteLine($"[{_deviceName}] 请先启动设备再调整速度");
            }
        }

        // 获取当前状态
        public void ShowStatus()
        {
            ConsoleBox.WriteLine($"[{_deviceName}] 当前状态: {(_isRunning ? "运行中" : "已停止")}, 速度: {_speed} rpm");
        }
    }

}
