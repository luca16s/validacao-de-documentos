using System;
using CpfValidation;

namespace CpfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf;
            cpf = Console.ReadLine();
            if (CpfValidationClass.Validacao(cpf) == false)
            {
                Console.WriteLine("CPF Invalido!");
            }
            else
            {
                Console.WriteLine("CPF Valido!");
            }
            Console.ReadLine();
        }
    }
}