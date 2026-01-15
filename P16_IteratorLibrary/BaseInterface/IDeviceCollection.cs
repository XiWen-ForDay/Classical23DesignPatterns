using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.BaseInterface
{
    // 抽象聚合接口（定义创建迭代器的方法）
    public interface IDeviceCollection
    {
        IDeviceIterator CreateIterator(); // 创建迭代器
    }
}
