using System;
using System.Collections.Generic;

namespace CoffeeMachineTDDKata
{
    public static class Command
    {
        public static Dictionary<String, String> Products = new Dictionary<String, String>()
        {
            { "T", "tea" },
            { "H", "chocolate" },
            { "C", "coffee" }
        };

        public static Dictionary<String, String> Sugar = new Dictionary<String, String>()
        {
            { "1", "1 sugar" },
            { "2", "2 sugars" },
            { "", "no sugar" }
        };

        public static Dictionary<String, String> Stick = new Dictionary<String, String>()
        {
            { "0", "a" },
            { "", "therefore no" }
        };

        public const String message = "(Drink maker makes 1 {0} with {1} and {2} stick)";
    }
}
