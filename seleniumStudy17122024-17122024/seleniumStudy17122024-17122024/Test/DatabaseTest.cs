using System;
using seleniumStudy17122024_17122024.Services;

namespace seleniumStudy17122024_17122024.Test
{
    [TestClass]
    public class DatabaseTest : BaseTest
    {
        DatabaseService databaseService;

        public DatabaseTest()
        {
            databaseService = new DatabaseService();
        }

        [TestMethod]
        public void TestDatabase()
        {
            //var result = databaseService.GetInformation();
            //Assert.AreEqual(result.Name, "SQL Basic");
            //Assert.AreEqual(result.IdCourse, 1);
        }
    }
}

