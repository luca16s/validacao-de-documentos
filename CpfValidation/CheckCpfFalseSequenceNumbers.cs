namespace CpfValidation
{
    class CheckCpfFalseSequenceNumbers
    {
        public static bool CheckFalseNumberSequences(string _cpf)
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
                            else
                            {
                                if (_cpf.Equals(CpfFalsos.GetValue(5)))
                                {
                                    return true;
                                }
                                else
                                {
                                    if (_cpf.Equals(CpfFalsos.GetValue(6)))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        if (_cpf.Equals(CpfFalsos.GetValue(7)))
                                        {
                                            return true;
                                        }
                                        else
                                        {
                                            if (_cpf.Equals(CpfFalsos.GetValue(8)))
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                if (_cpf.Equals(CpfFalsos.GetValue(9)))
                                                {
                                                    return true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
    }
}
