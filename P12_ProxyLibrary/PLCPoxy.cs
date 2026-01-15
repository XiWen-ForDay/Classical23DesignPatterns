using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_ProxyLibrary
{
    // ===== 3. PLC代理类：控制对真实PLC的访问，附加增强功能 =====
    public class PLCProxy : IPLCControl
    {
        // 持有真实PLC对象的引用
        private readonly IPLCControl _realPLC;
        // 模拟操作权限
        private readonly string _userRole;

        // 构造函数：传入真实PLC和用户角色
        public PLCProxy(IPLCControl realPLC, string userRole)
        {
            _realPLC = realPLC;
            _userRole = userRole;
        }

        public int ReadRegister(int registerAddress)
        {
            // 增强功能1：权限校验
            if (!CheckReadPermission())
            {
                Console.WriteLine($"[PLC代理] 权限不足！{_userRole} 无法读取PLC数据");
                return -1;
            }

            // 增强功能2：记录操作日志
            Console.WriteLine($"[PLC代理] 记录日志：{_userRole} 读取寄存器 {registerAddress}");

            try
            {
                // 调用真实PLC的方法
                return _realPLC.ReadRegister(registerAddress);
            }
            catch (Exception ex)
            {
                // 增强功能3：异常重试（简化版）
                Console.WriteLine($"[PLC代理] 读取失败，重试一次：{ex.Message}");
                return _realPLC.ReadRegister(registerAddress);
            }
        }

        public bool WriteRegister(int registerAddress, int value)
        {
            // 增强功能1：权限校验（写入权限比读取更严格）
            if (!CheckWritePermission())
            {
                Console.WriteLine($"[PLC代理] 权限不足！{_userRole} 无法写入PLC数据");
                return false;
            }

            // 增强功能2：记录操作日志
            Console.WriteLine($"[PLC代理] 记录日志：{_userRole} 向寄存器 {registerAddress} 写入 {value}");

            try
            {
                return _realPLC.WriteRegister(registerAddress, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[PLC代理] 写入失败：{ex.Message}");
                return false;
            }
        }

        // 私有方法：检查读取权限
        private bool CheckReadPermission()
        {
            return _userRole == "工程师" || _userRole == "操作员";
        }

        // 私有方法：检查写入权限
        private bool CheckWritePermission()
        {
            return _userRole == "工程师";
        }
    }
}
