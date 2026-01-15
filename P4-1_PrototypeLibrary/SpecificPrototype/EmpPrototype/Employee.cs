using P4_1_PrototypeLibrary.AbstractPrototypeBase;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary.SpecificPrototype.EmpPrototype
{
    // 3. 具体实现
    public class Employee : PrototypeBase<Employee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; }

        public Employee()
        {
            Skills = new List<Skill>();
        }

        public override Employee Clone()
        {
            return new Employee
            {
                Name = this.Name,
                Age = this.Age,
                Department = this.Department?.Clone(),
                Skills = this.Skills?.ConvertAll(s => s.Clone())
            };
        }

        // 添加一个显示信息的方法便于测试
        public void DisplayInfo()
        {
            ConsoleBox.WriteLine($"Name: {Name}, Age: {Age}");
            ConsoleBox.WriteLine($"Department: {Department?.Name} (Manager: {Department?.Manager})");
            ConsoleBox.WriteLine("Skills:");
            foreach (var skill in Skills)
            {
                ConsoleBox.WriteLine($"  - {skill.Name} (Level: {skill.Level})");
            }
        }
    }
}
