using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirTrafficMonitoring.System.Interfaces;
using AirTrafficMonitoring.System.Domain;
using TransponderReceiver;
using NUnit.Framework;

namespace AirTrafficMonitoring.Test.Unit
{
    [TestFixture]
    [Author("SWTGruppe12")]
    public class TestObjectifyingModule
    {
        private ITransponderReceiver _tr;

        private IObjectifyingModule _uut;

        [SetUp]
        public void Setup()
        {
            
        }
    }
}
