using P19_ObserverLibrary.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.SpecificObserver
{
    // 5. 具体观察者2：温度报警模块
    public class TemperatureAlarm : IObserver
    {
        // 报警阈值
        private const float _alarmThreshold = 40.0f;

        public void Update(float temperature)
        {
            if (temperature >= _alarmThreshold)
            {
                Console.WriteLine($"[报警模块] 警告！温度过高：{temperature}℃，超过阈值{_alarmThreshold}℃");
            }
        }
    }
}
