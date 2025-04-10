/**
 * This module contains solutions to the methods you should implement.
 * 
 * HINTS THAT COULD BE USED IN THE LAB:
 * 
 * Math.round
 * Round to decimals
 * Modulo operator
 * Format string with String.format()
 * Ternary operator
 * String.charAt()
 */
public class Solution {
    /**
     * Return the string "Hello World!".
     */
    public static String hello()
    {
        // TODO: Write your code here.
        return "Hello World!";
    }

    /**
     * Return the integer value 42.
     */
    public static int getInteger()
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Return the value of PI with 4 decimals.
     */
    public static double getDouble()
    {
        // TODO: Write your code here.
        return 3.1416;
    }

    /**
     * Return the boolean value true.
     */
    public static Boolean getBoolean()
    {
        // TODO: Write your code here.
        return true;
    }

    /**
     * Get the hours and minutes from the parameter list and convert it into 
     * minutes only, 1 hour is 60 minutes.
     */
    public static int toMinutes(int hour, int minute)
    {
        // TODO: Write your code here.
        return hour * 60 + minute;
    }

    /**
     * Convert incoming parameters hour, minute and second to seconds.
     */
    public static int toSeconds(int hour, int minute, int second)
    {
        // TODO: Write your code here.
        return hour * 60 * 60 + minute * 60 + second;
    }

    /**
     * Check if number is even and return true or false.
     */
    public static Boolean isEven(int number)
    {
        // TODO: Write your code here.
        return (number % 2 == 0) ? true : false;
    }

    // Expressions

    /**
     * Perform addition of the two parameters a and b, then double the sum and
     * return it.
     */
    public static int addAndDoubleInt(int a, int b)
    {
        // TODO: Write your code here.
        return (a + b) * 2;
    }

    /**
     * Calculate the area of a rectangle.
     */
    public static int rectangleArea(int width, int height)
    {
        // TODO: Write your code here.
        return width * height;
    }

    /**
     * Convert celsius degrees to fahrenheit degrees and round it to the closest
     * integer with no decimals.
     */
    public static double celsiusToFahrenheit(double celsius)
    {
        // TODO: Write your code here.
        return Math.round(celsius * 1.8 + 32.0);
    }

    /**
     * Return the value of PI with 9 decimals, do not hardcode PI, use builtin constant.
     */
    public static double piWithDecimals()
    {
        // TODO: Write your code here.
        double decimals = Math.pow(10, 9);
        return Math.round(Math.PI * decimals) / decimals;
    }

    /**
     * Calculate the area of a circle with five decimals.
     */
    public static double circleArea(int radius)
    {
        // TODO: Write your code here.
        int decimals = 5;
        return Math.round(Math.PI * radius * radius * Math.pow(10, decimals)) / Math.pow(10, decimals);
    }

    /**
     * Calculate the percentage of part compared to total and round to num
     * decimals.
     */
    public static double percentage(double total, double part, int decimals)
    {
        // TODO: Write your code here.
        return Math.round(part / total * 100 * Math.pow(10, decimals)) / Math.pow(10, decimals);
    }

    // Strings

    /**
     * Return a string with the format "hh:mm:ss", pad with zeros if needed.
     */
    public static String timeToString(int hour, int minute, int second)
    {
        // TODO: Write your code here.
        return String.format("%02d:%02d:%02d", hour, minute, second);
    }

    /**
     * Convert seconds to hour, minutes and seconds by returning a string with
     * the format "hh:mm:ss", pad with zeros if needed.
     */
    public static String secondsToHHMMSS(int seconds)
    {
        // TODO: Write your code here.
        int hour = (int)seconds / 60 / 60;
        int minute = (int)(seconds - hour * 60 * 60) / 60;
        int second = seconds - hour * 60 * 60 - minute * 60;

        return String.format("%02d:%02d:%02d", hour, minute, second);
    }

    // Harder

    /**
     * Format the incoming name like "Firstname M. Lastname" where "M" is the
     * first letter in the middle name. If the middle name is empty, then return
     * "Firstname Lastname". Do not use a if statement, you may use the ternary
     * operator.
     * Return string with formatted name.
     */
    public static String nameFormatter(String first, String middle, String last)
    {
        // TODO: Write your code here.
        return first + (middle.equals("") ? " " : " " + middle.charAt(0) + ". ") + last;
    }

    /**
     * Check if the triangle is a right triangle (rätvinklig triangle) by using 
     * Pythagorean theorem a*a + b*b = c*c where c is the length of the
     * hyphotenusa. Use four decimals when comparing.
     * Return true or false.
     */
    public static Boolean pythagorean(double sideA, double sideB, double sideC)
    {
        // TODO: Write your code here.
        double decimals = Math.pow(10, 4);
        double partA = Math.round((sideA * sideA + sideB * sideB) * decimals) / decimals;
        double partB = Math.round(sideC * sideC * decimals) / decimals;

        return partA == partB;
    }

    /**
     * Take the amount in kronor and split by bills 500, 100, 20 and return a 
     * string saying the amount of each bill and how many kronors are left.
     * Do not use if statements or loops.
     * Return the string like "500 kr: %d, 100 kr: %d, 20 kr: %d, 1 kr: %d.".
     */
    public static String formatMoney(int amount)
    {
        // TODO: Write your code here.
        int bill500 = amount / 500;
        int bill100 = (amount % 500) / 100;
        int bill20 = (amount % 100) / 20;
        int bill1 = amount % 20;

        return String.format("500 kr: %d, 100 kr: %d, 20 kr: %d, 1 kr: %d.", bill500, bill100, bill20, bill1);
    }
}
