using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_MementoLibrary
{
    // ===== 1. 备忘录类：存储配方的内部状态，仅允许发起人访问 =====
    /// <summary>
    /// 配方备忘录：保存配方的关键参数
    /// </summary>
    public class RecipeMemento
    {
        // 工控配方核心参数（如温度、压力、转速）
        public double Temp { get; }
        public double Pressure { get; }
        public int Speed { get; }

        // 构造函数：初始化配方参数
        public RecipeMemento(double temp, double pressure, int speed)
        {
            Temp = temp;
            Pressure = pressure;
            Speed = speed;
        }
    }
}
