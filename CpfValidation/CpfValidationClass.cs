using static System.Text.RegularExpressions.Regex;

namespace CpfValidation
{
    public static class CpfValidationClass
    {
        public static bool CheckLength(string cpf)
        {
            bool checkCpfLength;
            checkCpfLength = cpf.Length < 11 || cpf.Length > 11;

            if (checkCpfLength)
                return false;
            return true;
        }

        public static bool CheckLetters(string cpf)
        {
            bool checkCpfcharacters;
            checkCpfcharacters = IsMatch(cpf, @"^\d+$") == false;

            if (checkCpfcharacters)
                return false;
            return true;
        }

        public static bool CheckFalseSequences(string cpf)
        {
            bool checkFalseSequences;
            checkFalseSequences = CheckCpfFalseSequenceNumbers.CheckFalseNumberSequences(cpf).Equals(false);

            if (checkFalseSequences)
                return true;
            return false;
        }

        public static bool Validation(string cpf)
        {
            bool checkValidatorNumbers;
            checkValidatorNumbers = CpfFirstNumberValidator.CheckFirstValid(cpf).Equals(true) &&
                                    CpfSecondNumberValidator.CheckSecondValid(cpf).Equals(true);

            return checkValidatorNumbers;
        }
    }
}
