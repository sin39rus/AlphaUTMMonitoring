using AMcore.Models.EGAIS;
using AMcore.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AMTests.ModelsTests
{
    [TestClass]
    public class UtmInfoTests
    {
        [TestMethod]
        [DataRow("UtmInfo1.json")]
        public void UtmInfo_ReadJsonDataAndParse_Valid(string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "ModelsTests\\DataForTest\\", fileName);
            string data = File.ReadAllText(filePath);
            UtmInfo info = UtmInfo.Parse(data);
            Assert.IsNotNull(info);
            Assert.AreEqual("4.2.0", info.Version);
            Assert.IsNull(info.RsaError);
            Assert.IsNull(info.CheckInfo);
            Assert.AreEqual("030000646033", info.OwnerId);

            Assert.IsNotNull(info.Db);
            Assert.AreEqual(DateTimeOffset.Parse("2021-11-30 13:23:08.499"), info.Db?.CreateDate);
            Assert.AreEqual("030000646033", info.Db?.OwnerId);

            Assert.IsNotNull(info.Rsa);
            Assert.AreEqual(CertType.RSA, info.Rsa?.CertType);
            Assert.AreEqual(DateTime.Parse("2021-11-25 13:10:54 +0300"), info.Rsa?.StartDate);
            Assert.AreEqual(DateTime.Parse("2022-11-25 13:20:54 +0300"), info.Rsa?.ExpireDate);
            Assert.AreEqual("valid", info.Rsa?.IsValid);
            Assert.AreEqual("pki.fsrar.ru", info.Rsa?.Issuer);

            Assert.IsNotNull(info.Gost);
            Assert.AreEqual(CertType.GOST, info.Gost?.CertType);
            Assert.AreEqual(DateTime.Parse("2021-11-25 10:24:47 +0300"), info.Gost?.StartDate);
            Assert.AreEqual(DateTime.Parse("2022-11-25 10:26:59 +0300"), info.Gost?.ExpireDate);
            Assert.AreEqual("valid", info.Gost?.IsValid);
            Assert.AreEqual("АО \"ПФ \"СКБ КОНТУР\"", info.Gost?.Issuer);

            Assert.AreEqual(false, info.License);
        }
    }
}
