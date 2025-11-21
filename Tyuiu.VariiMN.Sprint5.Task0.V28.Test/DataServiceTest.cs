using Tyuiu.VariiMN.Sprint5.Task0.V28.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;
            string filePath = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            double result = double.Parse(content);
            Assert.AreEqual(7.34847, result, 0.001);
        }
    }
}
