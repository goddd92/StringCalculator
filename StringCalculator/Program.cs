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
        public void Add()
        {
            StringCalculator source = new StringCalculator();
            int result = source.Add("0,1,2");

            StringCalculator source2 = new StringCalculator();
            int result2 = source2.Add("0,1");

            Assert.AreEqual(3, result);
            Assert.AreEqual(1, result2);
        }
    }
}