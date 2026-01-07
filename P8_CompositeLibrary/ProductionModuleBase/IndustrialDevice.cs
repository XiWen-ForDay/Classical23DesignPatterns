using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_CompositeLibrary.ProductionModuleBase
{
    // 抽象组件：定义所有设备（单个/组合）的通用行为
    public abstract class IndustrialDevice
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceId { get; set; }

        public IndustrialDevice(string deviceName, string deviceId)
        {
            DeviceName = deviceName;
            DeviceId = deviceId;
        }

        /// <summary>
        /// 获取设备运行状态
        /// </summary>
        public abstract string GetRunStatus();

        /// <summary>
        /// 启动设备
        /// </summary>
        public abstract void StartDevice();

        /// <summary>
        /// 停止设备
        /// </summary>
        public abstract void StopDevice();

        /// <summary>
        /// 添加子设备（组合设备重写，单个设备不支持）
        /// </summary>
        public virtual void AddDevice(IndustrialDevice device)
        {
            throw new NotImplementedException("单个设备不支持添加子设备");
        }

        /// <summary>
        /// 移除子设备（组合设备重写，单个设备不支持）
        /// </summary>
        public virtual void RemoveDevice(IndustrialDevice device)
        {
            throw new NotImplementedException("单个设备不支持移除子设备");
        }
    }
}
