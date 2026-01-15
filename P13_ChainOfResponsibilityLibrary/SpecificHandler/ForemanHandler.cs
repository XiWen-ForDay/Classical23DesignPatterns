using P13_ChainOfResponsibilityLibrary.Alarm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ChainOfResponsibilityLibrary.SpecificHandler
{
    // 具体处理者2：班长（处理严重报警）
    public class ForemanHandler : AlarmHandler
    {
        public override void HandleAlarm(string alarmLevel, string message)
        {
            if (alarmLevel == "严重")
            {
                Console.WriteLine($"班长处理报警：{message}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleAlarm(alarmLevel, message);
            }
        }
    }
}
