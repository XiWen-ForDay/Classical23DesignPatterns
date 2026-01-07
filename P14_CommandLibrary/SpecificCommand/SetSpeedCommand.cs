using P14_CommandLibrary.AbstractCommand;
using P14_CommandLibrary.CommandReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary.SpecificCommand
{
    // 5. 具体命令3：调整速度命令
    public class SetSpeedCommand : ICommand
    {
        private IndustrialDevice _device;
        private int _targetSpeed;
        private int _prevSpeed; // 记录上一次速度，用于撤销

        public SetSpeedCommand(IndustrialDevice device, int targetSpeed)
        {
            _device = device;
            _targetSpeed = targetSpeed;
        }

        public void Execute()
        {
            _prevSpeed = _device.GetType().GetField("_speed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(_device) is int speed ? speed : 0;
            _device.SetSpeed(_targetSpeed);
        }

        public void Undo()
        {
            _device.SetSpeed(_prevSpeed);
        }
    }
}
