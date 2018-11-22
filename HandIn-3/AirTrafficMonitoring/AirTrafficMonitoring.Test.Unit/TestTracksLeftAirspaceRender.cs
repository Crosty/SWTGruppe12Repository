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
        [SetUp]
        public void Setup()
        {
            _trackLeftAirspace = Substitute.For<ITrackLeftAirspace>();
            _display = Substitute.For<IDisplay>();

            _uut = new TracksEnterAirspaceRender(_trackLeftAirspace, _display);

            _trackOne = new Point(10000, 14000, 1100);
            _trackTwo = new Point(45000, 45000, 4500);
        }
    }
}
