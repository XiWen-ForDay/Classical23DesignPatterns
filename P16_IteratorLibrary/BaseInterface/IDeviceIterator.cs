using P16_IteratorLibrary.BaseDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.BaseInterface
{
    // 抽象迭代器接口（统一遍历方法）
    public interface IDeviceIterator
    {
        bool HasNext(); // 判断是否还有下一个设备
        Device Next();  // 获取下一个设备
    }
}
