using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_MementoLibrary
{
    // ===== 2. 发起人：配方对象，负责创建和恢复备忘录 =====
    /// <summary>
    /// 配方类：工控生产的核心参数配置
    /// </summary>
    public class RecipeOriginator
    {
        // 配方参数（内部状态）
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public int Speed { get; set; }

        // 保存当前状态到备忘录
        public RecipeMemento SaveToMemento()
        {
            ConsoleBox.WriteLine($"[配方保存] 温度：{Temp}℃ | 压力：{Pressure}MPa | 转速：{Speed}r/min");
            return new RecipeMemento(Temp, Pressure, Speed);
        }

        // 从备忘录恢复状态
        public void RestoreFromMemento(RecipeMemento memento)
        {
            Temp = memento.Temp;
            Pressure = memento.Pressure;
            Speed = memento.Speed;
            ConsoleBox.WriteLine($"[配方恢复] 温度：{Temp}℃ | 压力：{Pressure}MPa | 转速：{Speed}r/min");
        }

        // 显示当前配方参数
        public void ShowRecipe()
        {
            ConsoleBox.WriteLine($"[当前配方] 温度：{Temp}℃ | 压力：{Pressure}MPa | 转速：{Speed}r/min");
        }
    }
}
