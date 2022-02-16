// Put your code here

console.log("Do you believe in magic?");

class Spell {
  constructor(name, isEvil, energyRequired) {
    this.name = name;
    this.isEvil = isEvil;
    this.energyRequired = energyRequired;
  }
}

class SpellBook {
  constructor(title, spells) {
    this.title = title;
    this.spells = spells;
  }
}

const getAllSpells = () => {
  spells = [];

  spells.push(
    new Spell("Turn enemy into a newt", true, 5.1),
    new Spell("Conjure some gold for a local charity", false, 2.99),
    new Spell("Give a deaf person the ability to heal", false, 12.2),
    new Spell("Make yourself emperor of the universe", true, 100.0)
  );

  return spells;
};

const makeGoodSpellBook = (allSpells) => {
  const goodBook = new SpellBook();
  goodBook.title = "Good Book";
  goodBook.spells = allSpells.filter((spell) => !spell.isEvil);
  return goodBook;
};
const makeEvilSpellBook = (allSpells) => {
  const evilBook = new SpellBook();
  evilBook.title = "Evil Book";
  evilBook.spells = allSpells.filter((spell) => spell.isEvil);
  return evilBook;
};

const displaySpellBook = (book) => {
  console.log(book.title);
  for (spell of book.spells) {
    console.log(` ${spell.name}`);
  }
};
const allSpells = getAllSpells();
const goodBook = makeGoodSpellBook(allSpells);
const evilBook = makeEvilSpellBook(allSpells);
console.log(goodBook);
displaySpellBook(goodBook);
displaySpellBook(evilBook);
