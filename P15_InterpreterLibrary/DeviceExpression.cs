using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_InterpreterLibrary
{
    /// <summary>
    /// 设备表达式：解析 电机A/电机B 等设备名称
    /// </summary>
    public class DeviceExpression : IExpression
    {
        public override Dictionary<string, string> Interpret(Context context)
        {
            string[] parts = context.Input.Split('，');
            foreach (var part in parts)
            {
                if (part.Contains("电机"))
                {
                    context.Output["设备"] = part.Trim();
                    break;
                }
            }
            return context.Output;
        }
    }
}
