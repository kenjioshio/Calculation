using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Calculation.Summation;

namespace Calculation.Summation.Test
{
    [TestClass]
    public class SummationTest
    {
        [TestMethod]
        public void AddTwoNum()
        {
            // 1+2=3!!
            Calculation.Summation.Summation c = new Calculation.Summation.Summation();
            float r = c.Add(1.0f, 2.0f);
            Assert.AreEqual(3.0f, r);
        }
        [TestMethod]
        public void AddTwoNum2()
        {
            // 3+5=8!!
            Calculation.Summation.Summation c = new Calculation.Summation.Summation();
            float r = c.Add(3.0f, 5.0f);
            Assert.AreEqual(8.0f, r);
        }
    }
}
