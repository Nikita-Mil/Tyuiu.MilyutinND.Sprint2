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

            int g = 2024;
            int m = 09;
            int n = 07;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(06 + "." + 09 + "." + 2024);

            Assert.AreEqual(wait, res);
        }
    }
}