using P14_CommandLibrary.AbstractCommand;
using P14_CommandLibrary.CommandReceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary.SpecificCommand
{
    // 3. 具体命令1：启动设备命令
    public class StartDeviceCommand : ICommand
    {
        private IndustrialDevice _device;

        public StartDeviceCommand(IndustrialDevice device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.Start();
        }

        public void Undo()
        {
            _device.Stop();
        }
    }

}
