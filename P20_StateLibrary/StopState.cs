using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_StateLibrary
{
    // ===== 2. 实现具体状态类 =====
    // 停止状态（初始状态）
    public class StopState : IMotorState
    {
        public void Start(MotorContext motor)
        {
            Console.WriteLine("【停止→运行】电机启动成功，开始运转");
            motor.SetState(new RunningState()); // 切换到运行状态
        }

        public void Stop(MotorContext motor)
        {
            Console.WriteLine("【停止状态】电机已停止，无需重复操作");
        }

        public void Fault(MotorContext motor)
        {
            Console.WriteLine("【停止→故障】电机异常，进入故障状态");
            motor.SetState(new FaultState()); // 切换到故障状态
        }

        public string GetStateName() => "停止状态";
    }

}
