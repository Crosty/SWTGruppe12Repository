using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class UpdateModule : IUpdateModule
    {
        private List<ITrack> _oldTracks;
        public event EventHandler<EventTracks> TracksUpdated;

        public UpdateModule(IFilterModule filterModule)
        {
            _oldTracks = new List<ITrack>();
            filterModule.TracksFiltered += UpdateTracks;
        }

        private void UpdateTracks(object sender, EventTracks e)
        {
            var updatedTracks = new List<ITrack>();
            foreach (var filtered in e.Data)
            {
                //If filtered.tag is on _oldtracks, update course and velocity
                //If not, add filtered



                updatedTracks.Add(filtered);
            }

            _oldTracks = updatedTracks;
            UpdatedTracksEvent(new EventTracks(updatedTracks));
        }

        protected virtual void UpdatedTracksEvent(EventTracks e)
        {
            TracksUpdated?.Invoke(this, e);
        }

        private double CalculateVelocity(Point oldPoint, Point newPoint, DateTime oldTime, DateTime newTime)
        {
            TimeSpan time = newTime - oldTime;
            var timeDiff = time.TotalSeconds;
            var distance = Math.Sqrt(Math.Pow((newPoint.X - oldPoint.X), 2) + Math.Pow((newPoint.Y - oldPoint.Y), 2));
            var velocity = distance / timeDiff;

            return velocity;
        }

        private double CalculateCourse(Point oldPoint, Point newPoint)
        {
            double xcoord = Math.Abs(newPoint.X - oldPoint.X);
            double ycoord = Math.Abs(newPoint.Y - oldPoint.Y);

            double direction = 0;

            if (xcoord == 0 && ycoord == 0)
            {
                return Double.NaN;
            }
            else
            {
                {
                    double radian = Math.Atan2(ycoord, xcoord);
                    direction = radian / Math.PI * 180;

                    direction = 90 - direction;
                    if (direction < 0)
                    {
                        direction += 360;
                    }
                }
            }

            return direction;
        }
    }
}
