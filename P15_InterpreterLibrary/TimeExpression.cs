using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    /// <summary>
    /// 时间表达式：解析 持续xxx分钟
    /// </summary>
    public class TimeExpression : IExpression
    {
        public override Dictionary<string, string> Interpret(Context context)
        {
            string[] parts = context.Input.Split('，');
            foreach (var part in parts)
            {
                if (part.Contains("持续"))
                {
                    string time = part.Replace("持续", "").Replace("分钟", "").Trim();
                    context.Output["持续时间"] = time;
                    break;
                }
            }
            return context.Output;
        }
    }
}
