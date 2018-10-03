using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;

namespace AirTrafficMonitoring.System.Domain
{
    public class SeparationRender
    {
        private IDisplay _display;

        public SeparationRender(ISeparationModule separationModule, IDisplay display)
        {
            _display = display;
            separationModule.TracksSeparated += RenderSeparations;
        }

        private void RenderSeparations(object sender, EventSeparations e)
        {
            _display.Clear();
        }
    }
}
