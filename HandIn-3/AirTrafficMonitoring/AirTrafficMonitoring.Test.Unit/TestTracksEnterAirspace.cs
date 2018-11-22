using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace AirTrafficMonitoring.Test.Unit
{
    class TestTracksEnterAirspace
    {
=======
using AirTrafficMonitoring.System.Interfaces;
using AirTrafficMonitoring.System.Domain;
using TransponderReceiver;
using NUnit.Framework;
using NSubstitute;
namespace AirTrafficMonitoring.Test.Unit
{

    [TestFixture]
    [Author("SWTGruppe12")]
    class TestTracksEnterAirspace
    {
        private ITracksEnterAirspace _uut;

        [SetUp]
        public void Setup()
        {


        }

>>>>>>> 17030e30523fc1f1cfd66e6d77da20103338b02a
    }
}
