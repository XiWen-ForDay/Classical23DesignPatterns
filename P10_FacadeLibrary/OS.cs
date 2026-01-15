using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_FacadeLibrary
{
    // 操作系统子系统
    public class OS
    {
        public void Boot()
        {
            Console.WriteLine("操作系统 启动中，加载驱动与服务");
        }

        public void Login()
        {
            Console.WriteLine("操作系统 启动完成，请登录");
        }
    }

}
