/**
 * This is the main file that executes all test cases to assert that the
 * functions in the module.js are implemented as expected.
 */
import * as lab from './lab.js'
import * as module from './module.js'

console.log("Ready to go to work! Lets make it all green!\n" + "=".repeat(50))
console.log(lab.assert(module.hello, [], "Hello world"))

console.log(lab.assert(module.magicNumber, [], 42))

console.log(lab.assert(module.compare, [50], true))
console.log(lab.assert(module.compare, [40], false))
console.log(lab.assert(module.compare, [42], 0))

console.log(lab.assert(module.celsiusToFahrenheit, [0], 32))
console.log(lab.assert(module.celsiusToFahrenheit, [20], 68))
console.log(lab.assert(module.celsiusToFahrenheit, [-20], -4))

console.log(lab.assert(module.sumToN, [1], 1))
console.log(lab.assert(module.sumToN, [2], 3))
console.log(lab.assert(module.sumToN, [4], 10))

console.log(lab.assert(module.isOdd, [1], true))
console.log(lab.assert(module.isOdd, [42], false))

console.log(lab.assert(module.sum, [[1, 2, 3]], 6))
console.log(lab.assert(module.sum, [[1]], 1))
console.log(lab.assert(module.sum, [[]], 0))

console.log(lab.assert(module.max, [[1, 2, 3, 6, 5, 4]], 6))
console.log(lab.assert(module.max, [[1, -1]], 1))
console.log(lab.assert(module.max, [[10, 9, 8, -10]], 10))

console.log(lab.assert(module.reverseString, ['abc'], 'cba'))
console.log(lab.assert(module.reverseString, ['Mikael'], 'leakiM'))

console.log(lab.assert(module.countWords, ['Mumintrollet bor i skogen.'], 4))
console.log(lab.assert(module.countWords, [' Hej jag heter Mikael '], 4))

console.log(lab.assert(module.countVowels, ['aeiouyåäö.'], 9))
console.log(lab.assert(module.countVowels, ['Mumintrollet bor i skogen.'], 8))

console.log(lab.assert(module.isPalindrom, ['AbccbA'], true))
console.log(lab.assert(module.isPalindrom, ['AbcbA'], true))
console.log(lab.assert(module.isPalindrom, ['Mumintroll'], false))

console.log(lab.done())
