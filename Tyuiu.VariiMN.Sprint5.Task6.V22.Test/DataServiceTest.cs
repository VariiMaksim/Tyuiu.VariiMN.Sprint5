using Tyuiu.VariiMN.Sprint5.Task6.V22.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"D:\DataSprint5\InPutDataFileTask6V22.txt";

            int result = ds.LoadFromDataFile(path);
            Assert.AreEqual(2, result);
        }
    }
}
