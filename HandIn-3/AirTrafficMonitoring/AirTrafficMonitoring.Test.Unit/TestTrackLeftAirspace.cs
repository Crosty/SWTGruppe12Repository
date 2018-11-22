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

    }
}
