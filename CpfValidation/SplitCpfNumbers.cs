using System.Text.RegularExpressions;

namespace CpfValidation
{
    class SplitCpfNumbers
    {
        public static string SplitNumbers(string _cpf, int controll)
        {
            string[] DividedNumber = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            return DividedNumber[controll];
        }
    }
}
