using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils
{
    internal interface ITextStatisticsProvider
    {
        Dictionary<string, string> Calc();
    }
}
