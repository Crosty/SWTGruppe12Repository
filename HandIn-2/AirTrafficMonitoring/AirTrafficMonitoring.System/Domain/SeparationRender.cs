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

        public SeparationRender(IUpdateModule updateModule, IDisplay display)
        {
            _display = display;
            updateModule.TracksUpdated += RenderSeparations;
        }

        private void RenderSeparations()
        {

        }
    }
}
