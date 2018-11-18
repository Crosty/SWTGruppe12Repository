using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class TracksEnterAirspace : ITracksEnterAirspace
    {
        private IAirspace _airspace;
        public event EventHandler<EventTracks> TracksEnteredAirspace;

        public TracksEnterAirspace(IAirspace airspace, IUpdateModule updateModule)
        {
            _airspace = airspace;
            updateModule.TracksUpdated += TrackEnterAirspace;
        }

        private void TrackEnterAirspace(object sender, EventTracks e)
        {
            var enteredTracks = new List<ITrack>();
            foreach (var checkBorder in e.Data)
            {
                //Check if within airspace, if within airspace printout "YALLAH I HJEMME"
                //Else, printout "YALLAH SKRID MED JER".
            }
            // Update the list.
        }

        protected virtual void TracksEnteredAirspaceEvent(EventTracks e)
        {

        }
    }
}
