using System;
using static CpfValidation.Constants;

namespace CpfValidation
{
    class CpfFirstNumberValidator
    {
        public static bool CheckFirstValid(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.First)) * ValueToCalc.Ten)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Second)) * ValueToCalc.Nine)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Third)) * ValueToCalc.Eight)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Fourth)) * ValueToCalc.Seven)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Fifth)) * ValueToCalc.Six)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Sixth)) * ValueToCalc.Five)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Seventh)) * ValueToCalc.Four)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Eighth)) * ValueToCalc.Three)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, CpfDigit.Ninth)) * ValueToCalc.Two));
            double cpfValidationResult = (cpfValidationCalc * 10) % 11;
            if (cpfValidationResult == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 10)))
            {
                return true;
            }
            return false;
        }
    }
}
