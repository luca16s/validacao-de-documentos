using System;
using CpfValidation;

namespace CpfTest
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira seu CPF: ");
            var userCpf = Console.ReadLine();
            var validationResults = CpfValidationClass.Validation(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckFalseSequences(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckLength(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckLetters(userCpf.Replace("-", "").Replace(".", ""));
            if (validationResults)
            {
                Console.WriteLine("CPF Valido!");
                Console.WriteLine(CpfRegionCheck.RegionCpf(userCpf.Replace("-", "").Replace(".", "")));
            }
            else
            {
                Console.WriteLine("CPF Invalido!");
            }
            Console.ReadLine();
        }
    }
}