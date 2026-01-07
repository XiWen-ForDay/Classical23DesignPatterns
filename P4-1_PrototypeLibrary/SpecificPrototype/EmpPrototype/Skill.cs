using P4_1_PrototypeLibrary.AbstractPrototypeBase;
using P4_1_PrototypeLibrary.PrototypeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary.SpecificPrototype.EmpPrototype
{
    public class Skill : IPrototype<Skill>
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Skill Clone()
        {
            return new Skill
            {
                Name = this.Name,
                Level = this.Level
            };
        }
    }
}
