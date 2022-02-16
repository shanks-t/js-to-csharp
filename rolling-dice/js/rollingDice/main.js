// Put your code here

console.log("let's roll some dice!");
const Roll = () => {
  const dieValue = Math.floor(Math.random() * 6);
  const die = new Die(dieValue);
  return die;
};

class Die {
  constructor(value) {
    this.value = value;
  }

  get string() {
    let dieString = "unknown";

    switch (this.value) {
      case 1:
        dieString = "one";
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

for (let i = 0; i < 10; i++) {
  let die1 = Roll();
  let die2 = Roll();

  let message = `${die1.value} + ${die2.value} == ${die1.value + die2.value}`;
  if (die1.value === die2.value) {
    message += " DOUBLES!";
  }
  console.log(message);
}
