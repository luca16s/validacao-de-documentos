using System;
using System.Collections.Generic;

namespace CpfValidation
{
    public static class CpfRegionCheck
    {
        public static string EstadoCpf(string _cpf)
        {
            List<string> estados = new List<string>();
            estados.Add("Rio Grande do Sul");
            estados.Add("Distrito Federal, Goiás, Mato Grosso do Sul e Tocantins");
            estados.Add("Pará, Amazonas, Acre, Amapá, Rondônia e Roraima");
            estados.Add("Ceará, Maranhão e Piauí");
            estados.Add("Pernambuco, Rio Grande do Norte, Paraíba e Alagoas");
            estados.Add("Bahia e Sergipe");
            estados.Add("Minas Gerais");
            estados.Add("Rio de Janeiro e Espírito Santo");
            estados.Add("São Paulo");
            estados.Add("Paraná e Santa Catarina");

            return estados[Convert.ToInt32(SplitCpfNumbers.SplitNumbers(_cpf, 9))];
        }
    }
}
