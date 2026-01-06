using P2_AbstractFactoryLibrary.FinalProduction;
using P2_AbstractFactoryLibrary.ProductionFactoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AbstractFactoryLibrary
{
    public static class ComputerAssembler
    {
        public static Computer Build(IComputerFactory factory)
        {
            return new Computer
            {
                Cpu       = factory.CreateCpu(),
                Gpu       = factory.CreateGpu(),
                Memory    = factory.CreateMemory(),
                Mainboard = factory.CreateMainboard()
            };
        }
    }
}
