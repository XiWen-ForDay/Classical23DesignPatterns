using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_StrategyLibrary
{
    // ===== 1. 定义策略接口：规范温度控制算法的行为 =====
    public interface ITempControlStrategy
    {
        /// <summary>
        /// 计算温度控制输出值
        /// </summary>
        /// <param name="currentTemp">当前温度</param>
        /// <param name="targetTemp">目标温度</param>
        /// <returns>控制输出量（如阀门开度、功率百分比）</returns>
        double CalculateOutput(double currentTemp, double targetTemp);
    }
}
