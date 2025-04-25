/**
 * This module contains lab specific code to assert the functions of the lab 
 * and to calculate the result.
 */
static class Lab
{
    /**
    * Execute the testcase and assert that it was corrent or not and return a
    * status string the can be written out.
    * @param {Function} func - The function to test.
    * @param {Object} expected - The expected result from the function call.
    * @param {Object} args - The arguments to send to the function.
    * @param {number} point - The number of points that this functions is worth in total.
    * @returns {string} A string representation of the test case success or failure.
    */
    static public string Assert(
        Delegate method,
        object[] args,
        object expected,
        int point = 1
    )
    {
        object? result = method.DynamicInvoke(args);
        string success = "❌";

        if (expected == null && result == null)
        {
            success = "✅";
        }
        else if (expected is not null && result is not null && expected.GetType() == result.GetType())
        {
            if (expected.GetType() == typeof(string) && (string)expected == (string)result)
            {
                success = "✅";
            }
            else if (expected.GetType() == typeof(int) && (int)expected == (int)result)
            {
                success = "✅";
            }
            else if (expected.GetType() == typeof(double) && (double)expected == (double)result)
            {
                success = "✅";
            }
            else if (expected.GetType() == typeof(bool) && (bool)expected == (bool)result)
            {
                success = "✅";
            }
        }


        // // Calculate the stats
        // if (!(func.name in stats)) {
        //     stats[func.name] = {
        //     run: 0,
        //     passed: 0,
        //     failed: 0,
        //     point,
        //     }
        // }
        // stats[func.name].run++
        // if (expected === result) {
        //     stats[func.name].passed++
        // } else {
        //     stats[func.name].failed++
        // }

        // // Prepare the argument string
        string argStr = argsAsString(args);
        string expectedStr = expected is not null ? argsAsString([expected]) : "";
        string resultStr = result is not null ? argsAsString([result]) : "";
        string methodName = method.Method.Name;
        string expectedType = expected is not null ? expected.GetType().ToString().Substring(7) : "";
        string resultType = result is not null ? result.GetType().ToString().Substring(7) : "";

        // return `${success} ${stats[func.name].point}p ${func.name}(${argStr}), expected: ${expectedStr} (${typeof expected}), actual: ${resultStr} (${typeof result})`
        return $"{success} {methodName}({argStr}), expected: {expectedStr} ({expectedType}), actual: {resultStr} ({resultType})";
    }

    /**
    * Format a value to its string representation.
    * @param {Object} args - A value to parse and format as a string.
    * @returns {string} A string representation of the value.
    */
    static string argsAsString(object[] args)
    {
        string argStr = "";
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].GetType() == typeof(string))
            {
                argStr += $"\"{args[i]}\", ";
            }
            // else if (typeof arg === 'object' && Array.isArray(arg)) {
            //     argStr += `[${arg}], `
            // }
            else
            {
                argStr += $"{args[i]}, ";
            }
        }

        return argStr.Length > 2
            ? argStr = argStr.Substring(0, argStr.Length - 2)
            : argStr
        ;
    }



    // const level = {
    // pass: 10,
    // honour: 13,
    // }

    // const feedback = {
    // 0: `Try to earn 1 point to get started... 😏`,
    // 1: `Nice work, lets go, do another! 😉`,
    // 5: `Great, you are on fire and progress is made. 😋`,
    // 9: `Just one more to PASS. Lets go. 😅`,
    // 10: `Excellent, you have PASSED. Lets try one more? 😁`,
    // 13: `That is the way, you PASSED WITH HONOUR! 😍`,
    // 16: `What can I say. You impress me. 🙌`,
    // }

    // const stats = {}

    // /**
    // * Execute the testcase and assert that it was corrent or not and return a
    // * status string the can be written out.
    // * @param {Function} func - The function to test.
    // * @param {Object} expected - The expected result from the function call.
    // * @param {Object} args - The arguments to send to the function.
    // * @param {number} point - The number of points that this functions is worth in total.
    // * @returns {string} A string representation of the test case success or failure.
    // */
    // export function assert (func, expected, args, point=1) {
    // const result = func(...args)
    // const success = expected === result ? '✅' : '❌'

    // // Calculate the stats
    // if (!(func.name in stats)) {
    //     stats[func.name] = {
    //     run: 0,
    //     passed: 0,
    //     failed: 0,
    //     point,
    //     }
    // }
    // stats[func.name].run++
    // if (expected === result) {
    //     stats[func.name].passed++
    // } else {
    //     stats[func.name].failed++
    // }

    // // Prepare the argument string
    // let argStr = argsAsString(args)
    // let expectedStr = argsAsString([expected])
    // let resultStr = argsAsString([result])

    // return `${success} ${stats[func.name].point}p ${func.name}(${argStr}), expected: ${expectedStr} (${typeof expected}), actual: ${resultStr} (${typeof result})`
    // }

    // /**
    // * Print out the results when the execution is done.
    // * @returns {string} A string representation of the results.
    // */
    // export function done (func, expected, args) {
    // let points = 0
    // let passed = 0
    // let failed = 0
    // let total = 0
    // let result = 0
    // let str = ''
    // for (const func of Object.keys(stats)) {
    //     points += stats[func].point
    //     passed += stats[func].passed
    //     failed += stats[func].failed
    //     total += stats[func].passed + stats[func].failed
    //     result += stats[func].point * Math.floor(stats[func].passed / (stats[func].passed + stats[func].failed), 1)
    // }

    // let msg = feedback[0]
    // for (const key of Object.keys(feedback)) {
    //     if (result < key) {
    //     break
    //     }
    //     msg = feedback[key]
    // }

    // str += `Passed: ${passed}, Failed: ${failed}, Total: ${total}`
    // str += `\nYou have ${result} points out of total ${points} points.`
    // str += `\nYou need ${level.pass} points to PASS and ${level.honour} points to PASS WITH HONOUR.`
    // str += `\n${msg}`
    // return str
    // }
}
