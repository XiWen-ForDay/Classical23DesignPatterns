using P23_VisitorLibrary.VisitorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.DeviceElementInterface
{
    // 2. 定义设备元素接口（接受访问者）
    public interface IDeviceElement
    {
        void Accept(IDeviceVisitor visitor); // 接受访问者的访问
    }
}
