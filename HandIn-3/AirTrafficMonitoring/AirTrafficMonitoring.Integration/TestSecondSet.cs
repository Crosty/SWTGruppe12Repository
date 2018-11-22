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
    //SecondSet is the second step of our system
    //This includes a step from ObjectifyingModule -> FilterModule -> UpdateModule.
    public class TestSecondSet
    {
        //Demand
        private ITransponderReceiver _tr;
        //iut
        private IUpdateModule _iut;
        //Required
        private IObjectifyingModule _objectifyingModule;
        private IFilterModule _filterModule;
        private IAirspace _airspace;
        private List<ITrack> _updatedTrackList;

        [SetUp]
        public void Setup()
        {

        }
    }
}
