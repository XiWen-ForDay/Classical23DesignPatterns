using P16_IteratorLibrary.BaseDevice;
using P16_IteratorLibrary.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_IteratorLibrary.SpecificIterator
{
    // 具体迭代器1：PLC迭代器
    public class PlcIterator : IDeviceIterator
    {
        private Device[] _plcs;
        private int _currentIndex = 0; // 当前遍历位置

        public PlcIterator(Device[] plcs)
        {
            _plcs = plcs;
        }

        public bool HasNext()
        {
            return _currentIndex < _plcs.Length;
        }

        public Device Next()
        {
            if (HasNext())
            {
                return _plcs[_currentIndex++];
            }
            return null;
        }
    }
}
