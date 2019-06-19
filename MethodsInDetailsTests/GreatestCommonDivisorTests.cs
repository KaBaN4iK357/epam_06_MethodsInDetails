﻿using TasksLibrary;
using NUnit.Framework;
using MSUnitTest = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsInDetailsTests
{
    [TestFixture]
    [MSUnitTest.TestClass]
    class GreatestCommonDivisorTests
    {
        [TestCase(10, 15, 20, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(0, 140, 20, -50, 13, ExpectedResult = 1)]
        [TestCase(int.MaxValue, int.MinValue, ExpectedResult = 1)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 43, 53, 59, ExpectedResult = 1)]
        public int CheckFindingGCDByEuclid(int num1, int num2, params int[] numbers)
        {
            double workTime;
            return EuclidGreatestCommonDivisor.GetGCD(out workTime, num1, num2, numbers);
        }

        [TestCase(10, 15, 20, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(0, 140, 20, -50, 13, ExpectedResult = 1)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 43, 53, 59, ExpectedResult = 1)]
        public int CheckFindingGCDByStain(int num1, int num2, params int[] numbers)
        {
            double workTime;
            return StainGreatestCommonDivisor.GetGCD(out workTime, num1, num2, numbers);
        }

        [Test, TestCaseSource("GCDByStain")]
        public void CheckFindingGCDByStainBoundary(int expected, int num1, int num2, params int[] numbers)
        {
            double workTime;
            var actual = StainGreatestCommonDivisor.GetGCD(out workTime, num1, num2, numbers);
            MSUnitTest.Assert.AreEqual(expected, actual);
        }

        static object[] GCDByStain =
        {
            new object[] { 1, int.MaxValue, int.MinValue,new int[] {0 } },
            new object[] { int.MaxValue, int.MaxValue, 0,new int[] {0 }},
            new object[] { int.MaxValue, int.MaxValue, int.MaxValue, new int[] { 0 } }
        };
    }
}
