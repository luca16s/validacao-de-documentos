using System;
using System.Globalization;
using static CpfValidation.Constants;
using static CpfValidation.Constants.ValueToCalc;

namespace CpfValidation
{
    internal static class CpfSecondNumberValidator
    {
        public static bool CheckSecondValid(string cpf)
        {
            double cpfValidationCalc;
            cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Second)) * Ten)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.First)) * Eleven)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Third)) * Nine)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fourth)) * Eight)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fifth)) * Seven)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Sixth)) * Six)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Seventh)) * Five)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Eighth)) * Four)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Ninth)) * Three)
                                 + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Tenth)) * Two));

            double cpfValidationResult;
            cpfValidationResult = (cpfValidationCalc * 10) % 11;

            if (cpfValidationResult.ToString(CultureInfo.InvariantCulture) == SplitCpfNumbers.SplitNumbers(cpf, 11) 
                || cpfValidationResult.ToString(CultureInfo.InvariantCulture) == "10")
            {
                return true;
            }
            return false;
        }
    }
}
