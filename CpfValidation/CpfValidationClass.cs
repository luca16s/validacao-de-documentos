namespace CpfValidation
{
    public static class CpfValidationClass
    {
        public static bool Validation(string _cpf)
        {
            if (CpfFirstNumberValidator.CheckFirstValid(_cpf).Equals(true) && CpfSecondNumberValidator.CheckSecondValid(_cpf).Equals(true))
            {
                if (CheckCpfFalseSequenceNumbers.CheckFalseNumberSequences(_cpf).Equals(false))
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
    }
}
