using P4_1_PrototypeLibrary.PrototypeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary.AbstractPrototypeBase
{
    // 2. 使用泛型确保类型安全
    public abstract class PrototypeBase<T> : IPrototype<T> where T : class
    {
        public abstract T Clone();

        // 提供通用的深拷贝方法
        protected T DeepCopyViaJson()
        {
            return JsonSerializer.Deserialize<T>(
                JsonSerializer.Serialize(this)
            );
        }
    }
}
