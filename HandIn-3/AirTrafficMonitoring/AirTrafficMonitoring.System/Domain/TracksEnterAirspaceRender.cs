using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class TracksEnterAirspaceRender : ITracksEnterAirspaceRender
    {
        private readonly IDisplay _display;

        public TracksEnterAirspaceRender(ITracksEnterAirspace tracksEnterAirspace, IDisplay display)
        {
            _display = display;
            tracksEnterAirspace.TracksEnteredAirspace += RenderEnteredTracks;
        }

        private void RenderEnteredTracks(object sender, EventTracks e)
        {
            _display.Clear();
            _display.Write("*Tracks Entered Airspace*");
            foreach (var track in e.Data)
            {
                var str = "Tag: " + track.Tag + ", Time: " + track.Timestamp;
                _display.Write(str);
            }
        }
    }
}
