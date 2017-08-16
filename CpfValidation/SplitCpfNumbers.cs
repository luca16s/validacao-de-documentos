using System.Text.RegularExpressions;

namespace CpfValidation
{
    static class SplitCpfNumbers
    {
        public static string SplitNumbers(string cpf, int controllNumber)
        {
            string[] dividedNumber = Regex.Split(cpf.Replace("-", "").Replace(".", ""), "");
            return dividedNumber[controllNumber];
        }
    }
}
