using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace cn.lovelong.FreeCodeCamp.Tests
{
    [TestClass]
    public class UnitTestFamousQuotesView
    {
        [TestMethod]
        public void TestFamousQuotesView()
        {
            BLL.IFamousQuotesView bll = new BLL.FamousQuotesView();
            Assert.IsNull(bll.GetRandom());
        }
    }
}
