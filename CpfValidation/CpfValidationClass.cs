namespace CpfValidation
{
    public static class CpfValidationClass
    {
        public static bool Validation(string cpf)
        {
            if (CpfFirstNumberValidator.CheckFirstValid(cpf).Equals(true) && CpfSecondNumberValidator.CheckSecondValid(cpf).Equals(true))
            {
                if (CheckCpfFalseSequenceNumbers.CheckFalseNumberSequences(cpf).Equals(false))
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
