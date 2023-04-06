using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.AbstractFactory
{
    internal class FileReader
    {
        private IFileReader _reader;
        public FileReader(IFileReader fileReader) { _reader = fileReader; }

        internal IFileReader IFileReader
        {
            get => default;
            set
            {
            }
        }

        public string ReadFile(string path)
        {
            return _reader.ReadFile(path);
        }
    }
}
