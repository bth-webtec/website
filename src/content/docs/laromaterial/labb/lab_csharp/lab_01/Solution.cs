/**
 * This module contains the methods you should implement.
 */
static class Solution
{
    /**
     * Return the string "Hello World!".
     */
    public static string Hello()
    {
        // TODO: Write your code here.
        return "Hello World!";
    }

    /**
     * Return the integer value 42.
     */
    public static int Integer()
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Return the value of PI with 4 decimals.
     */
    public static double Double()
    {
        // TODO: Write your code here.
        return 3.1416;
    }

    /**
     * Return the boolean value true.
     */
    public static bool Bool()
    {
        // TODO: Write your code here.
        return true;
    }

    /**
     * Convert celcius degrees to fahrenheit degrees.
     */
    public static double CelsiusToFahrenheit(double celcius)
    {
        // TODO: Write your code here.
        return celcius * 1.8 + 32;
    }

    /**
     * Checks the incoming value and returns value 1 if it is higher than 42
     * or -1 if it is lower than 42 or 0 when the incoming number is equal to
     * 42.
     */
    public static int Compare(int number)
    {
        // TODO: Write your code here.
        if (number > 42)
        {
            return 1;
        }
        else if (number < 42)
        {
            return -1;
        }
        return 0;
    }

    /**
     * Based on the age, return a string like this:
     *  age < 13 return "Youngster"
     *  age < 20 return "Teenager"
     *  age < 65 return "Adult"
     *  age >= 65 return "Retired"  
     */
    public static string AgeToString(int age)
    {
        // TODO: Write your code here.
        if (age < 13)
        {
            return "Youngster";
        }
        else if (age < 20)
        {
            return "Teenager";
        }
        else if (age < 65)
        {
            return "Adult";
        }
        return "Retired";
    }

    /**
     * Sum all values from 1 up to the parameter n.
     */
    public static int SumToN(int n)
    {
        // TODO: Write your code here.
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    /**
     * Check if a number is even and return true or false.
     */
    public static bool? IsEven(int n)
    {
        // TODO: Write your code here.
        return (n % 2 == 0) ? true : false;
    }

    /**
     * Return the sum of all odd numbers from 1 up to and including the 
     * value of parameter n.
     */
    public static int SumOddToN(int n)
    {
        // TODO: Write your code here.
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                sum += i;
            }
        }
        return sum;
    }

    /**
     * Return a string containing all values from value1 up to and including 
     * value2 and separate the values with a ', '. If value2 is equal or less
     * than value1, then return an empty string "".
     */
    public static string StringOfValues(int value1, int value2)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Count the numbers of words in a string.
     */
    public static int CountWords(string str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Reverse a string.
     */
    public static string ReverseString(string str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check if the string is a palindrom.
     */
    public static bool? IsPalindrom(string str)
    {
        // TODO: Write your code here.
        return null;
    }
}
