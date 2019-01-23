using System;

namespace CoffeeMachineTDDKata
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(String command)
            : base("command not valid " + command)
        {
        }
    }
}