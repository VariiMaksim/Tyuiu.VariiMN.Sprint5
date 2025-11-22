using Tyuiu.VariiMN.Sprint5.Task1.V25.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(11, lines.Length);
            double firstValue = double.Parse(lines[0]);
            Assert.AreEqual(70.14, firstValue, 0.01);
        }
    }
}
