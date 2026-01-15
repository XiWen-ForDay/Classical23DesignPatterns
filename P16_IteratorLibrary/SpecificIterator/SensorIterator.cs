using P16_IteratorLibrary.BaseDevice;
using P16_IteratorLibrary.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.SpecificIterator
{
    // 具体迭代器2：传感器迭代器
    public class SensorIterator : IDeviceIterator
    {
        private LinkedList<Device> _sensors;
        private LinkedListNode<Device> _currentNode; // 当前遍历节点

        public SensorIterator(LinkedList<Device> sensors)
        {
            _sensors = sensors;
            _currentNode = _sensors.First; // 从链表头开始遍历
        }

        public bool HasNext()
        {
            return _currentNode != null;
        }

        public Device Next()
        {
            if (HasNext())
            {
                Device currentDevice = _currentNode.Value;
                _currentNode = _currentNode.Next; // 移动到下一个节点
                return currentDevice;
            }
            return null;
        }
    }
}
