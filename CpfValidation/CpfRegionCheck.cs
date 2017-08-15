using System;
using System.Collections.Generic;

namespace CpfValidation
{
    public static class CpfRegionCheck
    {
        public static string RegionCpf(string cpf)
        {
            var region = new List<string>
            {
                "Rio Grande do Sul",
                "Distrito Federal, Goiás, Mato Grosso do Sul e Tocantins",
                "Pará, Amazonas, Acre, Amapá, Rondônia e Roraima",
                "Ceará, Maranhão e Piauí",
                "Pernambuco, Rio Grande do Norte, Paraíba e Alagoas",
                "Bahia e Sergipe",
                "Minas Gerais",
                "Rio de Janeiro e Espírito Santo",
                "São Paulo",
                "Paraná e Santa Catarina"
            };

            return region[Convert.ToInt32(SplitCpfNumbers.SplitNumbers(cpf, 9))];
        }
    }
}
