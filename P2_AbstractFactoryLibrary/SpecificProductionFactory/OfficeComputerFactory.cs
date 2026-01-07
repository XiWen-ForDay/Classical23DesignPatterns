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
    /* 办公型工厂 */
    public class OfficeComputerFactory : IComputerFactory
    {
        public Cpu CreateCpu() => new AmdCpu();
        public Gpu CreateGpu() => new AmdGpu();
        public Memory CreateMemory() => new KingstonMemory();
        public Mainboard CreateMainboard() => new AsusMainboard();
    }
}
