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
    public class Connect4Tests
    {
        [TestMethod()]
        public void DiagonalCheckTest()
        {
            var concet = new Connect4();
            int[,] mat = new int[6, 7];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                    mat[i, j] = 0;

            }
            int expt;
            expt = concet.DiagonalCheck(mat, 2, 2);



            Assert.IsTrue(expt == 0);
        }
        
    }
}