using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_StrategyLibrary
{
    /// <summary>
    /// 模糊控制策略（适用于非线性、难建模的场景）
    /// </summary>
    public class FuzzyControlStrategy : ITempControlStrategy
    {
        public double CalculateOutput(double currentTemp, double targetTemp)
        {
            double error = targetTemp - currentTemp;
            // 简化模糊控制逻辑：根据误差区间输出固定值
            double absError = Math.Abs(error);
            double output = 0;
            if (absError>10)
            {
                output = 80;// 误差大，满功率输出
            }
            else if (absError>10)
            {
                output = 50;// 误差中等，中等输出
            }
            else
            {
                output = 20;// 误差小，低功率输出
            }
            ConsoleBox.WriteLine($"[模糊控制] 当前温度{currentTemp}→目标{targetTemp}，输出：{output:F2}");
            return output;
        }
    }
}
