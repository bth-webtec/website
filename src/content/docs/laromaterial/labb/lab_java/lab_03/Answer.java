/**
 * This module contains the methods you should implement.
 * 
 * Update the code in Module.java and execute the lab like this:
 *  javac *.java && java Main
 * 
 */
public class Answer {
    /**
     * Return the string "Hello World!".
     */
    public static String hello()
    {
        // TODO: Write your code here.
        return "42";
    }

    // Strings basics

    /**
     * Return the length of the string str.
     * @return int the length of the string.
     */
    public static int stringLength(String str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Return a string containing the first and the last character of the
     * incoming string str. It shall also work for empty strings and then
     * return an empty string.
     * @return string with the first and last character, or empty.
     */
    public static String firstLastChar(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return the integer value of the fourth character in the incoming 
     * string str.
     * @return int value of the fourth char.
     */
    public static int intValChar(String str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Create a string with num characters, starting from the character ch.
     * Use the interger value of the char to create the loop.
     * @return string with num chars, starting with the char ch.
     */
    public static String createStringFromChar(char ch, int num)
    {
        // TODO: Write your code here.
        return "42";
    }

    // String built-in methods

    /**
     * Change the caps for each character in the string str. Use IsUpper() 
     * (uppercase) and IsLower() (lowercase) to check for the caps and ignore 
     * all chars that does not relate upper/lower case. Use ToLower/ToUpper to
     * swap the case of each character.
     * @return string with swapped case for letters.
     */
    public static String swapCase(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Trim the incoming string str and remove all spaces in the beginning and 
     * the end of the string and then replace all spaces in the string str with
     * the character -.
     * @return string trimmed and with - and no spaces.
     */
    public static String replaceSpace(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Trim the incoming string str and then replace all white space characters
     * with the character -. If there are multiple whitspace chars after each
     * other, then replace them all with only one -. Use IsWhiteSpace().
     * @return string trimmed and with - and no white spaces.
     */
    public static String replaceSpaceMultiple(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return a substring of str, starting with character at position pos and
     * return len characters. Feel free to use a built-in method.
     * @return string substring of str.
     */
    public static String substring(String str, int pos, int len)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check if the substring sub exists in the string str. Feel free to use a 
     * built-in method.
     * @return boolean true if substr exists in str, else false.
     */
    public static Boolean substringInString(String str, String sub)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Split the incoming string str by each space so you get an array of
     * substrings. Then create a new string from the first and last substring,
     * separated by a space, and return it. Feel free to use built-in methods.
     * @return string first and last substring in str, separated by space.
     */
    public static String firstLastSubString(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * You get parameters of different types, combine them all in a string and
     * return it. Separate each value with a space, the int should take up 3
     * figures, prepend by zero if needed and the double should be rounded to
     * two decimals in the string.
     * @return string formatted according to the rules.
     */
    public static String formatString(String str, char ch, int intval, double floatval)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check that the incoming string pwd has all of the following 
     * characteristics for a password.
     *  - A mix of upper and lower case
     *  - At least one digit
     *  - At least one character that is neither letter or digit
     *  - At least 8 character long
     * Use builtin methods.
     * @return string first and last substring in str, separated by space.
     */
    public static Boolean checkPasswordConstraints(String pwd)
    {
        // TODO: Write your code here.
        return null;
    }

    /**
     * Count the numbers of words in a string, ignore multiple space between the
     * words and trim the incoming string.
     * @return int number of words in the string.
     */
    public static int countWords(String str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Reverse a string and return it.
     * @return String the reversed version of the string.
     */
    public static String reverseString(String str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check if the string is a palindrom, ignore case and trim the string and
     * ignore special characters.
     * @return Boolean true if string is palindrom, otherwise false.
     */
    public static Boolean isPalindrom(String str)
    {
        // TODO: Write your code here.
        return null;
    }
}
