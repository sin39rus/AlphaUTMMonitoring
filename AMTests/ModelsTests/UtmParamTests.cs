using AMcore.Extensions;
using AMcore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace AMTests.ModelsTests
{
    [TestClass]
    public class UtmParamTests
    {
        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow(" ")]
        [DataRow("02000003087")]
        [DataRow("0200000308733")]
        [DataRow("0200000308a3")]
        [DataRow("0200000308#3")]
        public void UtmParam_NotValidFsrarID_ArgumentException(string fsrarID)
        {
            Assert.ThrowsException<ArgumentException>(() => { _=new UtmParam(fsrarID, "127.0.0.1", 8080); });
        }
        [TestMethod]
        [DataRow("020000030843", "127.0.0.1", -1)]
        [DataRow("020000030843", "127.0.0.1", 65536)]
        [DataRow("020000030843", "127.0.a.1", 8080)]
        [DataRow("020000030843", "127.0.256.1", 8080)]
        public void UtmParam_NotValidConnetionString_ArgumentException(string fsrarID, string connectionAddress, int connectionPort)
        {
            Assert.ThrowsException<ArgumentException>(() => { _=new UtmParam(fsrarID, connectionAddress, connectionPort); });
        }
        [TestMethod]
        public void UtmParam_ValidUtmParam_NormalExit()
        {
            Assert.IsNotNull(new UtmParam("020000030873", "127.0.0.1", 8080));
        }
    }
}
