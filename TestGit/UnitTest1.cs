using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestGitLib;

namespace TestGit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, SilverCutCounter.GetNumber(1));
            Assert.AreEqual(3, SilverCutCounter.GetNumber(2));
            Assert.AreEqual(4, SilverCutCounter.GetNumber(3));
            Assert.AreEqual(0, SilverCutCounter.GetNumber(0));
            Assert.AreEqual(0, SilverCutCounter.GetNumber(11));
        }
    }
}
