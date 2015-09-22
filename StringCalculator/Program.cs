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
        public void EmptyString()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("");
            Assert.AreEqual(0, result);
        }
        [Test]
        public void OneNumber()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("1");
            Assert.AreEqual(1, result);
        }
        [Test]
        public void TwoNumbers()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("1,2");
            Assert.AreEqual(3, result);
        }
    }
}