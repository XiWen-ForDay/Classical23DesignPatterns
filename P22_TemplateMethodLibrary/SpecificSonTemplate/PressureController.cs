using P22_TemplateMethodLibrary.AbstractTemplate;
using ShowRichBoxToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_TemplateMethodLibrary.SpecificSonTemplate
{
    // 具体子类2：压力控制器
    public class PressureController : DeviceControlTemplate
    {
        private const float _normalMaxPressure = 1.2f; // 正常压力上限(MPa)
        private string _plcAddress;

        public PressureController(string plcAddress)
        {
            _plcAddress = plcAddress;
        }

        // 采集压力数据
        protected override float CollectData()
        {
            ConsoleBox.WriteLine($"2. 采集{_plcAddress}压力数据");
            // 模拟从PLC读取压力
            return (float)(new Random().NextDouble() * 0.8 + 0.6); // 0.6-1.4MPa
        }

        // 处理压力数据：判断是否超过上限
        protected override bool ProcessData(float data)
        {
            ConsoleBox.WriteLine($"3. 处理压力数据：阈值={_normalMaxPressure}MPa");
            return data > _normalMaxPressure;
        }

        // 执行压力控制：异常则泄压
        protected override void ExecuteControl(bool isAbnormal, float data)
        {
            ConsoleBox.WriteLine("4. 执行压力控制：");
            if (isAbnormal)
            {
                ConsoleBox.WriteLine($"   压力过高({data}MPa)，发送指令至PLC打开泄压阀");
            }
            else
            {
                ConsoleBox.WriteLine($"   压力正常({data}MPa)，无需操作");
            }
        }
    }

}
