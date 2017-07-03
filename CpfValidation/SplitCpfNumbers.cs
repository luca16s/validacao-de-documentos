using System.Text.RegularExpressions;

namespace CpfValidation
{
    class SplitCpfNumbers
    {
        public static string SplitNumbers(string _cpf, int controle)
        {
            string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            return numerosDivididos[controle];
        }
    }
}
