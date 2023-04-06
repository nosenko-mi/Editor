using Editor.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.AbstractFactory
{
    internal interface IFileReader
    {
        // replace construct method with read method
        string ReadFile(string path);
    }
}
