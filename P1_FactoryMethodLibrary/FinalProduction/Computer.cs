using P1_FactoryMethodLibrary.ProductionModuleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_FactoryMethodLibrary.FinalProduction
{
    public class Computer
    {
        public Cpu Cpu { get; set; }
        public Gpu Gpu { get; set; }
        public Memory Memory { get; set; }
        public Mainboard Mainboard { get; set; }

        public void ShowConfig()
        {
            Console.WriteLine($"整机配置：" +
                              $"{Cpu.GetType().Name} / " +
                              $"{Gpu.GetType().Name} / " +
                              $"{Memory.GetType().Name} / " +
                              $"{Mainboard.GetType().Name}");
        }
    }
}
