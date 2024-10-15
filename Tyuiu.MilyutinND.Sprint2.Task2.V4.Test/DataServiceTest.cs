using System.Diagnostics;
using Tyuiu.MilyutinND.Sprint2.Task2.V4.Lib;
//Ќаписать программу на, котора€ запрашивает целые значени€ с клавиатуры
//и вычисл€ет находитс€ ли точка с координатами X,Y в заштрихованной области.
namespace Tyuiu.MilyutinND.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}