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
        private List<ITrack> _oldSeparations;
        public event EventHandler<EventTracks> TracksSeparated;

        public SeparationModule(IUpdateModule updateModule, ILog log)
        {
            _log = log;
            _oldSeparations = new List<ITrack>();
            updateModule.TracksUpdated += SeparationTracks;
        }

        private void SeparationTracks(object sender, EventTracks e)
        {
            var updatedSeparations = new List<ITrack>();

            foreach (var separationTrack in e.Data)
            {
                //Do something
            }

            _oldSeparations = updatedSeparations;

        }

        protected virtual void UpdatedSeparationsEvent(EventTracks e)
        {
            TracksSeparated?.Invoke(this, e);
        }

        private double CalculateSeparation(Point trackOne, Point trackTwo)
        {
            return 1;
        }
    }
}
