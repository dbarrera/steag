using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Steag.Framework.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Steag.Framework.Security
{
    [TestClass]
    public class MD5CryptoTest
    {
        [TestMethod]
        public void CryptoCreateHash()
        {
            var crypto = new MD5Crypto();
            crypto.SaltSize = 64;
            
            var password = "password!";

            var encoding = new UTF8Encoding();
            var passwordBytes = encoding.GetBytes(password);

            crypto.SaltHash = true;
            
            var hash = crypto.ComputeHash(passwordBytes);
            var salt = crypto.Salt;

            crypto.Salt = salt;
            var newHash = crypto.ComputeHash(passwordBytes);


            var saltstring = Convert.ToBase64String(salt);
            var hashstring = Convert.ToBase64String(hash);

            Assert.IsTrue(hash.SequenceEqual(newHash));            
        }
    }
}
