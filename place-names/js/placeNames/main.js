// Put your code here

const names = [
  "Nashville",
  "Hong Kong",
  "The back yard",
  "Earth",
  "London",
  "The mall",
  "Ryman Auditorium",
  "The Great Wall of China",
];

console.log("All Pace Names");

for (const name of names) {
  console.log(name);
}

const filteredNames = names.filter((n) => n.startsWith("The"));
console.log(filteredNames);
console.log("filtered names");
for (const name of filteredNames) {
  console.log(name);
}
