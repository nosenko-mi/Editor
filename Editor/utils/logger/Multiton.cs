using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils.multiton
{
    class Multiton<T> where T: class, new()
    {
        private static Dictionary<string, T> instances = new Dictionary<string, T>();
        
        private static int maxInstances = 5; // Maximum number of instances
        private static int instanceCount = 0; // Current number of instances
        
        private static object lockObject = new object();

        private Multiton() { }

        public static T GetInstance(string key)
        {
            lock (lockObject)
            {
                if (!instances.ContainsKey(key))
                {
                    if (instanceCount < maxInstances)
                    {
                        instances.Add(key, new T());
                        instanceCount++;
                    }
                    else
                    {
                        throw new Exception("Maximum number of instances reached.\n");
                    }
                }
                return instances[key];
            }
        }
    }
}
