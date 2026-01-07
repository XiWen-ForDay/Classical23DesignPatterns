using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PrototypeLibrary.ProductionModule
{
    [Serializable]
    public class HardDisk
    {
        public string Capacity { get; set; }
        public override string ToString() => $"硬盘: {Capacity}";
    }
}
