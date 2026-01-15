using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_AdapterLibrary
{
    // ===== 3. 适配器：将旧传感器接口转换成目标接口 =====
    public class TemperatureSensorAdapter : ITemperatureSensor
    {
        // 持有旧传感器的引用
        private readonly SerialTemperatureSensor _oldSensor;

        // 通过构造函数注入旧传感器
        public TemperatureSensorAdapter(SerialTemperatureSensor oldSensor)
        {
            _oldSensor = oldSensor;
        }

        // 实现目标接口方法，完成格式转换
        public float GetTemperature()
        {
            // 1. 调用旧传感器获取原始字符串数据
            string rawData = _oldSensor.GetRawTemperatureData();
            // 2. 处理数据：去掉℃单位，转换为浮点数
            string tempStr = rawData.Replace("℃", "");
            if (float.TryParse(tempStr, out float temperature))
            {
                return temperature;
            }
            // 转换失败返回默认值
            return 0.0f;
        }
    }

}
