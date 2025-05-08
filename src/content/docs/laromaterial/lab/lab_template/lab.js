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

// dbw.assert(lab.yourFunctionToTest, <args>, <answer>, [points])










dbw.done()
