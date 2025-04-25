/**
 * This file contains the assertions for testing each function in the lab.
 * 
 * Execute the labs like this.
 *   node lab
 * 
 * Execute the labs from the solutionsfile like this.
 *   node lab -s
 */
import { dbw } from './dbw.js'
import * as laba from './answer.js'
import * as labs from './solution.js'

const lab = process.argv[2] === '-s' ? labs : laba

dbw.assert(lab.hello, [], "Hello world")

dbw.assert(lab.add, [], null)
dbw.assert(lab.add, [1], null)
dbw.assert(lab.add, [1, 1], 2)

dbw.assert(lab.magicNumber, [], 42)

dbw.assert(lab.compare, [50], true)
dbw.assert(lab.compare, [40], false)
dbw.assert(lab.compare, [42], 0)

dbw.assert(lab.celsiusToFahrenheit, [0], 32)
dbw.assert(lab.celsiusToFahrenheit, [20], 68)
dbw.assert(lab.celsiusToFahrenheit, [-20], -4)

dbw.assert(lab.sumToN, [1], 1)
dbw.assert(lab.sumToN, [2], 3)
dbw.assert(lab.sumToN, [4], 10)

dbw.assert(lab.isOdd, [1], true)
dbw.assert(lab.isOdd, [42], false)

dbw.assert(lab.sum, [[1, 2, 3]], 6)
dbw.assert(lab.sum, [[1]], 1)
dbw.assert(lab.sum, [[]], 0)

dbw.assert(lab.max, [[1, 2, 3, 6, 5, 4]], 6)
dbw.assert(lab.max, [[1, -1]], 1)
dbw.assert(lab.max, [[10, 9, 8, -10]], 10)

dbw.assert(lab.reverseString, ['abc'], 'cba')
dbw.assert(lab.reverseString, ['Mikael'], 'leakiM')

dbw.assert(lab.countWords, ['Mumintrollet bor i skogen.'], 4, 3)
dbw.assert(lab.countWords, [' Hej jag heter Mikael '], 4)

dbw.assert(lab.countVowels, ['aeiouyåäö.'], 9, 3)
dbw.assert(lab.countVowels, ['Mumintrollet bor i skogen.'], 8)

dbw.assert(lab.isPalindrom, ['AbccbA'], true, 5)
dbw.assert(lab.isPalindrom, ['AbcbA'], true)
dbw.assert(lab.isPalindrom, ['Mumintroll'], false)

dbw.done()
