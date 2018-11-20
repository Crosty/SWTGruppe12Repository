using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    class TrackLeftAirspaceRender : ITracksLeftAirspaceRender
    {
        private readonly IDisplay _display;

        public TracksLeftAirspaceRender(ITracksLeftAirspace tracksLeftAirspace, IDisplay display)
        {
            _display = display;
            tracksLeftAirspace.TracksLeft
        }

    }
}
