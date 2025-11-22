using Tyuiu.VariiMN.Sprint5.Task2.V20.Lib;
    
namespace Tyuiu.VariiMN.Sprint5.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = {
                {5, -5, -1},
                {-4, 2, -4},
                {-7, 1, 4}
            };

            string filePath = ds.SaveToFileTextData(array);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string expected = "1;0;0\n0;1;0\n0;1;1";

            Assert.AreEqual(expected, content);
        }
    }
}
