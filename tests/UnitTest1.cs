using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData("TEST1");
            yield return new TestCaseData("TEST2");
            yield return new TestCaseData("TEST3");
            yield return new TestCaseData("TEST4");
            yield return new TestCaseData("TEST5");
            yield return new TestCaseData("TEST6");
            yield return new TestCaseData("TEST7");
            yield return new TestCaseData("TEST8");
            yield return new TestCaseData("TEST9");
            yield return new TestCaseData("TEST10");
            yield return new TestCaseData("TEST11");
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test1(string input)
        {
            Assert.AreEqual(input.Length, 5);
        }
    }
}