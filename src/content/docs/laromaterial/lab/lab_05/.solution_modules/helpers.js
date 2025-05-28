/**
 * @param {*} item1 The first item to use.
 * @param {*} item2 The second item to use.
 * @returns {number|string} The result from your function.
 */
function sumTwoValues(item1, item2) {
  let result = "Error"

  if (typeof(item1) === "number" && typeof(item2) === "number") {
    result = item1 + item2
  }

  return result
}



/**
 * @param {*} word The string to use.
 * @returns {string} The result from your function.
 */
function changeLetters(word) {
  let result = ""

  for (const char of word) {
    result += char === char.toLowerCase() ? char.toUpperCase() : char.toLowerCase()
  }

  return result
}



/**
 * @param {string} word The string to use.
 * @param {number} times The amount of times to repeat the word.
 * @returns {string} The result from your function.
 */
function repeatWord(word, times) {
  return word.repeat(times)
}



/**
 * @param {string} word The string to use.
 * @returns {boolean} The result from your function.
 */
function isPalindrome(word) {
  let fixedLetters = word.toLowerCase().split("")
  
  return fixedLetters.join("") === fixedLetters.reverse().join("")
}



/**
 * @param {Array} arr The array to use.
 * @returns {Array} The result from your function.
 */
function lengthOfArrays(arr) {
  return arr.map(word => word.length)
}

export { sumTwoValues, changeLetters, repeatWord, isPalindrome, lengthOfArrays }