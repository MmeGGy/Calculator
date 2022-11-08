using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcClassBr;
using System.Data.SqlTypes;

namespace CalcUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\User\Desktop\Автомати\Лаб 1\Calculator\CalcUnitTestProject1\XMLFile1.xml", "Operation", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            long expr_1 = Convert.ToInt64(TestContext.DataRow["expr_1"]);
            long expr_2 = Convert.ToInt64(TestContext.DataRow["expr_2"]);
            string exp = Convert.ToString(TestContext.DataRow["exp"]);

            string result;
            try
            {
                result = Convert.ToString(CalcClass.Sub(expr_1, expr_2));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result = ex.ParamName;
            }
            Assert.AreEqual(exp, result);
        }
    }
}
