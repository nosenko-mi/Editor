using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Factory
{
    class TextFile : EditorFile
    {
        public TextFile() : base() { }

        public TextFile(string text) : base(text) {}

        override public void Save(string path)
        {
            File.WriteAllText(path, Text);
        }

        public override string Read(string path)
        {
            Text = File.ReadAllText(path);
            return Text;
        }
    }
}
