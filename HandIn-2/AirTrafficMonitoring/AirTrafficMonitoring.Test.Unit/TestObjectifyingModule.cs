using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;
using AirTrafficMonitoring.System.Domain;
using TransponderReceiver;
using NUnit.Framework;
using NSubstitute;

namespace AirTrafficMonitoring.Test.Unit
{
    [TestFixture]
    [Author("SWTGruppe12")]
    public class TestObjectifyingModule
    {
        private ITransponderReceiver _tr;

        private IObjectifyingModule _uut;

        private List<ITrack> _trackList;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _tr = Substitute.For<ITransponderReceiver>();
            _uut = new ObjectifyingModule(_tr);

            _uut.TracksObjectified += (sender, args) =>
            {
                _trackList = args.Data;
            };
        }

        public void CreateTracks_CreateTracksAddToList(string trackList)
        {

        }
    }
}
