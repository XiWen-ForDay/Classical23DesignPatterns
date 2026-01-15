using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_StateLibrary
{
    // ===== 3. 定义上下文类：电机本体，持有当前状态并提供对外接口 =====
    public class MotorContext
    {
        private IMotorState _currentState;

        // 初始化电机为停止状态
        public MotorContext()
        {
            _currentState = new StopState();
            Console.WriteLine($"电机初始化完成，当前状态：{_currentState.GetStateName()}");
        }

        // 切换状态的核心方法
        public void SetState(IMotorState newState)
        {
            _currentState = newState;
        }

        // 对外暴露的操作指令（上位机调用）
        public void StartMotor() => _currentState.Start(this);
        public void StopMotor() => _currentState.Stop(this);
        public void TriggerFault() => _currentState.Fault(this);
        public string GetCurrentState() => _currentState.GetStateName();
    }
}
