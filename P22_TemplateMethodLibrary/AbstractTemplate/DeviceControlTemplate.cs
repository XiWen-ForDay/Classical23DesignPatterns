using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_TemplateMethodLibrary.AbstractTemplate
{
    // 抽象模板类：定义设备控制的固定流程
    public abstract class DeviceControlTemplate: AbstractBaseTemplate
    {
        // 模板方法：固定的控制流程，用 sealed 防止子类修改流程结构
        public sealed override void ControlProcess()
        {
            Console.WriteLine("===== 设备控制流程启动 =====");
            // 步骤1：初始化设备
            InitDevice();
            // 步骤2：采集数据（子类实现）
            float data = CollectData();
            // 步骤3：处理数据（子类实现）
            bool isAbnormal = ProcessData(data);
            // 步骤4：执行控制（子类实现）
            ExecuteControl(isAbnormal, data);
            // 步骤5：记录日志
            LogResult(isAbnormal, data);
            Console.WriteLine("===== 设备控制流程结束 =====\n");
        }

        // 固定步骤：初始化设备（所有设备通用）
        private void InitDevice()
        {
            Console.WriteLine("1. 初始化设备：建立通信连接，自检传感器");
        }

        // 固定步骤：记录日志（所有设备通用）
        private void LogResult(bool isAbnormal, float data)
        {
            string status = isAbnormal ? "异常" : "正常";
            Console.WriteLine($"5. 记录日志：数据={data}，状态={status}，时间={DateTime.Now:HH:mm:ss}");
        }

        // 抽象步骤1：采集数据（子类实现）
        protected abstract float CollectData();

        // 抽象步骤2：处理数据（子类实现）
        protected abstract bool ProcessData(float data);

        // 抽象步骤3：执行控制（子类实现）
        protected abstract void ExecuteControl(bool isAbnormal, float data);
    }

}
