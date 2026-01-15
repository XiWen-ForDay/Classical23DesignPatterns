using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_AdapterLibrary
{
    // ===== 1. 目标接口：上位机系统期望的接口（返回浮点数温度） =====
    public interface ITemperatureSensor
    {
        // 上位机需要的方法：获取浮点型温度值
        float GetTemperature();
    }
}
