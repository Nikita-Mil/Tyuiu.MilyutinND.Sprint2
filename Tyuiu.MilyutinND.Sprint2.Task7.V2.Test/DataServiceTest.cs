using Tyuiu.MilyutinND.Sprint2.Task7.V2.Lib;
//�������� ��������� �� C#, ������� ����������� �������� ������ (������������ ��������)
//� ���������, ��������� �� ����� � ������������ X,Y � �������������� �������.

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