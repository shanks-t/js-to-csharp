// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Specify the Type of the "wishes" variable.
// A List that can only contain "strings".
List<string> wishes = new List<string> {
      "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
    "The ability to think of interesting wishes on short notice",
    "A washtub of Skittles",
    "World peace, but not the kind of world peace where all the humans are removed from existence",
    "A TV that is NOT internet-capable",
    "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
 };

Console.WriteLine("My wishes...");

foreach (string wish in wishes)
{
    Console.WriteLine(wish);
}

