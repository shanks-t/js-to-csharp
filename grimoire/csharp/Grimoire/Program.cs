using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Do you believe in magic?");
Console.WriteLine("------------------------");

List<Spell> allSpells = GetAllSpells();
SpellBook goodBook = MakeGoodSpellBook(allSpells);
SpellBook evilBook = MakeEvilSpellBook(allSpells);

DisplaySpellBook(goodBook);
Console.WriteLine();
DisplaySpellBook(evilBook);


void DisplaySpellBook(SpellBook book)
{
    Console.WriteLine(book.Title);
    foreach (Spell aSpell in book.Spells)
    {
        Console.WriteLine($"  {aSpell.Name}");
    }
}


SpellBook MakeEvilSpellBook(List<Spell> allSpells)
{
    SpellBook evilBook = new SpellBook();
    evilBook.Title = "Evil Book";
    evilBook.Spells = allSpells.Where(spell => spell.IsEvil).ToList();

    return evilBook;
}


SpellBook MakeGoodSpellBook(List<Spell> allSpells)
{
    SpellBook goodBook = new SpellBook();
    goodBook.Title = "Good Book";
    goodBook.Spells = allSpells.Where(spell => !spell.IsEvil).ToList();

    return goodBook;
}


List<Spell> GetAllSpells()
{
    List<Spell> allSpells = new List<Spell>() {
        new Spell() {
            Name = "Turn enemy into a newt",
            IsEvil = true,
            EnergyReqired = 5.1
        },
        new Spell() {
            Name = "Conjure some gold for a local charity",
            IsEvil = false,
            EnergyReqired = 2.99
        },
        new Spell() {
            Name = "Give a deaf person the ability to heal",
            IsEvil = false,
            EnergyReqired = 12.2
        },
        new Spell() {
            Name = "Make yourself emperor of the universe",
            IsEvil = true,
            EnergyReqired = 100.0
        },
        new Spell() {
            Name = "Convince your relatives your political views are correct",
            IsEvil = false,
            EnergyReqired = 2921.5
        }
    };

    return allSpells;
}

public class SpellBook
{
    public string Title { get; set; }
    public List<Spell> Spells { get; set; }
}

public class Spell
{
    public string Name { get; set; }
    public bool IsEvil { get; set; }
    public double EnergyReqired { get; set; }
}
