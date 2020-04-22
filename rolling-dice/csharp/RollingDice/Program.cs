using System;

namespace RollingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's roll some dice, baby!");

            for (int i = 0; i < 10; i++)
            {
                Die die1 = Roll();
                Die die2 = Roll();

                string message = $"{die1} + {die2} == {die1.Value + die2.Value}";
                if (die1.Value == die2.Value)
                {
                    message += " DOUBLES!";
                }

                Console.WriteLine(message);
            }
        }

        static Die Roll()
        {
            int value = new Random().Next(1, 6);
            Die die = new Die()
            {
                Value = value
            };
            return die;
        }
    }

    public class Die
    {
        public int Value { get; set; }
        public override string ToString()
        {
            string dieString = "Unknown";
            switch (Value)
            {
                case 1:
                    dieString = "\u2680";
                    break;
                case 2:
                    dieString = "\u2681";
                    break;
                case 3:
                    dieString = "\u2682";
                    break;
                case 4:
                    dieString = "\u2683";
                    break;
                case 5:
                    dieString = "\u2684";
                    break;
                case 6:
                    dieString = "\u2685";
                    break;
            }

            return dieString;
        }
    }
}
