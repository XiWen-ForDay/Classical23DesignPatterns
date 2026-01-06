using P2_AbstractFactoryLibrary.ProductionFactoryInterface;
using P2_AbstractFactoryLibrary.ProductionModuleBase;
using P2_AbstractFactoryLibrary.SpecificType.Cpu;
using P2_AbstractFactoryLibrary.SpecificType.Gpu;
using P2_AbstractFactoryLibrary.SpecificType.Mainboard;
using P2_AbstractFactoryLibrary.SpecificType.Memory;
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
