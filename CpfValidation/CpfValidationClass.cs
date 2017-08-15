using System;
using System.Security.Cryptography.X509Certificates;
using static System.Text.RegularExpressions.Regex;

namespace CpfValidation
{
    public class CpfValidationClass
    {
        public static bool CheckLength(string cpf)
        {
            var checkCpfLength = cpf.Length < 11 || cpf.Length > 11;
            if (checkCpfLength)
                return false;
            return true;
        }

        public static bool CheckLetters(string cpf)
        {
            var checkCpfcharacters = IsMatch(cpf, @"^\d+$") == false;
            if (checkCpfcharacters)
                return false;
            return true;
        }

        public static bool CheckFalseSequences(string cpf)
        {
            var checkFalseSequences = CheckCpfFalseSequenceNumbers.CheckFalseNumberSequences(cpf).Equals(false);
            if (checkFalseSequences) return true;
            return false;
        }

        public static bool Validation(string cpf)
        {
            var checkValidatorNumbers = CpfFirstNumberValidator.CheckFirstValid(cpf).Equals(true) && CpfSecondNumberValidator.CheckSecondValid(cpf).Equals(true);
            return checkValidatorNumbers;
        }
    }
}
