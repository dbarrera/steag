using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Steag.Data;
using Steag.Business;
using Steag.Framework.Model;
using Steag.Framework.Authentication;
using Moq;

namespace Test.Steag.Business
{
    [TestClass]
    public class AutoNumberingLogicTest
    {
        [TestMethod]
        public void TestGenerateDocumentCode()
        {
            var dataSource = new Mock<IDataSource>();
            var user = User.Default;

            var autoNumberingLogic = new AutoNumberingLogic(user, dataSource.Object);

            var generatedCode = autoNumberingLogic.GenerateDocumentCode("SARF");
        
        }
    }
}
