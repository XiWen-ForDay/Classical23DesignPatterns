using P22_TemplateMethodLibrary.AbstractTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_TemplateMethodLibrary.SpecificSonTemplate
{
    // 具体子类1：温度控制器
    public class TemperatureController : DeviceControlTemplate
    {
        private const float _normalMaxTemp = 50.0f; // 正常温度上限
        private string _plcAddress;

        public TemperatureController(string plcAddress)
        {
            _plcAddress = plcAddress;
        }

        // 采集温度数据
        protected override float CollectData()
        {
            Console.WriteLine($"2. 采集{_plcAddress}温度数据");
            // 模拟从PLC读取温度
            return (float)(new Random().NextDouble() * 30 + 30); // 30-60℃
        }

        // 处理温度数据：判断是否超过上限
        protected override bool ProcessData(float data)
        {
            Console.WriteLine($"3. 处理温度数据：阈值={_normalMaxTemp}℃");
            return data > _normalMaxTemp;
        }

        // 执行温度控制：异常则启动风扇
        protected override void ExecuteControl(bool isAbnormal, float data)
        {
            Console.WriteLine("4. 执行温度控制：");
            if (isAbnormal)
            {
                Console.WriteLine($"   温度过高({data}℃)，发送指令至PLC启动风扇降温");
            }
            else
            {
                Console.WriteLine($"   温度正常({data}℃)，无需操作");
            }
        }
    }

}
