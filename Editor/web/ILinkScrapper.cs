using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.web
{
    public interface ILinkScrapper
    {
        List<MoodleLink> GetNews(int amount);
    }
}
