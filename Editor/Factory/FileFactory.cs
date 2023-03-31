using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Factory
{
    public abstract class FileFactory
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract EditorFile FactoryMethod(string content);

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public void SaveFile(string path, string content)
        {
            var file = FactoryMethod(content);
            file.Save(path);
        }
    }
}
