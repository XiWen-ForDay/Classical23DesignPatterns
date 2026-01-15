using P19_ObserverLibrary.Observer;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.SpecificObserver
{
    // 6. 具体观察者3：历史数据记录模块
    public class TemperatureRecorder : IObserver
    {
        public void Update(float temperature)
        {
            // 模拟保存到数据库或日志文件
            string time = DateTime.Now.ToString("HH:mm:ss");
            ConsoleBox.WriteLine($"[记录模块] 保存数据 - 时间：{time}，温度：{temperature}℃");
        }
    }
}
