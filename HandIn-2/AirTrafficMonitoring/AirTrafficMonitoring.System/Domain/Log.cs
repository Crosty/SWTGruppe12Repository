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
        public void Logging(string logString)
        {
            using (StreamWriter w = File.AppendText("Log.txt"))
            {
                w.WriteLine(logString);
            }
        }
    }
}
