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
        //Demand
        private ITransponderReceiver _tr;
        //uut
        private IObjectifyingModule _uut;
        //Required
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

        public void CreateTracks_CreateTracksAddToList_ContainsList(string trackList)
        {
            var data = new List<string> {trackList};
            var args = new RawTransponderDataEventArgs(data);
        }
    }
}
