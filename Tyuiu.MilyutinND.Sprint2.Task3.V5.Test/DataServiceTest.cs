using Tyuiu.MilyutinND.Sprint2.Task3.V5.Lib;
//�������� ���������, ������� ��������� ��������� �������� ������� Y � �������������� ��������� �������� if-else,
//��� ������������ ������ �������� ���������� X � ����������. ��������� ���������� �������� �� ���� ������ ����� �������;
namespace Tyuiu.MilyutinND.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 13;
            double res = ds.Calculate(x);
            double wait = 5.582;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 13;
            double res = ds.Calculate(x);
            double wait = 5.582;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 13;
            double res = ds.Calculate(x);
            double wait = 5.582;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = 13;
            double res = ds.Calculate(x);
            double wait = 5.582;
            Assert.AreEqual(wait, res);
        }
    }
}