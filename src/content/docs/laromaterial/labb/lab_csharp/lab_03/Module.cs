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
        return "";
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
     * Return the first character from the incoming string, if the incoming
     * string is empty, then return an empty string.
     * @return string with the first character, or empty.
     */
    public static string FirstChar(string str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return the last character from the incoming string, if the incoming
     * string is empty, then return an empty string.
     * @return string with the last character, or empty.
     */
    public static string LastChar(string str)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Return the mid character from the incoming string, if the incoming
     * string is empty, then return an empty string, if the string length is
     * even, then return the two mid characters. Consider edge cases.
     * @return string with the mid character(s), or empty.
     */
    public static string MidChar(string str)
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
     * Return a substring of str, starting with character at position pos and
     * return len characters. Feel free to use a built-in method Substring().
     * @return string substring of str.
     */
    public static string Substring(string str, int pos, int len)
    {
        // TODO: Write your code here.
        return "42";
    }

    /**
     * Count the Swedish vowels (vokaler) in the incoming string.
     * @return int number of vowels.
     */
    public static int CountVowels(string str)
    {
        // TODO: Write your code here.
        return 42;
    }

    /**
     * Replace all the consonants in the incoming string with a '*' and return
     * the resulting string, leave space as it is.
     * @return string with consonants replaced with '*'.
     */
    public static string ReplaceConsonants(string str)
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
