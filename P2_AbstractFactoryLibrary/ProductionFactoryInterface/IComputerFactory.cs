using P2_AbstractFactoryLibrary.ProductionModuleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AbstractFactoryLibrary.ProductionFactoryInterface
{
    public interface IComputerFactory
    {
        Cpu CreateCpu();
        Gpu CreateGpu();
        Memory CreateMemory();
        Mainboard CreateMainboard();
    }
}
