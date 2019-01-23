using System;

namespace CoffeeMachineTDDKata
{
    public class DrinkMaker
    {
        public String Make(String command)
        {
            var commandParsed = this.ParseCommand(command);

            if (commandParsed.Length != 3)
                throw new InvalidCommandException(command);

            var product = this.GetProduct(commandParsed[0]);

            var sugar = this.GetSugar(commandParsed[1]);

            var stick = this.GetStick(commandParsed[2]);

            return String.Format(Command.message, product, sugar, stick);
        }

        private String GetProduct(String positionCero)
        {
            return Command.Products[positionCero];
        }

        private String GetSugar(String positionOne)
        {
            return Command.Sugar[positionOne];
        }

        private String GetStick(String positionTwo)
        {
            return Command.Stick[positionTwo];
        }

        private String[] ParseCommand(String command)
        {
            return command.Split(':');
        }
    }
}