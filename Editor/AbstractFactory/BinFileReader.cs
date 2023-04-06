using Editor.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.AbstractFactory
{
    internal class BinFileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            var file = new BinFile();
            return file.Read(path);
        }
    }
}
