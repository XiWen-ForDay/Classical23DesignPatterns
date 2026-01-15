using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_StateLibrary
{
    // 故障状态
    public class FaultState : IMotorState
    {
        public void Start(MotorContext motor)
        {
            ConsoleBox.WriteLine("【故障状态】电机故障未复位，无法启动");
        }

        public void Stop(MotorContext motor)
        {
            ConsoleBox.WriteLine("【故障状态】电机已故障，停止指令无效");
        }

        public void Fault(MotorContext motor)
        {
            ConsoleBox.WriteLine("【故障状态】电机已故障，无需重复触发");
        }

        public string GetStateName() => "故障状态";
    }

}
