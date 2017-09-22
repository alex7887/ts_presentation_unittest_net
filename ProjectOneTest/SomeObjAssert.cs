using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectOneTest
{
    /// <summary>
    /// Summary description for SomeObjAssert
    /// </summary>
    [TestClass]
    public class SomeObjAssert
    {
       
        [TestMethod]
        public void testSqrt()
        {
            double value = 16;
            double expected = 4;
            double result = Math.Sqrt(value);
            Assert.AreEqual(expected, result, "sqrt value {0} should have been {1}");
            
        }

        [TestMethod]
        public void testSqrtDelta()
        {
            double value = 15;
            double expected = 4;
            //double delta = 0.1;
            double delta = 0.3;

            double result = Math.Sqrt(value);

            Assert.AreEqual(expected, result, delta, "sqrt value {0} should have been {1}");

        }

        [TestMethod]
        public void testString()
        {
            String value = "To be happy";
            String expected = "To be happy";
           // String result = string.Intern("To be happy");

            Assert.AreSame(expected, value);
          //  Assert.AreSame(expected, result);

        }
    }
}
