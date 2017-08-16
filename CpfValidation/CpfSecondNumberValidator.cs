using System;
using static CpfValidation.Constants;

namespace CpfValidation
{
    internal static class CpfSecondNumberValidator
    {
        public static bool CheckSecondValid(string cpf)
        {
            
            double cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Second)) * ValueToCalc.Ten)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.First)) * ValueToCalc.Eleven)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Third)) * ValueToCalc.Nine)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fourth)) * ValueToCalc.Eight)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fifth)) * ValueToCalc.Seven)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Sixth)) * ValueToCalc.Six)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Seventh)) * ValueToCalc.Five)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Eighth)) * ValueToCalc.Four)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Ninth)) * ValueToCalc.Three)
                                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Tenth)) * ValueToCalc.Two));
            double cpfValidationResult = (cpfValidationCalc * 10) % 11;
            if (cpfValidationResult == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, 11)) || cpfValidationResult == 10)
            {
                return true;
            }
            return false;
        }
    }
}
