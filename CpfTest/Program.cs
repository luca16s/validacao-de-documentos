using System;
using CpfValidation;

namespace CpfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf;
            Console.WriteLine("Insira seu CPF: ");
            cpf = Console.ReadLine();
            if (CpfValidationClass.Validacao(cpf) == false)
            {
                Console.WriteLine("CPF Invalido!");
            }
            else
            {
                Console.WriteLine("CPF Valido!");
                Console.WriteLine(CpfValidationClass.EstadoCpf(cpf));
            }
            Console.ReadLine();
        }
    }
}