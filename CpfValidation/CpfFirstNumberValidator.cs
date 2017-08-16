using System;
using static CpfValidation.Constants;

namespace CpfValidation
{
    static class CpfFirstNumberValidator
    {
        public static bool CheckFirstValid(string cpf)
        {
            double cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.First)) * ValueToCalc.Ten)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Second)) * ValueToCalc.Nine)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Third)) * ValueToCalc.Eight)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fourth)) * ValueToCalc.Seven)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Fifth)) * ValueToCalc.Six)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Sixth)) * ValueToCalc.Five)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Seventh)) * ValueToCalc.Four)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Eighth)) * ValueToCalc.Three)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, CpfDigit.Ninth)) * ValueToCalc.Two));
            double cpfValidationResult = (cpfValidationCalc * 10) % 11;
            if (cpfValidationResult == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(cpf, 10)))
            {
                return true;
            }
            return false;
        }
    }
}
