﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficMonitoring.System.Interfaces
{
    public interface IObjectifyingModule
    {
        event EventHandler<EventTracks> TracksObjectified;
    }
}
