using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_MementoLibrary
{
    // ===== 3. 管理者：负责管理所有备忘录，不修改备忘录内容 =====
    /// <summary>
    /// 配方管理器：保存多个配方备忘录，支持多版本切换
    /// </summary>
    public class RecipeCaretaker
    {
        // 存储多个配方备忘录（key：配方名称，value：对应备忘录）
        private readonly Dictionary<string, RecipeMemento> _recipeMementos = new Dictionary<string, RecipeMemento>();

        // 添加备忘录
        public void AddMemento(string recipeName, RecipeMemento memento)
        {
            if (_recipeMementos.ContainsKey(recipeName))
            {
                _recipeMementos[recipeName] = memento;
                ConsoleBox.WriteLine($"配方【{recipeName}】已更新");
            }
            else
            {
                _recipeMementos.Add(recipeName, memento);
                ConsoleBox.WriteLine($"配方【{recipeName}】已保存");
            }
        }

        // 获取备忘录
        public RecipeMemento GetMemento(string recipeName)
        {
            return _recipeMementos.TryGetValue(recipeName, out var memento) ? memento : null;
        }
    }
}
