using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess
{
    [TestClass]
    public class UITest
    {
        [TestMethod]
        public void TestLoginIsCorrect()
        {
            ConnectToDB connectBD = new ConnectToDB();
            connectBD.OpenConnection();

            bool success = connectBD.LoginPlayer("mathias.renoult@cpnv.ch", "Pa$$w0rd");
            connectBD.CloseConnection();

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestLoginIsFailed()
        {
            ConnectToDB connectBD = new ConnectToDB();
            connectBD.OpenConnection();

            bool fail = connectBD.LoginPlayer("mathias.renoutl@cpnv.ch", "Pa$$w0rd");
            connectBD.CloseConnection();

            Assert.AreEqual(false, fail);
        }

        [TestMethod]
        public void TestRegister()
        {
            ConnectToDB connectBD = new ConnectToDB();
            connectBD.OpenConnection();

            bool success = connectBD.AddPlayer("UN_ZZEEERO", "mathias.renoult@gmail.com", "Pa$$w0rd", 0, 10000);
            connectBD.CloseConnection();

            Assert.AreEqual(true, success);
        }
    }
}
