using P13_ChainOfResponsibilityLibrary.Alarm;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ChainOfResponsibilityLibrary.SpecificHandler
{
    // 具体处理者1：现场操作员（处理普通报警）
    public class OperatorHandler : AlarmHandler
    {
        public override void HandleAlarm(string alarmLevel, string message)
        {
            if (alarmLevel == "普通")
            {
                ConsoleBox.WriteLine($"操作员处理报警：{message}");
            }
            else if (_nextHandler != null)
            {
                // 自己处理不了，传给下一个
                _nextHandler.HandleAlarm(alarmLevel, message);
            }
        }
    }
}
