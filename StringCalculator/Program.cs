using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class StringCalculator
    {
        public StringCalculator()
        {

        }
        public int Add (string numbers)
        {
            return 0;
        }
    }
}

namespace StringCalculator
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void TestOneNumber()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("1");
            Assert.AreEqual(1, result);
        }
        [Test]
        public void TestSumOfTwo()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("0,1");
            Assert.AreEqual(1, result);
        }
    }
}