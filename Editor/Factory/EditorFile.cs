﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Factory
{
    public abstract class EditorFile
    {
        public string Text { get; set; }

        public EditorFile()
        {
            Text = string.Empty;
        }

        public EditorFile(string text)
        {
            Text = text;
        }
        public abstract void Save(string path);

        public abstract string Read(string path);
    }
}
