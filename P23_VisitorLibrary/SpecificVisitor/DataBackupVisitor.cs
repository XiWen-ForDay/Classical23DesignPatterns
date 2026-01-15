using P23_VisitorLibrary.SpecificDevices;
using P23_VisitorLibrary.VisitorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_VisitorLibrary.SpecificVisitor
{
    // 5. 具体访问者2：数据备份访问者
    public class DataBackupVisitor : IDeviceVisitor
    {
        private string _backupPath;

        public DataBackupVisitor(string backupPath)
        {
            _backupPath = backupPath;
        }

        public void VisitPlc(PlcDevice plc)
        {
            Console.WriteLine($"=== {plc.PlcId} 数据备份 ===");
            Console.WriteLine($"1. 备份生产数据到：{_backupPath}/{plc.PlcId}_20260113.bak");
            Console.WriteLine($"2. 备份固件配置到：{_backupPath}/{plc.PlcId}_config.bak");
            Console.WriteLine($"备份完成\n");
        }

        public void VisitSensor(SensorDevice sensor)
        {
            Console.WriteLine($"=== {sensor.SensorId} 数据备份 ===");
            Console.WriteLine($"1. 备份校准数据到：{_backupPath}/{sensor.SensorId}_calib.bak");
            Console.WriteLine($"2. 备份历史采集数据到：{_backupPath}/{sensor.SensorId}_history.bak");
            Console.WriteLine($"备份完成\n");
        }

        public void VisitAlarm(AlarmDevice alarm)
        {
            Console.WriteLine($"=== {alarm.AlarmId} 数据备份 ===");
            Console.WriteLine($"1. 备份报警日志到：{_backupPath}/{alarm.AlarmId}_logs.bak");
            Console.WriteLine($"备份完成\n");
        }
    }
}
