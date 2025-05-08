/**
 * This file contains solutions to the lab, use it when you get stuck or when 
 * you want to compare your solution to with the teachers solution.
 * 
 * Execute the lab in the browser through lab.html and review the output in the 
 * console, or execute the lab through node using `node lab -s` in the terminal.
 */



/**
 * Returns the length of an array.
 *
 * @param {array} arr The array to use.
 * @returns {number} The length of the array.
 */
export function arrayLength (arr) {
  // TODO: Write your code here.
  return arr.length
}



/**
 * Returns the nth element in the array.
 *
 * @param {number} n The index of the element to retrieve.
 * @param {Array} arr The array to use.
 * @returns {*} The nth element in the array.
 */
export function nthElement (arr, n) {
  // TODO: Write your code here.
  return arr[n]
}



/**
 * Return the largest number in the array.
 * Hint: Math.max(), spread operator
 * 
 * @param {Array} arr The array to use.
 * @returns {number} The largest number in the array.
 */
export function largest (arr) {
  // TODO: Write your code here.
  return Math.max(...arr)
}



/**
 * Return the average number of the array.
 * 
 * @param {Array} arr The array to use.
 * @returns {number} The average.
 */
export function average (arr) {
  // TODO: Write your code here.
  let res = 0

  for (let i = 0; i < arr.length; i++) {
    res += arr[i]
  }
  return res / arr.length
}