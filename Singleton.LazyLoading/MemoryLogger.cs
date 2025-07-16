using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.LazyLoading
{ 
    public class MemoryLogger
    {
        private int _infoCount;
        private int _warningCount;
        private int _errorCount;

        
        private List<LogMessage> _logMessages = new List<LogMessage>();
        public ReadOnlyCollection<LogMessage> LogMessages => _logMessages.AsReadOnly();
        
       


        private void Log(string message , LogType logType )
        => _logMessages.Add(new LogMessage(logType, message));

        public void LogInfo(string message)
        {
            _infoCount++;
            Log(message, LogType.Info);
        }
        public void LogWarning(string message)
        {
            _warningCount++;
            Log(message, LogType.Warning);
        }
        public void LogError(string message)
        {
            _errorCount++;
            Log(message, LogType.Error);
        }

        public void showLogCounts()
        {
            foreach (var logMessage in _logMessages)
            {
                Console.WriteLine(logMessage);
            }
            Console.WriteLine($"Info: {_infoCount}, Warning: {_warningCount}, Error: {_errorCount}");
        }

        // Apply the Singleton pattern
        private MemoryLogger()
        {
            _infoCount = 0;
            _warningCount = 0;
            _errorCount = 0;
        }

        // Use a static readonly to initialize the intance once =>lazyLoading
        private static readonly Lazy< MemoryLogger> _instance = new Lazy<MemoryLogger>(()=>new MemoryLogger());

        public static MemoryLogger Instance
        {
            get
            {
                return _instance.Value;
            }
        }


    }
}
