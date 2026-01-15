using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_StateLibrary
{
    // ===== 1. 定义状态接口：规范电机所有状态的行为 =====
    public interface IMotorState
    {
        void Start(MotorContext motor);   // 处理启动指令
        void Stop(MotorContext motor);    // 处理停止指令
        void Fault(MotorContext motor);   // 处理故障指令
        string GetStateName();            // 获取当前状态名称
    }

}
