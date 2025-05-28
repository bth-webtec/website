/**
 * This file contains the assertions for testing each function in the lab.
 * 
 * Execute the labs like this.
 *   node lab
 * 
 * Execute the labs from the solutionsfile like this.
 *   node lab -s
 */
import { dbw } from '../src/dbw.js'
import * as laba from './answer.js'
import * as labs from './solution.js'

const lab = process.argv[2] === '-s' ? labs : laba

dbw.assert(lab.sumTwoValues, [41, 2], 43)
dbw.assert(lab.sumTwoValues, ["test", 2], "Error")

dbw.assert(lab.changeLetters, ["PengUiN"], "pENGuIn")
dbw.assert(lab.changeLetters, ["all lowercase"], "ALL LOWERCASE")
dbw.assert(lab.changeLetters, ["all uppercase"], "ALL UPPERCASE")

dbw.assert(lab.repeatWord, ["Happy", 3], "HappyHappyHappy")

dbw.assert(lab.isPalindrome, ["Happy"], false)
dbw.assert(lab.isPalindrome, ["Kajak"], true)

dbw.assert(lab.lengthOfArrays, [["Kajak"]], [5])
dbw.assert(lab.lengthOfArrays, [["Duck", "Penguin", "Swan", "Chicken"]], [4, 7, 4, 7])

dbw.assert(lab.ifLarger, [30, 97], true)
dbw.assert(lab.ifLarger, [42, 42], false)















dbw.done()
