using Tyuiu.MilyutinNM.Sprint2.Task5.V12.Lib;
//�������� ���������, ������� ���������� �������� switch ��������� ��������� �������� � ���������� ���������.
//�������: ���� ���������� ��� ��������������� ����� ������������ �������: g(���), m(���������� ����� ������)
// � n(�����). �� �������� g, n � m ���������� ���� ����������� ���. �������� ��� �������� ����������.
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