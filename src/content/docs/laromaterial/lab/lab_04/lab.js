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

dbw.assert(lab.arrayLength, [[1, 3, "penguin", "shark"]], 4)
dbw.assert(lab.arrayLength, [[1, 3]], 2)

dbw.assert(lab.nthElement, [[1, 3, 6, 3], 3], 3)
dbw.assert(lab.nthElement, [[1, 3, "penguin", "shark"], 2], "penguin")

dbw.assert(lab.largest, [[1, 3, 10, 42, 23, 33]], 42)
dbw.assert(lab.largest, [[-2, -44, -31, -12]], -2)

dbw.assert(lab.average, [[2, 4, 6, 8, 10]], 6)
dbw.assert(lab.average, [[-2, -44, -31, -12]], -22.25)
















dbw.done()
