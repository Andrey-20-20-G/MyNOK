using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNOK.MyNOK;

namespace MyNOKTest
{
    [TestClass]
    public class UnitTest1
    {
        private const int Expected = 35;
        [TestMethod]
        public void TestMethod1()
        {
            var model = new MyModel<int>();
            model.A = 7;
            model.B = 5;
            NOK nok = new NOK();
            Assert.AreEqual(Expected, nok.Result(model.A, model.B));
        }

        private const bool Expected2 = false;
        
        [TestMethod]
        public void TestMethod2()
        {
            ToWork work = new ToWork();
            Assert.AreEqual(!Expected2, work.ToWorkMethod());
        }

        [TestMethod]
        public void TestMethod3()
        {
            ToWork work = new ToWork();
            Assert.AreEqual(Expected2, work.ToWorkMethod2());
        }
    }
}