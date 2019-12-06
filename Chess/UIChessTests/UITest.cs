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
        public void TestRegisterCorrect()
        {
            ConnectToDB connectBD = new ConnectToDB();
            connectBD.OpenConnection();

            bool success = connectBD.AddPlayer("UN_ZZEEERO", "mathias.renoult@gmail.com", "Pa$$w0rd", 0, 10000);
            connectBD.CloseConnection();

            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void FakePassword()
        {
            ConnectToDB connectBD = new ConnectToDB();
            connectBD.OpenConnection();

            bool fail = connectBD.LoginPlayer("mathias.renoult@cpnv.ch", "Pa$$W0rd");
            connectBD.CloseConnection();

            Assert.AreEqual(false, fail);
        }

        [TestMethod]
        public void ConfirmPassword()
        {
            RegisterForm register = new RegisterForm();
            
            if (register.Password == register.PasswordConfirm)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void ConfirmPasswordFalse()
        {
            RegisterForm register = new RegisterForm();

            if (register.Password != register.PasswordConfirm)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void RegisterWithoutMail()
        {
            RegisterForm register = new RegisterForm();

            if (register.Mail == "")
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void RegisterPasswordShort()
        {
            RegisterForm register = new RegisterForm();

            if (register.Password == "12" && register.PasswordConfirm == "12")
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void RegisterPasswordIsCorrect()
        {
            RegisterForm register = new RegisterForm();

            if (register.Password == "Pa$$w0rd" && register.PasswordConfirm == "Pa$$w0rd")
            {
                Assert.IsTrue(true);
            }
        }

    }
}
