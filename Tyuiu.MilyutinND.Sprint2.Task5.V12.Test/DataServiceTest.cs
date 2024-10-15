using Tyuiu.MilyutinND.Sprint2.Task5.V12.Lib;

namespace Tyuiu.MilyutinND.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 1;
            int n = 5;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(5 + "." + 12 + "." + 1999);
            Assert.AreEqual(wait, res);
        }
    }
}