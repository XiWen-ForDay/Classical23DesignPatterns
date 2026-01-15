using P4_PrototypeLibrary.ProductionModule;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace P4_PrototypeLibrary.FinalProduction
{
    // 电脑原型类：实现 ICloneable 接口
    [Serializable]
    public class Computer : ICloneable
    {
        public CPU Cpu { get; set; }
        public Memory Memory { get; set; }
        public HardDisk HardDisk { get; set; }
        public GraphicsCard GraphicsCard { get; set; }

        // 浅拷贝（值类型复制，引用类型共享）
        public object Clone()
        {
            // 深拷贝：通过序列化实现，避免引用类型共享
            using (var ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return formatter.Deserialize(ms);
            }
        }

        // 显示电脑配置
        public void ShowInfo()
        {
            ConsoleBox.WriteLine(Cpu.ToString());
            ConsoleBox.WriteLine(Memory.ToString());
            ConsoleBox.WriteLine(HardDisk.ToString());
            ConsoleBox.WriteLine(GraphicsCard.ToString());
        }
    }

}
