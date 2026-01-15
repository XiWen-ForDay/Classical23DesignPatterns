using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    /// <summary>
    /// 转速表达式：解析 转速xxx转
    /// </summary>
    public class SpeedExpression : IExpression
    {
        public override Dictionary<string, string> Interpret(Context context)
        {
            string[] parts = context.Input.Split('，');
            foreach (var part in parts)
            {
                if (part.Contains("转速"))
                {
                    string speed = part.Replace("转速", "").Replace("转", "").Trim();
                    context.Output["转速"] = speed;
                    break;
                }
            }
            return context.Output;
        }
    }

}
