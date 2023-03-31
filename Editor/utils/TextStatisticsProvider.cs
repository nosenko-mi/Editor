using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils
{
    internal class TextStatisticsProvider: ITextStatisticsProvider
    {
        private const int kb = 1024;
        private string text;

        public TextStatisticsProvider(string text)
        {
            this.text = text;
        }

        private int SizeB()
        {
            return this.text.Length * sizeof(char);
        }

        public int CharactersNumber() { return this.text.Length; }

        public Dictionary<string, string> Calc()
        {
            Dictionary<string, string> stats = new Dictionary<string, string>();
            var size_b = this.SizeB();
            var size_kb =(float)size_b / kb;
            stats["sizeB"] = size_b.ToString() + " B";
            stats["sizeKB"] = size_kb.ToString("0.000") + " KB";
            stats["characters"] = CharactersNumber().ToString();
            return stats;
        }
    }
}
