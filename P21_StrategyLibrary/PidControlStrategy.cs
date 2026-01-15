using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_StrategyLibrary
{
    // ===== 2. 实现具体策略类：不同的温度控制算法 =====
    /// <summary>
    /// PID控制策略（工业常用精准控制算法）
    /// </summary>
    public class PidControlStrategy : ITempControlStrategy
    {
        // PID参数（可根据工控场景调整）
        private readonly double _kp = 2.0;
        private readonly double _ki = 0.5;
        private readonly double _kd = 0.1;
        private double _lastError = 0;
        private double _errorSum = 0;

        public double CalculateOutput(double currentTemp, double targetTemp)
        {
            double error = targetTemp - currentTemp;
            _errorSum += error;
            double errorDiff = error - _lastError;
            _lastError = error;

            // PID计算公式：输出 = 比例项 + 积分项 + 微分项
            double output = _kp * error + _ki * _errorSum + _kd * errorDiff;
            ConsoleBox.WriteLine($"[PID控制] 当前温度{currentTemp}→目标{targetTemp}，输出：{output:F2}");
            return output;
        }
    }
}
