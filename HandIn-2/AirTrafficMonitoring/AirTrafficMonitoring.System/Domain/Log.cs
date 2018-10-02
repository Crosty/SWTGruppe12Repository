using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class Log : ILog
    {
        private readonly string _filePath;

        public Log(string filePath = null)
        {
            _filePath = filePath ?? "Log.txt";
        }
        public void Logging(string logString)
        {
            using (StreamWriter w = new StreamWriter(_filePath))
            {
                w.WriteLine(logString);
            }
        }
    }
}
