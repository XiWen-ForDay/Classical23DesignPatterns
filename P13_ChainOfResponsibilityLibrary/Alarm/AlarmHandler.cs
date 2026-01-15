using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ChainOfResponsibilityLibrary.Alarm
{
    // 抽象处理者：报警处理器
    public abstract class AlarmHandler
    {
        protected AlarmHandler _nextHandler;

        // 设置下一个处理者
        public void SetNextHandler(AlarmHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        // 处理报警的抽象方法
        public abstract void HandleAlarm(string alarmLevel, string message);
    }
}
