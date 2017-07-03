using System;
using CpfValidation;

namespace CpfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserCpf;
            Console.WriteLine("Insira seu CPF: ");
            UserCpf = Console.ReadLine();
            if (CpfValidationClass.Validation(UserCpf.Replace("-", "").Replace(".", "")) == false)
            {
                Console.WriteLine("CPF Invalido!");
            }
            else
            {
                Console.WriteLine("CPF Valido!");
                Console.WriteLine(CpfRegionCheck.RegionCpf(UserCpf.Replace("-", "").Replace(".", "")));
            }
            Console.ReadLine();
        }
    }
}