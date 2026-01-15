using P13_ChainOfResponsibilityLibrary.Alarm;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ChainOfResponsibilityLibrary.SpecificHandler
{
    // 具体处理者3：主管（处理紧急报警）
    public class SupervisorHandler : AlarmHandler
    {
        public override void HandleAlarm(string alarmLevel, string message)
        {
            if (alarmLevel == "紧急")
            {
                ConsoleBox.WriteLine($"主管处理报警：{message}");
            }
            else
            {
                ConsoleBox.WriteLine($"无人处理报警：{message}");
            }
        }
    }
}
