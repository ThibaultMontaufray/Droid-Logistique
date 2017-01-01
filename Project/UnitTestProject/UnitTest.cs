using Droid_logistique;
using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void Test_demo()
        {
            try
            {
                Demo demo = new Demo();
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_sncf_departures()
        {
            try
            {
                Assert.IsNotNull(InterfaceLogistique.ACTION_130_afficher_departs("le havre"));
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_sncf_arrivals()
        {
            try
            {
                Assert.IsNotNull(InterfaceLogistique.ACTION_131_afficher_arrive("le havre"));
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_sncf_station_description()
        {
            try
            {
                Assert.IsNotNull(InterfaceLogistique.ACTION_132_decrire_gare("le havre"));
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_sncf_journey()
        {
            try
            {
                Assert.IsNotNull(InterfaceLogistique.ACTION_133_partir_train("le havre", "rouen", DateTime.Now));
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
    }
}
