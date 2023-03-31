using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Factory
{
    class TextFileFactory : FileFactory
    {
        public override EditorFile FactoryMethod(string content)
        {
            return new TextFile(content);
        }
    }
}
