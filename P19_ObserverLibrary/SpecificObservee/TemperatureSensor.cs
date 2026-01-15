using P19_ObserverLibrary.Observee;
using P19_ObserverLibrary.Observer;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.SpecificObservee
{
    // 3. 具体被观察者：温度传感器
    public class TemperatureSensor : IObservable
    {
        // 存储所有订阅的观察者
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _currentTemperature;

        // 模拟传感器采集温度数据
        public void CollectTemperature()
        {
            // 这里模拟随机温度变化，实际项目中是读取硬件数据
            Random random = new Random();
            _currentTemperature = (float)Math.Round(random.Next(20, 50) + random.NextDouble(), 1);
            ConsoleBox.WriteLine($"[传感器] 当前采集温度：{_currentTemperature}℃");

            // 温度变化时通知所有观察者
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_currentTemperature);
            }
        }
    }

}
