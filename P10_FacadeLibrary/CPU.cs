using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_FacadeLibrary
{
    // ===== 1. 定义子系统类：各自负责核心功能，互不依赖 =====
    // CPU子系统
    public class CPU
    {
        public void PowerOn()
        {
            Console.WriteLine("CPU 通电，开始自检...");
        }

        public void Run()
        {
            Console.WriteLine("CPU 加载指令集，准备工作");
        }
    }
}
