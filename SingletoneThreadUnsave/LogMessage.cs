using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone.ThreadUnsave
{
    public class LogMessage
    {

        public LogType Type { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public LogMessage(LogType type, string message )
        {
            Type = type;
            Message = message;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Type}] {Timestamp:yyyy-MM-dd HH:mm:ss}  {Message}";
        }

    }
}
