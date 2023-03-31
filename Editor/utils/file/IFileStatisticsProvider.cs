using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils.file
{
    interface IFileStatisticsProvider
    {
        FileStatistics FullStatistics();
    }
}
