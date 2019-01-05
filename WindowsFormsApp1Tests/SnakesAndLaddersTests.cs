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
    public class SnakesAndLaddersTests
    {
        [TestMethod()]
        public void nextstepTest()
        {
            int result;
            SnakesAndLadders s1 = new SnakesAndLadders("test");
            result = s1.nextstep(2);
            Assert.IsTrue(result == 38);
            
        }
    }
}