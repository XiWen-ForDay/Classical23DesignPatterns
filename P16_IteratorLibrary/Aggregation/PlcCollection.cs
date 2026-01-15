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
    // 具体聚合1：PLC设备集合（用数组存储）
    public class PlcCollection : IDeviceCollection
    {
        private Device[] _plcs; // 内部用数组存储PLC

        public PlcCollection(Device[] plcs)
        {
            _plcs = plcs;
        }

        // 创建PLC专属迭代器
        public IDeviceIterator CreateIterator()
        {
            return new PlcIterator(_plcs);
        }
    }
}
