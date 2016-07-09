using NUnit.Framework;
using TestGitLib;

namespace TestGit
{
    // master commit
    [TestFixture]
    public class UnitTest1
    {
        [Test]
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
