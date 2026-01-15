using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    // ===== 1. 抽象表达式：定义指令解释的接口 =====
    public abstract class IExpression
    {
        /// <summary>
        /// 解释指令，返回解析后的键值对参数
        /// </summary>
        public abstract Dictionary<string, string> Interpret(Context context);
    }
}
