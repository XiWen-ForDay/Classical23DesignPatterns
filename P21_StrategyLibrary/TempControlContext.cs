using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_StrategyLibrary
{
    // ===== 3. 定义上下文类：管理策略，对外提供统一控制接口 =====
    public class TempControlContext
    {
        // 持有当前策略对象
        private ITempControlStrategy _currentStrategy;

        // 初始化默认策略
        public TempControlContext()
        {
            _currentStrategy = new PidControlStrategy();
        }

        // 动态切换策略
        public void SetStrategy(ITempControlStrategy newStrategy)
        {
            _currentStrategy = newStrategy;
            ConsoleBox.WriteLine("\n=== 切换温度控制策略 ===");
        }

        // 调用当前策略计算输出
        public double Control(double currentTemp, double targetTemp)
        {
            return _currentStrategy.CalculateOutput(currentTemp, targetTemp);
        }
    }

}
