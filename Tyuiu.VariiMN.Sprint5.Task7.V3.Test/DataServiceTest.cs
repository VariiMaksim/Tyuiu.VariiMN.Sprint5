using Tyuiu.VariiMN.Sprint5.Task7.V3.Lib;

namespace Tyuiu.VariiMN.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testContent = "Hello, Мир!";
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testContent);

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempPath);

            File.Delete(tempPath);

            Assert.AreEqual("Hello, !", result);
        }
    }
}
