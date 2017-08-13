using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CpfValidation;

namespace CpfUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string CpfWithLetters = "1S114758941";


        [TestMethod]
        public void TestCpfLength()
        {
            Assert.IsFalse(CpfValidationClass.CheckLength(""));
        }

        [TestMethod]
        public void TestForLetters()
        {
            Assert.IsFalse(CpfValidationClass.CheckLetters(CpfWithLetters));
        }

        [TestMethod]
        public void TestFalseSequences()
        {
            string[] invalidNumbers =
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };

            CpfValidationClass cpf = new CpfValidationClass();

            for (int i = 0; i < 10; i++)
            {
                Assert.IsFalse(CpfValidationClass.CheckFalseSequences(invalidNumbers[i]));
            }
        }
    }
}
