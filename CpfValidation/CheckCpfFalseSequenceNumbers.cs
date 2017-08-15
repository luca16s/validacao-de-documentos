using static CpfValidation.Constants;

namespace CpfValidation
{
    static class CheckCpfFalseSequenceNumbers
    {
        public static bool CheckFalseNumberSequences(string cpf)
        {
            switch (cpf)
            {
                case CpfFalseSequenceNumbers.Zero:
                    return true;
                case CpfFalseSequenceNumbers.One:
                    return true;
                case CpfFalseSequenceNumbers.Two:
                    return true;
                case CpfFalseSequenceNumbers.Three:
                    return true;
                case CpfFalseSequenceNumbers.Four:
                    return true;
                case CpfFalseSequenceNumbers.Five:
                    return true;
                case CpfFalseSequenceNumbers.Six:
                    return true;
                case CpfFalseSequenceNumbers.Seven:
                    return true;
                case CpfFalseSequenceNumbers.Eight:
                    return true;
                case CpfFalseSequenceNumbers.Nine:
                    return true;
                default:
                    return false;
            }
        }
    }
}
