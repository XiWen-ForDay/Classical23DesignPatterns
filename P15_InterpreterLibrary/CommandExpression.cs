using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    // ===== 4. 非终结符表达式：组合多个终结符表达式完成整体解析 =====
    public class CommandExpression : IExpression
    {
        // 存储所有原子表达式
        private readonly List<IExpression> _expressions = new List<IExpression>()
        {
            new ActionExpression(),
            new DeviceExpression(),
            new SpeedExpression(),
            new TimeExpression()
        };

        public override Dictionary<string, string> Interpret(Context context)
        {
            // 依次执行每个原子表达式的解析
            foreach (var expr in _expressions)
            {
                expr.Interpret(context);
            }
            return context.Output;
        }
    }
}
