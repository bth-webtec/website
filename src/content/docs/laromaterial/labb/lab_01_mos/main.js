/**
 * This is the main file that executes all test cases to assert that the
 * functions in the module.js are implemented as expected.
 */
import * as lab from './lab.js'
import * as module from './module.js'

console.log("Ready to go to work! Lets make it all green!\n" + "=".repeat(50))
console.log(lab.assert(module.hello, [], "Hello world"))

console.log(lab.assert(module.magicNumber, [], 42))

console.log(lab.assert(module.stringLength, [], 11))

console.log(lab.assert(module.product, [], 42))

console.log(lab.assert(module.sumFloat, [], 76.7))

console.log(lab.assert(module.sumFloatRoundedLower, [], 76))

console.log(lab.assert(module.sumFloatRoundedHigher, [], 77))

console.log(lab.assert(module.diffFloatRoundedActual, [], 34.34))

console.log(lab.assert(module.roundPI, [], 3.1416))

console.log(lab.assert(module.concatinateString, [], "Hello everyone"))

console.log(lab.assert(module.charAtPosition, [], "S"))

console.log(lab.assert(module.upper, [], "PROGRAMMING"))

console.log(lab.assert(module.upperFirst, [], "Programming"))

console.log(lab.assert(module.substring, [], "ear"))

console.log(lab.done())
