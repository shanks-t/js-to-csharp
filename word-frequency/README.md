# Word Frequency

Count the occupance of each word in Carl Sagan's famous description of the _Pale Blue Dot_.

> https://en.wikipedia.org/wiki/Pale_Blue_Dot

## NOTES

You might want to research the `Dictionary` type in C#, including the `ContainsKey()` method.  

In order to remove punctuation from a string in C#, use the `Regex` class.

First you must use the proper namespace.

```cs
using System.Text.RegularExpressions;
```

Then later in your code you can do something like this:

```cs
string s1 = Regex.Replace(s, "[^A-Za-z ]", "");
```