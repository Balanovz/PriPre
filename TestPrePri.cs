using Microsoft.VisualStudio.TestTools.UnitTesting;
using PREPRI;
using System;

namespace UnitTestsPREPRI
{
    [TestClass]
    public class TestPrePri
    {

        private void TestResult(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string testString = "Бытие, \"нашей\" жизни: чрезмерно$ огромное и $присоединение его в другие миры было бы делом непосильным";
            string expected = "Бытее, \"нашей\" жизни: чрезмерно$ огромное и $пресоединенее его в другее миры было бы делом непосильным";
            string actual = Master.Parser(testString);
            TestResult(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string testString = "Привет, новый мир ";
            string expected = "Превет, новый мир";
            string actual = Master.Parser(testString);
            TestResult(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string testString = "$Присоединение: \"$присоединение\".";
            string expected = "$Пресоединенее: \"$пресоединенее\".";
            string actual = Master.Parser(testString);
            TestResult(expected, actual);
        }


    }
}
