// Put your code here
const listEnemies = () => {
  for (const e of enemies) {
    if (e.isReallyHated) {
      console.log(`${e.firstName} ${e.lastName} (Really disliked)`);
    } else {
      console.log(e.firstName + e.lastName);
    }
  }
};

const enemies = [];

class Enemy {
  constructor(firstName, lastName, offenses, isReallyHated) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.offenses = offenses;
    this.isReallyHated = isReallyHated;
  }
  get info() {
    return this.firstName + this.lastName;
  }
}

enemies.push(
  new Enemy("josh", "flowers", ["being a jerk", "not being nice"], true),
  new Enemy("darth", "vader", ["choking people with the force"], false)
);

listEnemies();
