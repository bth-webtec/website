/**
 * This file contains solutions to the lab, use it when you get stuck or when 
 * you want to compare your solution to with the teachers solution.
 * 
 * Execute the lab in the browser through lab.html and review the output in the 
 * console, or execute the lab through node using `node lab -s` in the terminal.
 */



/**
 * Add your imports after this comment.
 */

import { sumTwoValues, changeLetters, repeatWord, isPalindrome, lengthOfArrays, ifLarger } from "./.solution_modules/helpers.js"


/**
 * Create an own module called 'helpers.js' in the folder 'modules'.
 * From that file, export a function that takes two parameters and returns the sum of them. 
 * If at least one of the parameters is not of type number, return the string "Error".
 *
 * @param {*} item1 The first item to use.
 * @param {*} item2 The second item to use.
 * @returns {number|string} The result from your function.
 */

export { sumTwoValues }


/**
 * Add a function called 'changeLetters' to 'helpers.js' and export it.
 * The function should take one string parameter and returns the string with all upppercased letters lowercased and vice versa. 
 *
 * You can copy the JSDoc below to your implementation.
 * 
 * Answer with an export of your function in the format: export { changeLetters }
 *
 * @param {string} word The string to use.
 * @returns {string} The result from your function.
 */

export { changeLetters }



/**
 * Add a function called 'repeatWord' to 'helpers.js' and export it.
 * The function should take two parameters. One string and one number and return the string repeated as many times. 
 *
 * You can copy the JSDoc below to your implementation.
 * 
 * Answer with an export of your function in the format: export { repeatWord }
 *
 * @param {string} word The string to use.
 * @param {number} repeat The amount of times to repeat the word.
 * @returns {string} The result from your function.
 */
export { repeatWord }



/**
 * Add a function called 'isPalindrome' to 'helpers.js' and export it.
 * The function should return a boolean weither or not the string argument is a palindrome or not.
 *
 * You can copy the JSDoc below to your implementation.
 * 
 * Answer with an export of your function in the format: export { isPalindrome }
 *
 * @param {string} word The string to use.
 * @returns {boolean} The result from your function.
 */
export { isPalindrome }



/**
 * Add a function called 'lengthOfArrays' to 'helpers.js' and export it.
 * The function should return an array containing the lengths of all words in the passed array.
 *
 * You can copy the JSDoc below to your implementation.
 * 
 * Answer with an export of your function in the format: export { lengthOfArrays }
 *
 * @param {Array} arr The array to use.
 * @returns {Array} The result from your function.
 */
export { lengthOfArrays }



/**
 * Add a function called 'ifLarger' to 'helpers.js' and export it.
 * The function should return a boolean weither the arguments adds upp to larger than 100 or not.
 * Use your function "sumTwoValues" from before.
 *
 * You can copy the JSDoc below to your implementation.
 * 
 * Answer with an export of your function in the format: export { ifLarger }
 *
 * @param {number} val1 The first value to use.
 * @param {number} val2 The second value to use.
 * @returns {boolean} The result from your function.
 */
export { ifLarger }