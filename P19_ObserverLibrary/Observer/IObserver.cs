using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_ObserverLibrary.Observer
{
    // 1. 抽象观察者：定义接收通知的接口
    public interface IObserver
    {
        void Update(float temperature);
    }
}
