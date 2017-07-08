using System;

namespace CpfValidation
{
    class CheckCpfFalseSequenceNumbers
    {
        public static class Constants
        {
            public const string ZERO = "00000000000";
            public const string ONE = "11111111111";
            public const string TWO = "22222222222";
            public const string THREE = "33333333333";
            public const string FOUR = "44444444444";
            public const string FIVE = "55555555555";
            public const string SIX = "66666666666";
            public const string SEVEN = "77777777777";
            public const string EIGHT = "88888888888";
            public const string NINE = "99999999999";
        }
        public static bool CheckFalseNumberSequences(string _cpf)
        {
            switch (_cpf)
            {
                case Constants.ZERO:
                    return true;
                case Constants.ONE:
                    return true;
                case Constants.TWO:
                    return true;
                case Constants.THREE:
                    return true;
                case Constants.FOUR:
                    return true;
                case Constants.FIVE:
                    return true;
                case Constants.SIX:
                    return true;
                case Constants.SEVEN:
                    return true;
                case Constants.EIGHT:
                    return true;
                case Constants.NINE:
                    return true;
                default:
                    return false;
            }
        }
    }
}
