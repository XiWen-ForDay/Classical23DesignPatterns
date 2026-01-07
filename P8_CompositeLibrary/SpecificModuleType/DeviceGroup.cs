using P8_CompositeLibrary.ProductionModuleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_CompositeLibrary.SpecificModuleType
{
    // 组合节点：设备组（工位/生产线）
    public class DeviceGroup : IndustrialDevice
    {
        // 存储子设备集合（支持单个设备/子设备组）
        private readonly List<IndustrialDevice> _subDevices = new List<IndustrialDevice>();

        public DeviceGroup(string deviceName, string deviceId) : base(deviceName, deviceId) { }

        public override string GetRunStatus()
        {
            string status = $"[{DeviceId}] {DeviceName} 包含设备状态：\n";
            foreach (var device in _subDevices)
            {
                status += $"  {device.GetRunStatus()}\n";
            }
            return status.TrimEnd();
        }

        public override void StartDevice()
        {
            Console.WriteLine($"===== 批量启动 [{DeviceId}] {DeviceName} 下所有设备 =====");
            foreach (var device in _subDevices)
            {
                device.StartDevice();
            }
            Console.WriteLine("========================================\n");
        }

        public override void StopDevice()
        {
            Console.WriteLine($"===== 批量停止 [{DeviceId}] {DeviceName} 下所有设备 =====");
            foreach (var device in _subDevices)
            {
                device.StopDevice();
            }
            Console.WriteLine("========================================\n");
        }

        public override void AddDevice(IndustrialDevice device)
        {
            _subDevices.Add(device);
            Console.WriteLine($"[{device.DeviceId}] {device.DeviceName} 已加入 [{DeviceId}] {DeviceName}");
        }

        public override void RemoveDevice(IndustrialDevice device)
        {
            if (_subDevices.Contains(device))
            {
                _subDevices.Remove(device);
                Console.WriteLine($"[{device.DeviceId}] {device.DeviceName} 已移出 [{DeviceId}] {DeviceName}");
            }
            else
            {
                Console.WriteLine($"[{device.DeviceId}] {device.DeviceName} 不在当前设备组中");
            }
        }
    }

}
