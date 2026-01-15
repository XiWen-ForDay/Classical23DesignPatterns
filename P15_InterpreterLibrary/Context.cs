using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    // ===== 2. 环境类：存储指令上下文和解析结果 =====
    public class Context
    {
        // 待解析的原始指令
        public string Input { get; set; }
        // 解析后的指令参数
        public Dictionary<string, string> Output { get; set; } = new Dictionary<string, string>();

        public Context(string input)
        {
            Input = input;
            Console.WriteLine($"[原始指令] {input}");
        }
    }
}
