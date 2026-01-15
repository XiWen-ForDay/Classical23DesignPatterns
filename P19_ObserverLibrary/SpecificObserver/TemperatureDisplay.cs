using P19_ObserverLibrary.Observer;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.SpecificObserver
{
    // 4. 具体观察者1：温度显示面板
    public class TemperatureDisplay : IObserver
    {
        public void Update(float temperature)
        {
            ConsoleBox.WriteLine($"[显示面板] 实时温度更新：{temperature}℃");
        }
    }
}
