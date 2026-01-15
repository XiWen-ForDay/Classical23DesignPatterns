using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_FlyweightLibrary
{
    // ===== 3. 享元工厂：管理共享实例，避免重复创建 =====
    public class LightIndicatorFactory
    {
        // 缓存池：用内部状态作为key，存储共享实例
        private readonly Dictionary<string, ILightIndicator> _indicatorPool = new Dictionary<string, ILightIndicator>();

        // 获取指示灯实例：有则复用，无则新建
        public ILightIndicator GetIndicator(string color, string state)
        {
            string key = $"{state}_{color}";
            if (!_indicatorPool.ContainsKey(key))
            {
                _indicatorPool[key] = new ConcreteLightIndicator(color, state);
            }
            return _indicatorPool[key];
        }

        // 获取缓存池大小（查看创建的共享实例数量）
        public int GetPoolCount()
        {
            return _indicatorPool.Count;
        }
    }

}
