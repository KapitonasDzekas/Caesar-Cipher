using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeasarCipher;

namespace CeasarCipherTest
{
    [TestClass]
    public class UnitTest1
    {
        string message1 = "Hello";
        string message2 = ".NET uses the Char structure to represent Unicode code points by using UTF-16 encoding.";
        [TestMethod]
        public void Test_EncryptMethod()
        {
            string res = CeasarCipherAlgorithm.Encrypt(message1, 2);
            Assert.AreEqual(res, "Jgnnq");
        }
        [TestMethod]
        public void Test_DecryptMethod()
        {
            string encryptedText = CeasarCipherAlgorithm.Encrypt(message1, 2);
            string res = CeasarCipherAlgorithm.Decrypt(encryptedText, 2);
            Assert.AreEqual(message1, res);
        }
        [TestMethod]
        public void Test_EncryptMethod2()
        {
            string res = CeasarCipherAlgorithm.Encrypt(message2, 2);
            Assert.AreEqual(res, ".PGV wugu vjg Ejct uvtwevwtg vq tgrtgugpv Wpkeqfg eqfg rqkpvu da wukpi WVH-16 gpeqfkpi.");
        }
        [TestMethod]
        public void Test_DecryptMethod2()
        {
            string encryptedText = CeasarCipherAlgorithm.Encrypt(message2, 2);
            string res = CeasarCipherAlgorithm.Decrypt(encryptedText, 2);
            Assert.AreEqual(message2, res);
        }
    }
}
