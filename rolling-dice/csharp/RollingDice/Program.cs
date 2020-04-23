using System;

namespace RollingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's roll some dice, baby!");
            Console.WriteLine("---------------------------");

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
            int dieValue = new Random().Next(1, 6);
            Die die = new Die(dieValue);
            return die;
        }
    }

    public class Die
    {
        public int Value { get; set; }

        public Die(int value)
        {
            this.Value = value;
        }

        // This method is automatically called when we create the "message" variable above
        // By the way, a JavaScript object can have a toString() method too...
        public override string ToString()
        {
            string dieString = "Unknown";
            switch (this.Value)
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
