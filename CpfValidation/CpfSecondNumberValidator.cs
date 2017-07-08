using System;

namespace CpfValidation
{
    class CpfSecondNumberValidator
    {
        public static bool CheckSecondValid(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double cpfValidationCalc = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 1)) * 11)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 2)) * 10)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 3)) * 9)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 4)) * 8)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 5)) * 7)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 6)) * 6)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 7)) * 5)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 8)) * 4)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 9)) * 3)
                                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 10)) * 2));
            double cpfValidationResult = (cpfValidationCalc * 10) % 11;
            if (cpfValidationResult == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 11)) || cpfValidationResult == 10)
            {
                return true;
            }
            return false;
        }
    }
}
