using System;

namespace CpfValidation
{
    class CpfFirstNumberValidator
    {
        public static bool CheckFirstValid(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double resultA = ((Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 1)) * 10)
                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 2)) * 9)
                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 3)) * 8)
                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 4)) * 7)
                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 5)) * 6)
                                + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 6)) * 5)
                                    + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 7)) * 4)
                                        + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 8)) * 3)
                                            + (Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 9)) * 2));
            double resultB = (resultA * 10) % 11;
            if (resultB == Convert.ToDouble(SplitCpfNumbers.SplitNumbers(_cpf, 10)))
            {
                return true;
            }
            return false;
        }
    }
}
