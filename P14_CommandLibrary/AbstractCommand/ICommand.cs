using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_CommandLibrary.AbstractCommand
{
    // 1. 抽象命令：定义执行和撤销的接口
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
