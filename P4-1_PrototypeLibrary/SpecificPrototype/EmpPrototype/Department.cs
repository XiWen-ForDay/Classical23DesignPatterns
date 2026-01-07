using P4_1_PrototypeLibrary.AbstractPrototypeBase;
using P4_1_PrototypeLibrary.PrototypeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary.SpecificPrototype.EmpPrototype
{
    // 具体实现类
    public class Department : IPrototype<Department>
    {
        public string Name { get; set; }
        public string Manager { get; set; }

        public Department Clone()
        {
            return new Department
            {
                Name = this.Name,
                Manager = this.Manager
            };
        }
    }
}
