using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PrototypeLibrary.ProductionModule
{
    // 标记为可序列化，支持深拷贝
    [Serializable]
    public class CPU
    {
        public string Model { get; set; }
        public override string ToString() => $"CPU: {Model}";
    }
}
