using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System;
using AirTrafficMonitoring.System.Domain;
using AirTrafficMonitoring.System.Interfaces;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Internal;
namespace AirTrafficMonitoring.Test.Unit
{
    [TestFixture]
    [Author("SWTGruppe12")]
    class TestTracksLeftAirspaceRender
    {
        private ITrackLeftAirspace _trackLeftAirspace;
        private IDisplay _display;

        private ITracksLeftAirspaceRender _uut;
        //Required
        private Point _trackOne;
        private Point _trackTwo;
    }
}
