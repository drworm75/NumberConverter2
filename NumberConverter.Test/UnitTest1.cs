using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NumberConverter.Test
{
    [TestClass]
    public class ArabicToRomanNumeralsTest
    {
        [TestMethod]
        public void when_1_is_passed_I_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1);

            //assert
            Assert.AreEqual("I", result);

        }

        [TestMethod]
        public void when_3_is_passed_III_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(3);

            //assert
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void when_9_is_passed_IX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(9);

            //assert
            Assert.AreEqual("IX", result);
        }

        [TestMethod]
        public void when_4_is_passed_IV_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(4);

            //assert
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void when_1066_is_passed_MLXVI_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1066);

            //assert
            Assert.AreEqual("MLXVI", result);
        }

        [TestMethod]
        public void when_1989_is_passed_MCMLXXXIX_should_be_returned()
        {
            //arrange
            var converter = new RomanNumeralConverter();

            //act
            var result = converter.Convert(1989);

            //assert
            Assert.AreEqual("MCMLXXXIX", result);
        }
    }


}
