using System;
using CpfValidation;
using static CpfValidation.CpfValidationClass;

namespace CpfTest
{
    static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Insira seu CPF: ");
            var userCpf = Console.ReadLine().Replace("-", "").Replace(".", "");
            var validationResults = CheckLength(userCpf)
                                    && CheckFalseSequences(userCpf)
                                    && CheckLetters(userCpf)
                                    && Validation(userCpf);
            if (validationResults)
            {
                Console.WriteLine("CPF Valido!");
                Console.WriteLine(CpfRegionCheck.RegionCpf(userCpf));
            }
            else
            {
                Console.WriteLine("CPF Invalido!");
            }
            Console.ReadLine();
        }
    }
}