using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Factory
{
    internal class HTMLFileFactory : FileFactory
    {
        public override EditorFile FactoryMethod(string content)
        {
            return new HTMLFile(content);
        }
    }
}
