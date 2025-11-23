using Tyuiu.VariiMN.Sprint5.Task4.V23.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\DataSprint5\InPutDataFileTask4V23.txt";
            double result = ds.LoadFromDataFile(path);
            Assert.AreEqual(1.077, result, 0.001);
        }
    }
}
