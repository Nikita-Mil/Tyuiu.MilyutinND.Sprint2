using Tyuiu.MilyutinND.Sprint2.Task7.V2.Lib;
//Написать программу на C#, которая запрашивает исходные данные (вещественные значения)
//и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.

namespace Tyuiu.MilyutinND.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.10;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}