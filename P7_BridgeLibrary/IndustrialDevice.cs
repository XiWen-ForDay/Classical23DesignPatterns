using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_BridgeLibrary
{
    // 二、定义抽象层：设备抽象类（持有通信接口引用，完成桥接）
    public abstract class IndustrialDevice
    {
        // 桥接核心：持有通信方式的引用
        protected readonly ICommunication _communication;

        // 通过构造函数注入通信方式
        public IndustrialDevice(ICommunication communication)
        {
            _communication = communication;
        }

        // 设备的抽象方法：执行操作
        public abstract void ExecuteOperation(string command);
    }
}
