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
                "RS",
                "DF, GO, MS e TO",
                "PA, AM, AC, AM, RO e RR",
                "CE, MA e PI",
                "PE, RN, PB e AL",
                "BA e SE",
                "MG",
                "RJ e ES",
                "SP",
                "PR e SC"
            };

            return region[Convert.ToInt32(SplitCpfNumbers.SplitNumbers(cpf, 9))];
        }
    }
}
