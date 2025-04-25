/**
 * This module contains the methods you should implement.
 * 
 * Update the code in Module.java and execute the lab like this:
 *  javac *.java && java Main
 * 
 * HINTS THAT COULD BE USED IN THE LAB:
 * 
 * if, else if, else
 * switch
 * Object.valueOf()
 * Object.toString()
 * for
 * while
 * do while
 */
public class Answer {
    /**
     * Return the string "Hello World!".
     * @return String with hello message 
     */
    public static String hello()
    {
        // TODO: Write your code here.
        return "42";
    }

    // IF

    /**
     * Check if number1 is greater than number2 and then return true, otherwise
     * return false.
     * @return boolean true or false 
     */
    public static Boolean isGreater(int number1, int number2)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Checks the incoming value and returns value 1 if it is higher than 42
     * or -1 if it is lower than 42 or 0 when the incoming number is equal to
     * 42.
     * @return int -1, 0 or 1
     */
    public static int compare42(int number)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Compare if all numbers are equal and then return 1. If number3 is
     * greater than number2 and number2 is greater than number1, then return 2.
     * If number1 is the greatest number, then return 3. Otherwise return 0.
     * @return int 0, 1, 2, 3
     */
    public static int compareMixed(int number1, int number2, int number3)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Check if age is below 13 or age is above/equal to 65 and then return true.
     * Return false if the age is neither a child or a senior.
     * @return boolean true or false
     */
    public static Boolean isChildOrSenior(int age)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Based on the age, return a string like this:
     *  age < 13 return "Youngster"
     *  age < 20 return "Teenager"
     *  age < 65 return "Adult"
     *  age >= 65 return "Senior"
     * @return 
     */
    public static String ageToString(int age)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Get the length of the sides of the triangle and check if the triangle is:
     * Equilateral: All sides are the same length.
     * Isosceles: Two sides are the same length.
     * Different sided: All sides are different lengths.
     * @return String as "equil", "isosc" or "different".
     */
    public static String triangleType(int sideA, int sideB, int sideC)
    {
        // TODO: Write your code here.
        return "42";
    }

    // SWITCH

    /**
     * Use a switch statement to return the color of a fruit where "apple=green",
     * "citrus=yellow", "berry=red" and the default color should be "unknown". 
     * @return String as the color of the fruit.
     */
    public static String getFruitColor(String fruit)
    {
        // TODO: Write your code here.
        return "42";
    }

    // Object.valueOf(), Object.toString()

    /**
     * Compare the two values intValue and strValue and check if they are equal
     * values. Do the check by converting the strValue to an integer value.
     * @return boolean true or false
     */
    public static Boolean looseCompare(int intValue, String strValue)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Convert the incoming intValue to a string and return it.
     * @return String with the intValue
     */
    public static String intToString(int intValue)
    {
        // TODO: Write your code here.
        return "4 2";
    }

    // Loop

    /**
     * Sum all values from 1 up to and not including the parameter n.
     * @return int with the sum
     */
    public static int sumToN(int n)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Return the sum of all odd numbers from 1 up to and including the 
     * value of parameter n.
     * @return int with the sum of the odd numbers
     */
    public static int sumOddToN(int n)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Return a string containing all values from value1 up to and including 
     * value2 and separate the values with a ', '. If value2 is equal or less
     * than value1, then return an empty string "".
     */
    public static String stringOfValues(int value1, int value2)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Use a while loop to create a method that sums all values from 1 and up 
     * to the number n where the sum of all numbers is not over max.
     * @return int the number n
     */
    public static int countUpToMaxSumWhile(int max)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * This is the same as countUpToMaxSumWhile(int max) but you must now use a 
     * do-while loop instead.
     * @return int the number n
     */
    public static int countUpToMaxSumDoWhile(int max)
    {
        // TODO: Write your code here.
        return 42;
    }

    // Advanced

    /**
     * Loop from start to end and return a string with the following conditions:
     * "Fizz" if the number is divisible by 3.
     * "Buzz" if the number is divisible by 5.
     * "FizzBuzz" if the number is divisible by both 3 and 5.
     * Otherwise, the number itself must be added to the string.
     * Add a space between each value.
     * @return String with correct mix of fizz and buzz
     */
    public static String fizzBuzz(int start, int end)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check if the incoming number is a prime number, meaning it is only
     * even divisible with 1 and itself. 
     * @return true or false.
     */
    public static Boolean isPrime(int number)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * The Fibonacci sequence starts with 0 and 1, and each subsequent number is
     * the sum of the previous two (0, 1, 1, 2, 3, 5, 8, ...). Write the method
     * so it returns the n:th number in the Fibonacci sequence. When n=4 it 
     * should return 2 and when n=6 it should return 5.
     * @return The n:th number in the Fibonacci sequence.
     */
    public static int fibonacci(int n)
    {
        // TODO: Write your code here.
        return 42;
    }
}
