using P14_CommandLibrary.AbstractCommand;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary
{
    // 6. 调用者：发送命令的对象（比如上位机按钮、指令面板）
    public class CommandInvoker
    {
        private ICommand _currentCommand;
        private Stack<ICommand> _commandHistory = new Stack<ICommand>(); // 命令历史栈，用于撤销

        // 设置并执行命令
        public void SetCommand(ICommand command)
        {
            _currentCommand = command;
            _currentCommand.Execute();
            _commandHistory.Push(_currentCommand);
        }

        // 撤销上一次命令
        public void UndoLastCommand()
        {
            if (_commandHistory.Count > 0)
            {
                var lastCmd = _commandHistory.Pop();
                lastCmd.Undo();
                ConsoleBox.WriteLine($"已撤销上一次操作");
            }
            else
            {
                ConsoleBox.WriteLine("暂无可撤销的命令");
            }
        }
    }

}
