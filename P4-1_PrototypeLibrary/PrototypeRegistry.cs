using P4_1_PrototypeLibrary.PrototypeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_PrototypeLibrary
{
    // 原型管理器
    public class PrototypeRegistry
    {
        private readonly Dictionary<string, IPrototype<object>> _prototypes = new Dictionary<string, IPrototype<object>>();

        public void Register(string key, IPrototype<object> prototype)
        {
            _prototypes[key] = prototype;
        }

        public T GetClone<T>(string key) where T : class
        {
            if (_prototypes.TryGetValue(key, out var prototype))
            {
                return (T)prototype.Clone();
            }
            throw new KeyNotFoundException($"Prototype '{key}' not found in registry");
        }

        public bool ContainsKey(string key) => _prototypes.ContainsKey(key);
    }
}
