using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_ProxyLibrary
{
    // ===== 1. 定义PLC操作接口：规范读写行为 =====
    public interface IPLCControl
    {
        // 读取PLC寄存器数据
        int ReadRegister(int registerAddress);
        // 写入数据到PLC寄存器
        bool WriteRegister(int registerAddress, int value);
    }
}
