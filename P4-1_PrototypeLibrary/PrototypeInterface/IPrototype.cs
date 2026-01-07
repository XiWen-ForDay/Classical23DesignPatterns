using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary.PrototypeInterface
{
    // 1. 定义明确的接口
    public interface IPrototype<out T>
    {
        T Clone();
    }
}
