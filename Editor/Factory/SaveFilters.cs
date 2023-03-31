using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor.Factory
{
    public static class SaveFilters
    {
        private const string TEXT = "Text file (*.txt)|*.txt";
        private const string HTML = "HTML file (*.html)|*.html";
        private const string BINARY = "Binary file (*.bin)|*.bin";

        public static string All()
        {
            return $"{TEXT}|{HTML}|{BINARY}";
        }

        public static FileFactory GetFactory(string filter)
        {
            FileFactory factory;
            switch (filter)
            {
                case TEXT:
                    factory = new TextFileFactory();
                    break;
                case HTML:
                    factory = new HTMLFileFactory();
                    break;
                case BINARY:
                    factory = new BinFileFactory();
                    break;
                default:
                    factory = new TextFileFactory();
                    break;
            }
            return factory;
        }
    }
}
