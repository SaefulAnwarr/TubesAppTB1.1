using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPemesanan2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DBCTest2()
        {
            List<string> jenis = new List<string>();
            jenis.Add("Sepeda");
            jenis.Add("Motor");
            jenis.Add("Mobil");
            Assert.AreNotEqual(jenis, DBCLibrary2.DBC2.Dbc<string, int>(jenis, 5));
        }
    }
}
