using P14_CommandLibrary.AbstractCommand;
using P14_CommandLibrary.CommandReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary.SpecificCommand
{
    // 4. 具体命令2：停止设备命令
    public class StopDeviceCommand : ICommand
    {
        private IndustrialDevice _device;

        public StopDeviceCommand(IndustrialDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.Stop();
        }

        public void Undo()
        {
            _device.Start();
        }
    }

}
