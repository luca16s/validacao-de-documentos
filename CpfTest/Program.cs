using System;
using CpfValidation;

namespace CpfTest
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira seu CPF: ");
            var userCpf = Console.ReadLine().Replace("-", "").Replace(".", "");
            var validationResults = CpfValidationClass.Validation(userCpf)
                                    && CpfValidationClass.CheckFalseSequences(userCpf)
                                    && CpfValidationClass.CheckLength(userCpf)
                                    && CpfValidationClass.CheckLetters(userCpf);
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