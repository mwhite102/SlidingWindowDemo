using Microsoft.VisualStudio.TestTools.UnitTesting;
using SlidingWindow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetMaxSumOfSubArrayTest_WithSumAtStart()
        {
            // arrange
            int[] ints = { 5, 6, 7, 0, 2, 3, 4 };

            // act
            int result = SlidingWindow.Program.GetMaxSumOfSubArray(ints, 3);
            
            // assert
            Assert.AreEqual(result, 18);
        }

        [TestMethod()]
        public void GetMaxSumOfSubArrayTest_WithSumAtEnd()
        {
            // arrange
            int[] ints = { 0, 2, 3, 4, 5, 6, 7 };

            // act
            int result = SlidingWindow.Program.GetMaxSumOfSubArray(ints, 3);

            // assert
            Assert.AreEqual(result, 18);
        }

        [TestMethod()]
        public void GetMaxSumOfSubArrayTest_WithSumInMiddle()
        {
            // arrange
            int[] ints = { 0, 2, 5, 6, 7, 3, 4 };

            // act
            int result = SlidingWindow.Program.GetMaxSumOfSubArray(ints, 3);

            // assert
            Assert.AreEqual(result, 18);
        }

        [TestMethod()]
        public void GetMaxSumofSubArrayTest_WithInvalidSubArrayLength()
        {
            // arrange
            int[] ints = { 0, 2, 5, 6, 7, 3, 4 };

            // act
            int result = SlidingWindow.Program.GetMaxSumOfSubArray(ints, 10);

            // assert
            Assert.AreEqual(result, 0);
        }
    }
}