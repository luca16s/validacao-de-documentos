using System;
using static CpfValidation.Constants;

namespace CpfValidation
{
    class CpfSecondNumberValidator
    {
        public static bool CheckSecondValid(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.First)) * ValueToCalc.Eleven)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Second)) * ValueToCalc.Ten)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Third)) * ValueToCalc.Nine)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Fourth)) * ValueToCalc.Eight)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Fifth)) * ValueToCalc.Seven)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Sixth)) * ValueToCalc.Six)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Seventh)) * ValueToCalc.Five)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Eighth)) * ValueToCalc.Four)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Ninth)) * ValueToCalc.Three)
                                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Tenth)) * ValueToCalc.Two));
            double cpfValidationResult = (cpfValidationCalc * 10) % 11;
            if (cpfValidationResult == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 11)) || cpfValidationResult == 10)
            {
                return true;
            }
            return false;
        }
    }
}
