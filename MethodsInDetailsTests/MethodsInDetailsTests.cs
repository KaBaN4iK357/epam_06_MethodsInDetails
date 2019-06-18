﻿using TasksLibrary;
using NUnit.Framework;
using MSUnitTest = Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace MethodsInDetailsTests
{
    [TestFixture]
    [MSUnitTest.TestClass]
    public class MethodsInDetailsTests
    {
        [TestCase(263.3, ExpectedResult = "0100000001110000011101001100110011001100110011001100110011001101")]
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(1, ExpectedResult = "0011111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(185.4375, ExpectedResult = "0100000001100111001011100000000000000000000000000000000000000000")]
        [TestCase(0.125, ExpectedResult = "0011111111000000000000000000000000000000000000000000000000000000")]
        public string CheckToIEEE754(double number)
        {
            return number.ToIEEE754();
        }

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
        [TestCase(int.MaxValue, int.MinValue, ExpectedResult = 1)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, ExpectedResult = 2)]
        [TestCase(3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 43, 53, 59, ExpectedResult = 1)]
        public int CheckFindingGCDByStain(int num1, int num2, params int[] numbers)
        {
            double workTime;
            return StainGreatestCommonDivisor.GetGCD(out workTime, num1, num2, numbers);
        }

        [MSUnitTest.TestMethod]
        public void CheckIsNull()
        {
            int? i1 = 1;
            Assert.AreEqual(false, i1.IsNull());

            int? i2 = null;
            Assert.AreEqual(true, i2.IsNull());

            string s1 = null;
            Assert.AreEqual(true, s1.IsNull());

            string s2 = "Some str";
            Assert.AreEqual(false, s2.IsNull());

            object o1 = "boxing";
            Assert.AreEqual(false, o1.IsNull());

            object o2 = null;
            Assert.AreEqual(true, o2.IsNull());

            int[] arr1 = null;
            Assert.AreEqual(true, arr1.IsNull());

            int[] arr2 = { 1, 2, 3 };
            Assert.AreEqual(false, arr2.IsNull());
        }
    }
}
