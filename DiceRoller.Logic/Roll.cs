using System;

namespace DiceRoller.Logic
{
    public class Roll
    {
        public Roll()
        {

        }

        public int RollDice(int numberOfSides)
        {
            var random = new Random();
            return random.Next(1, numberOfSides);
        }
    }
}
