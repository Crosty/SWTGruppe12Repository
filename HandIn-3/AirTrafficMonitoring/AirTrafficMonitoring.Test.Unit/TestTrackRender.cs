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

    public class TestTrackRender
    {

        private IDisplay _display;
        private IUpdateModule _updateModule;

        private TrackRender _uut;
    

        [SetUp]

        public void Setup()
        {

            _updateModule = Substitute.For<IUpdateModule>();
            _display = Substitute.For<IDisplay>();

        





        }



    }

}