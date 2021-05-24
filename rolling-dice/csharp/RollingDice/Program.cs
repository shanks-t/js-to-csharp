using System;

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


// Function to "roll" a die
//  Generates a random number between 1 and 6
//  Constructs a new Die object with the random number as it's value
Die Roll()
{
    int dieValue = new Random().Next(1, 6);
    Die die = new Die(dieValue);
    return die;
}

// This class is used to define a "die" object (a single "dice")
//  Each die will have a value. This value is the number that the
//  die "landed on" when it was rolled.
public class Die
{
    // A place to store the numeric "value" of a Die object
    public int Value { get; set; }

    // When we construct a new Die object, this method is called
    //  We call this kind of method a "constructor"
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
                dieString = "one";
            }
            */
            case 1:
                dieString = "one"; // These \uXXXX values are fancy unicode characters
                break;
            case 2:
                dieString = "two";
                break;
            case 3:
                dieString = "three";
                break;
            case 4:
                dieString = "four";
                break;
            case 5:
                dieString = "five";
                break;
            case 6:
                dieString = "six";
                break;
        }

        return dieString;
    }
}
