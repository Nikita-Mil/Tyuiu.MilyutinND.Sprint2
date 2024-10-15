using Tyuiu.MilyutinNM.Sprint2.Task5.V12.Lib;
//Ќаписать программу, котора€ использует оператор switch вычисл€ет требуемое значение и возвращает результат.
//”словие: ƒата некоторого дн€ характеризуетс€ трем€ натуральными числами: g(год), m(пор€дковый номер мес€ца)
// и n(число). ѕо заданным g, n и m определить дату предыдущего дн€. «аданный год €вл€етс€ високосным.
namespace Tyuiu.MilyutinNM.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 1;
            int n = 1;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(1 + "." + 12 + "." + 1999);
            Assert.AreEqual(wait, res);
        }
    }
}