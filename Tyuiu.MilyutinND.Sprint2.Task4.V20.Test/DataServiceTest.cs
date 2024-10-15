using Tyuiu.MilyutinND.Sprint2.Task4.V20.Lib;

namespace Tyuiu.MilyutinND.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();

            double x = 10;
            double y = 3;
            double wait = 0.003;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();

            double x = 6;
            double y = 2;
            double wait = 0.28;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}