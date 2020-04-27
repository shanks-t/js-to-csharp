# Rolling Dice

Simulate rolling a pair of dice.

> **NOTE:** To get a random integer between 1 and 6 in JavaScript, use the following function.  
> Source: https://stackoverflow.com/questions/1527803/generating-random-whole-numbers-in-javascript-in-a-specific-range
```js
function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
```
