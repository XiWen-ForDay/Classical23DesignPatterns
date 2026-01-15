using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_FacadeLibrary
{
    // ===== 2. 定义外观类：封装子系统复杂逻辑，提供简化接口 =====
    public class ComputerFacade
    {
        // 持有所有子系统的引用
        private readonly CPU _cpu;
        private readonly Memory _memory;
        private readonly HardDisk _hardDisk;
        private readonly OS _os;

        // 初始化所有子系统
        public ComputerFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _hardDisk = new HardDisk();
            _os = new OS();
        }

        // 对外提供的简化接口：一键启动电脑
        public void StartComputer()
        {
            ConsoleBox.WriteLine("===== 开始启动电脑 =====");
            _cpu.PowerOn();
            _hardDisk.Read();
            _memory.Load();
            _cpu.Run();
            _os.Boot();
            _os.Login();
            ConsoleBox.WriteLine("===== 电脑启动流程结束 =====");
        }
    }

}
