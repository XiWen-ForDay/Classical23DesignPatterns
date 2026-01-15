using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_FlyweightLibrary
{
    // ===== 1. 定义享元接口：规范指示灯行为 =====
    public interface ILightIndicator
    {
        // 显示指示灯：传入外部状态（设备编号、位置）
        void Display(string deviceId, string position);
        // 获取内部状态（颜色+状态）
        string GetInnerState();
    }
}
