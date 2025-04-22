/**
 * This is a lab where the intention is that you implement the body to all
 * functions below.
 */

/**
 * Returns the string "Hello world".
 *
 * @returns {string} A welcome message "Hello world".
 */
export function hello () {
    // TODO: Write your code here.
    return "Hello world";
}



/**
 * Returns the numeric value 42.
 *
 * @returns {number} The numeric value 42.
 */
export function magicNumber () {
    // TODO: Write your code here.
    return 42;
}



/**
 * Returns the length of the word "Hello world".
 *
 * @returns {number} The length of the string "Hello world".
 */
export function stringLength () {
    // TODO: Write your code here.
    return "Hello world".length;
}



/**
 * Returns the product of 7 and 6.
 *
 * @returns {number} The product of 7 and 6.
 */
export function product () {
    // TODO: Write your code here.
    return 7 * 6;
}



/**
 * Returns the sum of two float values.
 *
 * @returns {number} The sum of 42.2 and 34.5.
 */
export function sumFloat () {
    // TODO: Write your code here.
    return 42.2 + 34.5;
}



/**
 * Returns the sum of two float values, rounded to the lower integer value.
 *
 * @returns {number} The sum of 42.2345 and 34.55452, rounded to lower integer value.
 */
export function sumFloatRoundedLower () {
    // TODO: Write your code here.
    return Math.floor(42.2345 + 34.55452);
}



/**
 * Returns the sum of two float values, rounded to the higher integer value.
 *
 * @returns {number} The sum of 42.2345 and 34.55452, rounded to the higher integer value.
 */
export function sumFloatRoundedHigher () {
    // TODO: Write your code here.
    return Math.ceil(42.2345 + 34.55452);
}



/**
 * Returns the difference between two float values, rounded to two decimals.
 *
 * @returns {number} The difference between 42.543265 and 76.887585, rounded to two decimals.
 */
export function diffFloatRoundedActual () {
    // Hint: To round a value to four decimals you can use: Math.round(value*10000)/10000
    // Where <value> is the number to be rounded
    
    // TODO: Write your code here.
    let value =  76.887585 - 42.543265;

    return Math.round(value*100)/100;
}



/**
 * Returns the value of PI, rounded to four decimals. PI can be found in Math.PI.
 *
 * @returns {number} The value of PI, rounded to four decimals.
 */
export function roundPI () {    
    // TODO: Write your code here.

    return Math.round(Math.PI*10000)/10000;
}



/**
 * Returns a concatinated string, with a space between the words.
 *
 * @returns {string} The concatinated string from "Hello" and "everyone".
 */
export function concatinateString () {    
    // TODO: Write your code here.
    let first = "Hello"
    let second = "everyone"

    return first + " " + second;
}



/**
 * Returns the character at index 4 using the built-in method charAt().
 *
 * @returns {string} The character at index 4 in "JavaScript".
 */
export function charAtPosition () {    
    // TODO: Write your code here.

    return "JavaScript".charAt(4);
}



/**
 * Returns the string "programming" in uppercase.
 *
 * @returns {string} The string "programming" in uppercase.
 */
export function upper () {    
    // TODO: Write your code here.

    return "programming".toUpperCase();
}



/**
 * Returns the string "programming" with the first character in uppercase.
 * Hint: slice()
 * @returns {string} The string "programming", with the first character in uppercase.
 */
export function upperFirst () {    
    // TODO: Write your code here.
    let word = "programming"
    return word.charAt(0).toUpperCase() + word.slice(1);
}



/**
 * Returns the last three characters in the word "Polarbear".
 * Hint: substr()
 *
 * @returns {string} last three characters in the word "Polarbear".
 */
export function substring () {
    
    // TODO: Write your code here.
    let word = "Polarbear"
    return word.substring(word.length-3);
}



// ----------------------------- Implement all functions above -----------------------------



// ----------------------------- Internal function -----------------------------

/**
 * Check a testcase and write status if it succeeds or not, this function is to make the output of the lab to work.
 *
 * @param {function} func - The function to test.
 * @param {function} expected - The expected result from the function call.
 * @param {function} args - The arguments to send to the function.
 * @returns {string} A string representation of the test case success or failure.
 */
export function test (func, expected, args) {
    const result = func(...args)
    const success = expected === result ? '✅' : '❌'
    // check if array []
    // print as string ''
    return `${success} [${func.name}] ${expected} (${typeof expected}) => ${result} (${typeof result})`
}
  