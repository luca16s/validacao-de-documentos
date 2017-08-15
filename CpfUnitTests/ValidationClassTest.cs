using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CpfValidation;

namespace CpfUnitTests
{
    [TestClass]
    public class CpfunitTests
    {
        private const string CpfWithLetters = "1S114758941";
        private const string ValidCpf = "19210363620";
        private const string ValidCpfWithResultIsTen = "15382205710";
        private const string FalseCpf = "";
        private const string FirstInvalid = "19210363610";
        private const string SecondInvalid = "19210363621";

        [TestMethod]
        public void TestCpfLength()
        {
            Assert.IsFalse(CpfValidationClass.CheckLength(""));
            Assert.IsFalse(CpfValidationClass.CheckLength("121212121214"));
            Assert.IsTrue(CpfValidationClass.CheckLength("12121212121"));
        }

        [TestMethod]
        public void TestForLetters()
        {
            Assert.IsFalse(CpfValidationClass.CheckLetters(CpfWithLetters));
            Assert.IsTrue(CpfValidationClass.CheckLetters(ValidCpf));
            Assert.IsFalse(CpfValidationClass.CheckLetters(FalseCpf));
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
            
            for (var i = 0; i < 10; i++)
            {
                Assert.IsFalse(CpfValidationClass.CheckFalseSequences(invalidNumbers[i]));
            }
            Assert.IsTrue(CpfValidationClass.CheckFalseSequences(""));
        }

        [TestMethod]
        public void TestValidation()
        {
            Assert.IsFalse(CpfValidationClass.Validation(FirstInvalid));
            Assert.IsFalse(CpfValidationClass.Validation(SecondInvalid));
            Assert.IsTrue(CpfValidationClass.Validation(ValidCpfWithResultIsTen));
        }

        [TestMethod]
        public void TestRegion()
        {
            var regionNames = new List<string>
            {
                "Rio Grande do Sul",
                "Distrito Federal, Goiás, Mato Grosso do Sul e Tocantins",
                "Pará, Amazonas, Acre, Amapá, Rondônia e Roraima",
                "Ceará, Maranhão e Piauí",
                "Pernambuco, Rio Grande do Norte, Paraíba e Alagoas",
                "Bahia e Sergipe",
                "Minas Gerais",
                "Rio de Janeiro e Espírito Santo",
                "São Paulo",
                "Paraná e Santa Catarina"
            };

            string[] region =
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

            for (var i = 0; i < 10; i++)
            {
                Assert.AreEqual(regionNames[i], CpfRegionCheck.RegionCpf(region[i]));
            }
        }
    }
}
