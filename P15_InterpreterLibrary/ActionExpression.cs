using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    // ===== 3. 终结符表达式：解析单个原子指令（动作、设备、转速、时间）=====
    /// <summary>
    /// 动作表达式：解析 启动/停止
    /// </summary>
    public class ActionExpression : IExpression
    {
        public override Dictionary<string, string> Interpret(Context context)
        {
            if (context.Input.Contains("启动"))
            {
                context.Output["动作"] = "启动";
            }
            else if (context.Input.Contains("停止"))
            {
                context.Output["动作"] = "停止";
            }
            return context.Output;
        }
    }

}
