using Tyuiu.VariiMN.Sprint5.Task3.V18.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;

            string filePath = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(filePath));


            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Assert.AreEqual(37.56, result, 0.001);
            }
        }
    }
}
