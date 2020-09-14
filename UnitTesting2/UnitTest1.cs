using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTesting1.Form1 f1 = new UnitTesting1.Form1();
            int result = f1.Testing();

            Assert.AreEqual(3, result);
        }
    }
}
