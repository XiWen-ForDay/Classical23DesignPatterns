using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_FlyweightLibrary
{
    // ===== 2. 具体享元类：实现指示灯，封装内部共享状态 =====
    public class ConcreteLightIndicator : ILightIndicator
    {
        // 内部状态：可共享，不随设备变化（颜色、状态类型）
        private readonly string _color;
        private readonly string _state; // 运行/停止/故障

        // 构造函数：初始化内部状态
        public ConcreteLightIndicator(string color, string state)
        {
            _color = color;
            _state = state;
            Console.WriteLine($"创建共享指示灯实例：【{_state}】- 颜色{_color}");
        }

        public void Display(string deviceId, string position)
        {
            Console.WriteLine($"设备【{deviceId}】-{position} 指示灯：{_state}({_color})");
        }

        public string GetInnerState()
        {
            return $"{_state}_{_color}";
        }
    }
}
