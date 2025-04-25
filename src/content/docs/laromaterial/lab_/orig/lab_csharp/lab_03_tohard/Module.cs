/**
 * This module contains the methods you should implement.
 */
static class Module
{
    /**
     * Return the string "Hello World!".
     * @return string
     */
    public static string Hello()
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return the length of the string str.
     * @return int the length of the string.
     */
    public static int StringLength(string str)
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
    public static string FirstLastChar(string str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return the integer value of the fourth character in the incoming 
     * string str.
     * @return int value of the fourth char.
     */
    public static int IntValChar(string str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Create a string with num characters, starting from the character ch.
     * Use the interger value of the char to create the loop.
     * @return string with num chars, starting with the char ch.
     */
    public static string CreateStringFromChar(char ch, int num)
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
    public static string FormatString(string str, char ch, int intval, double floatval)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Change the caps for each character in the string str. Use IsUpper() 
     * (uppercase) and IsLower() (lowercase) to check for the caps and ignore 
     * all chars that does not relate upper/lower case. Use ToLower/ToUpper to
     * swap the case of each character.
     * @return string with swapped case for letters.
     */
    public static string SwapCase(string str)
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
    public static string ReplaceSpace(string str)
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
    public static string ReplaceSpaceMultiple(string str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return a substring of str, starting with character at position pos and
     * return len characters. Feel free to use a built-in method.
     * @return string substring of str.
     */
    public static string Substring(string str, int pos, int len)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Check if the substring sub exists in the string str. Feel free to use a 
     * built-in method.
     * @return boolean true if substr exists in str, else false.
     */
    public static bool? SubstringInString(string str, string sub)
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
    public static string FirstLastSubstring(string str)
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
    public static bool? CheckPasswordConstraints(string pwd)
    {
        // TODO: Write your code here.
        return null;
    }
}
