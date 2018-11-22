using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;
using NUnit.Framework;
using TransponderReceiver;

namespace AirTrafficMonitoring.Integration
{
    [TestFixture]
    [Author("SWTGruppe12")]
    //FirstSet is the first step of our system.
    //This includes a step from ObjectifyingModule to FilterModule.
    //(Also TransponderReceiver, but not necessarily mentioned).
    public class TestFirstSet
    {
        //Demand
        private ITransponderReceiver _tr;
        //iut
        private IFilterModule _iut;
        //Required
        private IObjectifyingModule _objectifyingModule;
        private IAirspace _airspace;
        private List<ITrack> _createdTrackList;
        private List<ITrack> _filteredTrackList;
        [SetUp]
        public void SetUp()
        {
            //Arrange

        }
    }
}
