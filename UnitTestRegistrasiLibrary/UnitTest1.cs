using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestRegistrasiLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string hasil = RegistrasiLibrary.Class1.ReadJSON("passlimelvin", "vinjsp", "vinjsp14");
        }
    }
}
