using System;
using static CpfValidation.Constants;

namespace CpfValidation
{
    class CheckCpfFalseSequenceNumbers
    {
        public static bool CheckFalseNumberSequences(string _cpf)
        {
            switch (_cpf)
            {
                case CpfFalseSequenceNumbers.ZERO:
                    return true;
                case CpfFalseSequenceNumbers.ONE:
                    return true;
                case CpfFalseSequenceNumbers.TWO:
                    return true;
                case CpfFalseSequenceNumbers.THREE:
                    return true;
                case CpfFalseSequenceNumbers.FOUR:
                    return true;
                case CpfFalseSequenceNumbers.FIVE:
                    return true;
                case CpfFalseSequenceNumbers.SIX:
                    return true;
                case CpfFalseSequenceNumbers.SEVEN:
                    return true;
                case CpfFalseSequenceNumbers.EIGHT:
                    return true;
                case CpfFalseSequenceNumbers.NINE:
                    return true;
                default:
                    return false;
            }
        }
    }
}
