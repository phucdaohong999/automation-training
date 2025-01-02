using System;
using Automation.Core.Helpers;
using OpenQA.Selenium.BiDi.Modules.Script;

namespace seleniumStudy17122024_17122024.Services
{
    public class DatabaseService
    {
        string connectionString = ConfigurationHelper.GetValue<string>("connectionstring");
        //public Course GetInformation()
        //{
        //    string queryTemp = Queries.queryTemp;
        //    var result = SqlHelper.ExecuteQuery<Course>(connectionString, queryTemp);
        //    return result.FirstOrDefault();
        //}
    }
}
