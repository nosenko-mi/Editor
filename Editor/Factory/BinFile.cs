using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Factory
{
    internal class BinFile : EditorFile
    {
        public BinFile() : base() { }

        public BinFile(string text) : base(text) { }

        override public void Save(string path)
        {
            // Open a file stream and create a binary writer
            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(Text);
            }
        }

        public override string Read(string path)
        {
            string text;
            // Open a file stream and create a binary writer
            using (FileStream fs = new FileStream(path, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                // Read the entire file as text
                text = sr.ReadToEnd();
            }
            Text = text;
            return Text;
        }
    }
}
