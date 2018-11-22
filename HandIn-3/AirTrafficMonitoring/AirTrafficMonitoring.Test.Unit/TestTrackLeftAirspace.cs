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
namespace AirTrafficMonitoring.Test.Unit
{
    [TestFixture]
    [Author("SWTGruppe12")]

    class TestTrackLeftAirspace
    {
        private IUpdateModule _updateModule;
        private IAirspace _airspace;
        private List<ITrack> _tracks;

        private ITrackLeftAirspace _uut;

        private Point _trackLeftAirspace;
        [SetUp]
        public void Setup()
        {
            _updateModule = Substitute.For<IUpdateModule>();
            _airspace = Substitute.For<IAirspace>();

            _uut = new TrackLeftAirspace(_airspace, _updateModule);
            _uut.TracksleftAirspace += (sender, args) =>
            {
                _tracks = args.Data;
            };

            _trackLeftAirspace = new Point(70000, 70000, 70000);
        }
        [Test]
        public void CheckIfTrackleftAirspace()
        {
            var data = new List<ITrack>();
            var args = new EventTracks(data);

            var trackInsideAirspace = new Track("TagOne", _trackLeftAirspace, DateTime.Now);

            data.Add(trackInsideAirspace);

            _updateModule.TracksUpdated += Raise.EventWith(args);

            Assert.That(_tracks.Contains(trackInsideAirspace));
        }
    }
}
