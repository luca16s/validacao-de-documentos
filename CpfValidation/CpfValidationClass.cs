using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CpfValidation
{
    public static class CpfValidationClass
    {
        public static bool Validacao(string cpf)
        {
            if (ValidaPrimeiro(cpf).Equals(true) && ValidaSegundo(cpf).Equals(true))
            {
                if (ValidaConhecidos(cpf).Equals(false))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidaConhecidos(string _cpf)
        {
            string[] CpfFalsos = new string[10] {
                            "00000000000",
                                "11111111111",
                                    "22222222222",
                                        "33333333333",
                                            "44444444444",
                                                "55555555555",
                                                    "66666666666",
                                                        "77777777777",
                                                            "88888888888",
                                                                "99999999999" };
            if (_cpf.Equals(CpfFalsos.GetValue(0)))
            {
                return true;
            }
            else
            {
                if (_cpf.Equals(CpfFalsos.GetValue(1)))
                {
                    return true;
                }
                else
                {
                    if (_cpf.Equals(CpfFalsos.GetValue(2)))
                    {
                        return true;
                    }
                    else
                    {
                        if (_cpf.Equals(CpfFalsos.GetValue(3)))
                        {

                        }
                        else
                        {
                            if (_cpf.Equals(CpfFalsos.GetValue(4)))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public static string SeparaNumeros(string _cpf, int controle)
        {
            string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            return numerosDivididos[controle];
        }

        public static bool ValidaPrimeiro(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double resultA = ((Convert.ToDouble(SeparaNumeros(_cpf, 1)) * 10)
                + (Convert.ToDouble(SeparaNumeros(_cpf, 2)) * 9)
                    + (Convert.ToDouble(SeparaNumeros(_cpf, 3)) * 8)
                        + (Convert.ToDouble(SeparaNumeros(_cpf, 4)) * 7)
                            + (Convert.ToDouble(SeparaNumeros(_cpf, 5)) * 6)
                                + (Convert.ToDouble(SeparaNumeros(_cpf, 6)) * 5)
                                    + (Convert.ToDouble(SeparaNumeros(_cpf, 7)) * 4)
                                        + (Convert.ToDouble(SeparaNumeros(_cpf, 8)) * 3)
                                            + (Convert.ToDouble(SeparaNumeros(_cpf, 9)) * 2));
            double resultB = (resultA * 10) % 11;
            if (resultB == Convert.ToDouble(SeparaNumeros(_cpf, 10)))
            {
                return true;
            }
            return false;
        }

        public static bool ValidaSegundo(string _cpf)
        {
            //string[] numerosDivididos = Regex.Split(_cpf.Replace("-", "").Replace(".", ""), "");
            double resultA = ((Convert.ToDouble(SeparaNumeros(_cpf, 1)) * 11)
                + (Convert.ToDouble(SeparaNumeros(_cpf, 2)) * 10)
                    + (Convert.ToDouble(SeparaNumeros(_cpf, 3)) * 9)
                        + (Convert.ToDouble(SeparaNumeros(_cpf, 4)) * 8)
                            + (Convert.ToDouble(SeparaNumeros(_cpf, 5)) * 7)
                                + (Convert.ToDouble(SeparaNumeros(_cpf, 6)) * 6)
                                    + (Convert.ToDouble(SeparaNumeros(_cpf, 7)) * 5)
                                        + (Convert.ToDouble(SeparaNumeros(_cpf, 8)) * 4)
                                            + (Convert.ToDouble(SeparaNumeros(_cpf, 9)) * 3)
                                                + (Convert.ToDouble(SeparaNumeros(_cpf, 10)) * 2));
            double resultB = (resultA * 10) % 11;
            if (resultB == Convert.ToDouble(SeparaNumeros(_cpf, 11)))
            {
                return true;
            }
            return false;
        }

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

            return "";
        }
    }
}
