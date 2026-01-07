using P8_CompositeLibrary.ProductionModuleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_CompositeLibrary.SpecificModuleType
{
    // 叶子节点：单个工业设备（PLC/传感器/执行器）
    public class SingleDevice : IndustrialDevice
    {
        // 设备当前运行状态
        private bool _isRunning = false;

        public SingleDevice(string deviceName, string deviceId) : base(deviceName, deviceId) { }

        public override string GetRunStatus()
        {
            return $"[{DeviceId}] {DeviceName} - {(_isRunning ? "运行中" : "已停止")}";
        }

        public override void StartDevice()
        {
            if (!_isRunning)
            {
                _isRunning = true;
                Console.WriteLine($"[{DeviceId}] {DeviceName} 启动成功！");
            }
            else
            {
                Console.WriteLine($"[{DeviceId}] {DeviceName} 已处于运行状态！");
            }
        }

        public override void StopDevice()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Console.WriteLine($"[{DeviceId}] {DeviceName} 停止成功！");
            }
            else
            {
                Console.WriteLine($"[{DeviceId}] {DeviceName} 已处于停止状态！");
            }
        }
    }

}
