using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class Separation : ISeparation
    {
        public string TagOne { get; set; }
        public string TagTwo { get; set; }
        public DateTime Timestamp { get; set; }

        public Separation(string tagOne, string tagTwo, DateTime timestamp)
        {
            TagOne = tagOne;
            TagTwo = tagTwo;
            Timestamp = timestamp;
        }
    }
}
