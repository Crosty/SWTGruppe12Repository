using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class SeparationModule : ISeparationModule
    {
        private ILog _log;
        private List<ITrack> _oldSeparationsTrack;
        public event EventHandler<EventTracks> TracksSeparated;

        public SeparationModule(IUpdateModule updateModule, ILog log)
        {
            _log = log;
            _oldSeparationsTrack = new List<ITrack>();
            updateModule.TracksUpdated += SeparationTracks;
        }

        private void SeparationTracks(object sender, EventTracks e)
        {
            var updatedSeparationsTracks = new List<ITrack>();

            foreach (var separationTrack in e.Data)
            {
                foreach (var separationTrackTwo in e.Data)
                {
                    //If conflict occurs, do calculate, change positions from old to a new
                    //update it.
                    
                }
            }

            _oldSeparationsTrack = updatedSeparationsTracks;

        }

        protected virtual void UpdatedSeparationsTracksEvent(EventTracks e)
        {
            TracksSeparated?.Invoke(this, e);
        }

        //Calculates the tracks distance, if this is triggered it alerts the conflict
        private bool CalculateSeparationTracks(Point trackOne, Point trackTwo)
        {
            //Vertical separation
            if ((trackOne.Altitude - trackTwo.Altitude) < 300)
            {
                return false;
            }

            //Horizontal separation
            double xcoord;
            double ycoord;

            xcoord = Math.Pow(trackOne.X - trackTwo.X, 2);
            ycoord = Math.Pow(trackOne.Y - trackTwo.Y, 2);

            if (Math.Sqrt(xcoord + ycoord) < 5000)
            {
                return true;
            }

            return false;
        }
    }
}
