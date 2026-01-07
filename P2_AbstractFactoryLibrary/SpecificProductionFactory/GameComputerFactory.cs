using P2_AbstractFactoryLibrary.ProductionFactoryInterface;
using P2_AbstractFactoryLibrary.ProductionModuleBase;
using P2_AbstractFactoryLibrary.SpecificModuleType.Cpu;
using P2_AbstractFactoryLibrary.SpecificModuleType.Gpu;
using P2_AbstractFactoryLibrary.SpecificModuleType.Mainboard;
using P2_AbstractFactoryLibrary.SpecificModuleType.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AbstractFactoryLibrary.SpecificProductionFactory
{
    /* 游戏型工厂 */
    public class GameComputerFactory : IComputerFactory
    {
        public Cpu CreateCpu() => new IntelCpu();
        public Gpu CreateGpu() => new NvidiaGpu();
        public Memory CreateMemory() => new CorsairMemory();
        public Mainboard CreateMainboard() => new MsiMainboard();
    }
}
