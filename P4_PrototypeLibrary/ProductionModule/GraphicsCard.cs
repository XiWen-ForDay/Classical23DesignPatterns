using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PrototypeLibrary.ProductionModule
{
    [Serializable]
    public class GraphicsCard
    {
        public string Type { get; set; }
        public override string ToString() => $"显卡: {Type}";
    }
}
