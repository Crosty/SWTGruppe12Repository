using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System
{
    public class EventSeparations : EventArgs
    {
        public List<ISeparation> sepData;

        public EventSeparations(List<ISeparation> sepdata)
        {
            sepData = sepdata;
        }
    }
}
