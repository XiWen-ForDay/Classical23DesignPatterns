using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_StateLibrary
{
    // 运行状态
    public class RunningState : IMotorState
    {
        public void Start(MotorContext motor)
        {
            Console.WriteLine("【运行状态】电机已在运转，启动指令无效");
        }

        public void Stop(MotorContext motor)
        {
            Console.WriteLine("【运行→停止】电机停止运转");
            motor.SetState(new StopState()); // 切换到停止状态
        }

        public void Fault(MotorContext motor)
        {
            Console.WriteLine("【运行→故障】电机运行中异常，进入故障状态");
            motor.SetState(new FaultState()); // 切换到故障状态
        }

        public string GetStateName() => "运行状态";
    }
}
