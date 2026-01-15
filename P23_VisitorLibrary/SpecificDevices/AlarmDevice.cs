using P23_VisitorLibrary.DeviceElementInterface;
using P23_VisitorLibrary.VisitorInterface;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.SpecificDevices
{
    // 报警器设备
    public class AlarmDevice : IDeviceElement
    {
        public string AlarmId { get; set; }
        public bool IsActive { get; set; }

        public AlarmDevice(string alarmId, bool isActive)
        {
            AlarmId = alarmId;
            IsActive = isActive;
        }

        public void Accept(IDeviceVisitor visitor)
        {
            visitor.VisitAlarm(this);
        }

        // 报警器自身的基础方法（无需修改）
        public void TriggerAlarm() => ConsoleBox.WriteLine($"{AlarmId} 触发声光警报");
    }
}
