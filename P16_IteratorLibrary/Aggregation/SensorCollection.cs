using P16_IteratorLibrary.BaseDevice;
using P16_IteratorLibrary.BaseInterface;
using P16_IteratorLibrary.SpecificIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.Aggregation
{
    // 具体聚合2：传感器集合（用链表存储）
    public class SensorCollection : IDeviceCollection
    {
        private LinkedList<Device> _sensors; // 内部用链表存储传感器

        public SensorCollection(LinkedList<Device> sensors)
        {
            _sensors = sensors;
        }

        // 创建传感器专属迭代器
        public IDeviceIterator CreateIterator()
        {
            return new SensorIterator(_sensors);
        }
    }
}
