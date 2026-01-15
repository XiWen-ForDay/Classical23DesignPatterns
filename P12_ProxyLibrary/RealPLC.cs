using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_ProxyLibrary
{
    // ===== 2. 真实PLC类：负责核心的硬件操作 =====
    public class RealPLC : IPLCControl
    {
        // 模拟真实PLC的寄存器数据存储
        private readonly int[] _registers = new int[100];

        public int ReadRegister(int registerAddress)
        {
            // 模拟远程PLC的读取延迟
            System.Threading.Thread.Sleep(100);
            Console.WriteLine($"[真实PLC] 读取地址 {registerAddress} 的数据");
            return _registers[registerAddress];
        }

        public bool WriteRegister(int registerAddress, int value)
        {
            // 模拟远程PLC的写入延迟
            System.Threading.Thread.Sleep(100);
            Console.WriteLine($"[真实PLC] 向地址 {registerAddress} 写入数据 {value}");
            _registers[registerAddress] = value;
            return true;
        }
    }
}
