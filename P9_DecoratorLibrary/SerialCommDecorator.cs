using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_DecoratorLibrary
{
    // 3. 抽象装饰器：串口通信装饰基类（持有核心通信对象）
    public abstract class SerialCommDecorator : ISerialComm
    {
        protected readonly ISerialComm _serialComm;

        public SerialCommDecorator(ISerialComm serialComm)
        {
            _serialComm = serialComm;
        }

        // 子类可重写扩展
        public virtual bool SendData(byte[] data)
        {
            return _serialComm.SendData(data);
        }

        // 子类可重写扩展
        public virtual byte[] ReceiveData()
        {
            return _serialComm.ReceiveData();
        }

        // 子类可重写扩展
        public virtual string GetCommDescription()
        {
            return _serialComm.GetCommDescription();
        }
    }

}
