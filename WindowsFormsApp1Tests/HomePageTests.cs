using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class HomePageTests
    {
        [TestMethod()]
        public void Form1_LoadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void checkTest()
        {
            bool test;
            HomePage h = new HomePage();
            test = h.check("test");
            Assert.IsTrue(test);
        }
        
        
    }
}