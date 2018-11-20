using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Domain;
using AirTrafficMonitoring.System.Interfaces;
using NUnit.Framework;

namespace AirTrafficMonitoring.Test.Unit
{
    [TestFixture]
    [Author("SWTGruppe12")]
    public class TestFilterModule
    {
        //Demand
        private IObjectifyingModule _objectifyingModule;
        private IAirspace _airspace;
        private List<ITrack> _tracks;
        //uut
        private IFilterModule _uut;
        //Required
        private Point _insideAirspace;
        private Point _outsideAirspace;

        [SetUp]
        public void Setup()
        {
            //Arrange

        }
    }
}
