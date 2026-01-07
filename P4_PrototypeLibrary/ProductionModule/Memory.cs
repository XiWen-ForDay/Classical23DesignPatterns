using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PrototypeLibrary.ProductionModule
{
    [Serializable]
    public class Memory
    {
        public string Spec { get; set; }
        public override string ToString() => $"内存: {Spec}";
    }

}
