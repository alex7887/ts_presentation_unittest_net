using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ru.psit.ms.presentation.test;

namespace ProjectOneTest
{
    [TestClass]
    public class DivideClassTest
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            Debug.WriteLine("Assembly Init");
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            Debug.WriteLine("ClassInit");
        }

        [TestInitialize()]
        public void Initialize()
        {
            Debug.WriteLine("TestMethodInit");
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Debug.WriteLine("TestMethodCleanup");
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            Debug.WriteLine("ClassCleanup");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("AssemblyCleanup");
        }

     
      [ExpectedException(typeof(System.DivideByZeroException))]
      [TestMethod]
      public void testDivideMethodTest()
      {
         DivideClass target = new DivideClass();
         int a = 0; 
         int actual;
         actual = target.DivideMethod(a);
      }
   }
    
}
