using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.utils.eventtypes
{
    /// <summary>
    /// Represents logger event types. Uses string instead of enum.
    /// </summary>
    public static class EventType
    {
        public static readonly string ADD = "add";
        public static readonly string DELETE = "delete";
    }
}
