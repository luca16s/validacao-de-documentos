namespace CpfValidation
{
    class Constants
    {
        public static class CpfDigit
        {
            public static int First { get; } = 1;
            public static int Second { get; } = 2;
            public static int Third { get; } = 3;
            public static int Fourth { get; } = 4;
            public static int Fifth { get; } = 5;
            public static int Sixth { get; } = 6;
            public static int Seventh { get; } = 7;
            public static int Eighth { get; } = 8;
            public static int Ninth { get; } = 9;
            public static int Tenth { get; } = 10;
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
            public const string Zero = "00000000000";
            public const string One = "11111111111";
            public const string Two = "22222222222";
            public const string Three = "33333333333";
            public const string Four = "44444444444";
            public const string Five = "55555555555";
            public const string Six = "66666666666";
            public const string Seven = "77777777777";
            public const string Eight = "88888888888";
            public const string Nine = "99999999999";
        }
    }
}
