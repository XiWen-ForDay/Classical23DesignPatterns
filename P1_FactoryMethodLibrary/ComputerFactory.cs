using P1_FactoryMethodLibrary.FinalProduction;
using P1_FactoryMethodLibrary.SpecificModuleType.Cpu;
using P1_FactoryMethodLibrary.SpecificModuleType.Gpu;
using P1_FactoryMethodLibrary.SpecificModuleType.Mainboard;
using P1_FactoryMethodLibrary.SpecificModuleType.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_FactoryMethodLibrary
{
    public enum ComputerType
    {
        Game,   // 游戏型
        Office  // 办公型
    }

    public static class ComputerFactory
    {
        public static Computer Create(ComputerType type)
        {
            Computer pc = new Computer();

            switch (type)
            {
                case ComputerType.Game:
                    pc.Cpu       = new IntelCpu();
                    pc.Gpu       = new NvidiaGpu();
                    pc.Memory    = new CorsairMemory();
                    pc.Mainboard = new MsiMainboard();
                    break;

                case ComputerType.Office:
                    pc.Cpu       = new AmdCpu();
                    pc.Gpu       = new AmdGpu();      // 核显也行
                    pc.Memory    = new KingstonMemory();
                    pc.Mainboard = new AsusMainboard();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            return pc;
        }
    }
}
