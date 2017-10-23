using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest
{
    class UnitTest
    {
        [Test]
        public void FirstTestAddition()
        {
            Assert.AreEqual(8,Calculator.Addition(5,3));
        }

        [Test]
        public void SecondTestAddition()
        {
            Assert.AreEqual(-2, Calculator.Addition(-5, 3));
        }

        [Test]
        public void ThirdtTestAddition()
        {
            Assert.AreEqual(-8, Calculator.Addition(-5, -3));
        }

        [Test]
        public void FourthTestAddition()
        {
            Assert.AreEqual(5, Calculator.Addition(5, 0));
        }

        [Test]
        public void FifthTestAddition()
        {
            Assert.AreEqual(-5, Calculator.Addition(-5, -0));
        }

        [Test]
        public void FirstTestMultiplication()
        {
            Assert.AreEqual(15, Calculator.Multiplication(5, 3));
        }

        [Test]
        public void SecondTestMultiplication()
        {
            Assert.AreEqual(-8, Calculator.Multiplication(-4, 2));
        }

        [Test]
        public void ThirdTestMultiplication()
        {
            Assert.AreEqual(8, Calculator.Multiplication(-4, -2));
        }

        [Test]
        public void FourthTestMultiplication()
        {
            Assert.AreEqual(0, Calculator.Multiplication(-4, 0));
        }

        [Test]
        public void FifthTestMultiplication()
        {
            Assert.AreEqual(0, Calculator.Multiplication(0, 0));
        }
        [Test]
        public void FirstTestDivision()
        {
            Assert.AreEqual(2, Calculator.Division(4, 2));
        }

        [Test]
        public void SecondTestDivision()
        {
            Assert.AreEqual(-2, Calculator.Division(-4, 2));
        }

        [Test]
        public void ThirdTestDivision()
        {
            Assert.AreEqual(-4, Calculator.Division(-4, 1));
        }

        [Test]
        public void FourthTestDivision()
        {
            Assert.AreEqual(8, Calculator.Division(4, 0.5));
        }

        [Test]
        public void FifthTestDivision()
        {
            Assert.AreEqual(0.25, Calculator.Division(0.5, 2));
        }
        [Test]
        public void FirstTestSubtraction()
        {
            Assert.AreEqual(2, Calculator.Subtraction(4, 2));
        }

        [Test]
        public void SecondTestSubtraction()
        {
            Assert.AreEqual(-6, Calculator.Subtraction(-4, 2));
        }

        [Test]
        public void ThirdTestSubtraction()
        {
            Assert.AreEqual(6, Calculator.Subtraction(4, -2));
        }

        [Test]
        public void FourthTestSubtraction()
        {
            Assert.AreEqual(3, Calculator.Subtraction(-1, -4));
        }

        [Test]
        public void FifthTestSubtraction()
        {
            Assert.AreEqual(2, Calculator.Subtraction(0, -2));
        }
    }
}