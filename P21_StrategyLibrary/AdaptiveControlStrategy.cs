using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_StrategyLibrary
{
    /// <summary>
    /// 自适应控制策略（根据环境自动调整参数）
    /// </summary>
    public class AdaptiveControlStrategy : ITempControlStrategy
    {
        public double CalculateOutput(double currentTemp, double targetTemp)
        {
            double error = targetTemp - currentTemp;
            // 自适应逻辑：误差越大，输出系数越高
            double adaptFactor = Math.Abs(error) > 8 ? 1.2 : 0.8;
            double output = error * 3.0 * adaptFactor;
            Console.WriteLine($"[自适应控制] 当前温度{currentTemp}→目标{targetTemp}，输出：{output:F2}");
            return output;
        }
    }
}
