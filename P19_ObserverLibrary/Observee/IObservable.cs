using P19_ObserverLibrary.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.Observee
{
    // 2. 抽象被观察者：定义订阅、取消订阅和通知的接口
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
