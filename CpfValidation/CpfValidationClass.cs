using System;
using System.Text.RegularExpressions;

namespace CpfValidation
{
    public static class CpfValidationClass
    {
        public static bool Validation(string _cpf)
        {
            bool checkCpfLength = _cpf.Length < 11 || _cpf.Length > 11;
            if (checkCpfLength)
                throw new ArgumentException("O CPF deve conter 11 dígitos!");

            bool checkCpfcharacters = Regex.IsMatch(_cpf, @"^\d+$") == false;
            if(checkCpfcharacters)
                throw new ArgumentException("O CPF só deve conter números!");

            bool checkFalseSequences = CheckCpfFalseSequenceNumbers.CheckFalseNumberSequences(_cpf).Equals(false);
            if (checkFalseSequences)
            {
                bool checkValidatorNumbers = CpfFirstNumberValidator.CheckFirstValid(_cpf).Equals(true) && CpfSecondNumberValidator.CheckSecondValid(_cpf).Equals(true);
                if (checkValidatorNumbers)
                    return true;
                return false;
            }
            return false;
        }
    }
}
