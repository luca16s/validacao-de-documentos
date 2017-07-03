using System;
using System.Collections.Generic;

namespace CpfValidation
{
    public static class CpfRegionCheck
    {
        public static string RegionCpf(string _cpf)
        {
            List<string> Region = new List<string>();
            Region.Add("Rio Grande do Sul");
            Region.Add("Distrito Federal, Goiás, Mato Grosso do Sul e Tocantins");
            Region.Add("Pará, Amazonas, Acre, Amapá, Rondônia e Roraima");
            Region.Add("Ceará, Maranhão e Piauí");
            Region.Add("Pernambuco, Rio Grande do Norte, Paraíba e Alagoas");
            Region.Add("Bahia e Sergipe");
            Region.Add("Minas Gerais");
            Region.Add("Rio de Janeiro e Espírito Santo");
            Region.Add("São Paulo");
            Region.Add("Paraná e Santa Catarina");

            return Region[Convert.ToInt32(SplitCpfNumbers.SplitNumbers(_cpf, 9))];
        }
    }
}
