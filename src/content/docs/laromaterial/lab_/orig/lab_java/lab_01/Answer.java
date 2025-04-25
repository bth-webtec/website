/**
 * This module contains the methods you should implement.
 * 
 * Update the code in Module.java and execute the lab like this:
 *  javac *.java && java Main
 */
public class Answer {
    /**
     * Return the string "Hello World!".
     */
    public static String hello()
    {
        // TODO: Write your code here.
        return "";
    }

    /**
     * Return the integer value 42.
     */
    public static int getInteger()
    {
        // TODO: Write your code here.
        return 0;
    }

    /**
     * Return the value of PI with 4 decimals.
     */
    public static double getDouble()
    {
        // TODO: Write your code here.
        return 0.0;
    }

    /**
     * Return the boolean value true.
     */
    public static Boolean getBoolean()
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Get the hours and minutes from the parameter list and convert it into 
     * minutes only, 1 hour is 60 minutes.
     */
    public static int toMinutes(int hour, int minute)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Convert incoming parameters hour, minute and second to seconds.
     */
    public static int toSeconds(int hour, int minute, int second)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Check if number is even and return true or false.
     */
    public static Boolean isEven(int number)
    {
        // TODO: Write your code here.
        return null;
    }

    // Expressions

    /**
     * Perform addition of the two parameters a and b, then double the sum and
     * return it.
     */
    public static int addAndDoubleInt(int a, int b)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Calculate the area of a rectangle.
     */
    public static int rectangleArea(int width, int height)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Convert celsius degrees to fahrenheit degrees and round it to the closest
     * integer with no decimals.
     */
    public static double celsiusToFahrenheit(double celsius)
    {
        // TODO: Write your code here.
        return 42.0;
    }

    /**
     * Return the value of PI with 9 decimals, do not hardcode PI, use builtin constant.
     */
    public static double piWithDecimals()
    {
        // TODO: Write your code here.
        return 42.0;
    }

    /**
     * Calculate the area of a circle with five decimals.
     */
    public static double circleArea(int radius)
    {
        // TODO: Write your code here.
        return 42.0;
    }

    /**
     * Calculate the percentage of part compared to total and round to num
     * decimals.
     */
    public static double percentage(double total, double part, int decimals)
    {
        // TODO: Write your code here.
        return 42.0;
    }

    // Strings

    /**
     * Return a string with the format "hh:mm:ss", pad with zeros if needed.
     */
    public static String timeToString(int hour, int minute, int second)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Convert seconds to hour, minutes and seconds by returning a string with
     * the format "hh:mm:ss", pad with zeros if needed.
     */
    public static String secondsToHHMMSS(int seconds)
    {
        // TODO: Write your code here.
        return "42";
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
        return "42";
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
        return null;
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
        return "42";
    }
}
