using System.Text.RegularExpressions;

namespace CpfValidation
{
    class SplitCpfNumbers
    {
        public static string SplitNumbers(string _cpf, int controllNumber)
        {
            string[] dividedNumber = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            return dividedNumber[controllNumber];
        }
    }
}
