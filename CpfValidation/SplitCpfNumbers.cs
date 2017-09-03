using System;
using System.Text.RegularExpressions;

namespace CpfValidation
{
    internal static class SplitCpfNumbers
    {
        public static string SplitNumbers(string cpf, int controllNumber)
        {
            var dividedNumber = Regex.Split(cpf.Replace("-", "").Replace(".", ""), "") ?? throw new ArgumentNullException(nameof(cpf));
            return dividedNumber[controllNumber];
        }
    }
}
