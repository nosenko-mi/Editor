
using System.Diagnostics;

namespace Editor.utils.logger
{
    class Logger
    {

        private static StreamWriter swLog;
        private const string LOG_FILE_PATH = "log.txt";

        static Logger()
        {
            Logger.Open();
        }

        public static void Open()
        {
            Logger.swLog = new StreamWriter(LOG_FILE_PATH, false);
            Logger.swLog.AutoFlush = true;
        }

        public static void Close()
        {
            Logger.swLog.Flush();
            Logger.swLog.Close();
        }

        public void Log(string e, int lineIndex, int characterIndex)
        {
            var currentTime = DateTime.Now;
            string message = $"{currentTime} {e} ln: {lineIndex} col: {characterIndex}\n";
            Debugger.Log(1, "logger", message);
            Logger.swLog.WriteLine(message);
            Logger.swLog.Flush();
        }
    }
}
