
using Tyuiu.VumaR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.VumaR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Two9";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("привет, Two9", res);
        }
    }
}
