Validação de CPF
================

## Project status
Bulid Status|License|
------------|-------|
[![Build Status](https://travis-ci.org/luca16s/Validacao-de-CPF.svg?branch=master)](https://travis-ci.org/luca16s/Validacao-de-CPF) | [![License](https://img.shields.io/badge/LICENSE-MIT-orange.svg)]() |

:us:
### About this project
Library to validate Brazilian CPF numbers.
As well this libs can return the region where CPF is created.

### How to use
Simple add reference to your project and call the function Validation() who are inside CpfValidationClass.cs;
They'll return true if the number is correct. If the number is incorrect they'll return false.


<span>&#x1f1e7;&#x1f1f7;</span>
### Sobre este projeto
Biblioteca para validar números de CPF.
Pode também retornar a região que o CPF foi cadastrado.

### Como usar
Adicione a referência ao seu projeto e chame a função Validation() que está dentro da classe CpfValidationClass.cs;
Ela irá retornar verdadeiro se a numeração do CPF estiver correta. Se estiver errada ira retornar falso.

#### Exemple

```csharp
using System;
using CpfValidation;

namespace CpfTest
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira seu CPF|Insert your CPF: ");
            var userCpf = Console.ReadLine();
            var validationResults = CpfValidationClass.Validation(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckFalseSequences(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckLength(userCpf.Replace("-", "").Replace(".", ""))
                                    && CpfValidationClass.CheckLetters(userCpf.Replace("-", "").Replace(".", ""));
            if (validationResults)
            {
                Console.WriteLine("CPF Valido|Valid!");
                Console.WriteLine(CpfRegionCheck.RegionCpf(userCpf.Replace("-", "").Replace(".", "")));
            }
            else
            {
                Console.WriteLine("CPF Invalido|Invalid!");
            }
            Console.ReadLine();
        }
    }
}
```
