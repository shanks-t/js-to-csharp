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

    // This class is used to define a "die" object (a single "dice")
    //  Each die will have a value. This value is the number that the
    //  die "landed on" when it was rolled.
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

            // This "switch" statement behaves like a series of "if/else if" statements.
            //  We compare the numeric Value of the current object accross different "cases".
            //  When we find a matching case we return a string that represents an image of a die
            // Did you kow that JavaScript also has "switch" statements?
            switch (this.Value)
            {
                /* "case 1:" is like the following "if" statement
                if (this.Value == 1) {
                    dieString = "\u2680";
                }
                */
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
