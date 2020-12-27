using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToNumericConverter;

namespace RomanToNumericConverter.MSTest
{
    [TestClass]
    public class DecimalToNumberTest
    {
        [TestMethod]
        public void Roman_I_1()
        {
            Assert.AreEqual(1, RomanToNumeric.ToNumber("I"));
        }

        [TestMethod]
        public void Roman_II_2()
        {
            Assert.AreEqual(2, RomanToNumeric.ToNumber("II"));
        }

        [TestMethod]
        public void Roman_III_3()
        {
            Assert.AreEqual(3, RomanToNumeric.ToNumber("III"));
        }

        [TestMethod]
        public void Roman_IV_4()
        {
            Assert.AreEqual(4, RomanToNumeric.ToNumber("IV"));
        }

        [TestMethod]
        public void Roman_V_5()
        {
            Assert.AreEqual(5, RomanToNumeric.ToNumber("V"));
        }

        [TestMethod]
        public void Roman_IX_9()
        {
            Assert.AreEqual(9, RomanToNumeric.ToNumber("IX"));
        }

        [TestMethod]
        public void Roman_X_10()
        {
            Assert.AreEqual(10, RomanToNumeric.ToNumber("X"));
        }

        [TestMethod]
        public void Roman_XLIX_49()
        {
            Assert.AreEqual(49, RomanToNumeric.ToNumber("XLIX"));
        }

        [TestMethod]
        public void Roman_L_50()
        {
            Assert.AreEqual(50, RomanToNumeric.ToNumber("L"));
        }

        [TestMethod]
        public void Roman_C_100()
        {
            Assert.AreEqual(100, RomanToNumeric.ToNumber("C"));
        }

        [TestMethod]
        public void Roman_CD_400()
        {
            Assert.AreEqual(400, RomanToNumeric.ToNumber("CD"));
        }

        [TestMethod]
        public void Roman_D_500()
        {
            Assert.AreEqual(500, RomanToNumeric.ToNumber("D"));
        }

        [TestMethod]
        public void Roman_CM_900()
        {
            Assert.AreEqual(900, RomanToNumeric.ToNumber("CM"));
        }

        [TestMethod]
        public void Roman_M_1000()
        {
            Assert.AreEqual(1000, RomanToNumeric.ToNumber("M"));
        }

        [TestMethod]
        public void Roman_MMMMMMMMMMMCMLXXXIV_11984()
        {
            Assert.AreEqual(11984, RomanToNumeric.ToNumber("MMMMMMMMMMMCMLXXXIV"));
        }
    }
}
