using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils.singleton
{
    public class Singleton<T> where T : class, new()
    {
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

        protected Singleton() { }

        public static T Instance { get { return lazy.Value; } }
    }
}
