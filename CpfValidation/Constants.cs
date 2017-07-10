using System;
using System.Collections.Generic;
using System.Text;

namespace CpfValidation
{
    class Constants
    {
        public static class CpfDigit
        {
            public const int First = 1;
            public const int Second = 2;
            public const int Third = 3;
            public const int Fourth = 4;
            public const int Fifth = 5;
            public const int Sixth = 6;
            public const int Seventh = 7;
            public const int Eighth = 8;
            public const int Ninth = 9;
            public const int Tenth = 10;
        }

        public static class ValueToCalc
        {
            public const int Eleven = 11;
            public const int Ten = 10;
            public const int Nine = 9;
            public const int Eight = 8;
            public const int Seven = 7;
            public const int Six = 6;
            public const int Five = 5;
            public const int Four = 4;
            public const int Three = 3;
            public const int Two = 2;
        }

        public static class CpfFalseSequenceNumbers
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
    }
}
