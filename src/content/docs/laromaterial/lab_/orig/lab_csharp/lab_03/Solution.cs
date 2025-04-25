/**
 * This module contains the methods you should implement.
 *
 * TODO
 * Delar i labben är kluriga, tex char to string där det blir typkonvertering, samt strängformattering (förenkla)
 * Flytta från lab 2 hit?
 * Räkna antalet ord
 * Reverse
 * Palindrom
 * Kolla om ett tecken finns i en sträng
 * Mata in namn och skriv ut initialerna
 * Kontrollera om sträng är en epostadress
 * Array och slumpa fram ett val i arrayen
 * Sträng med åäö byt ut till aao
 * Returnera de index där bokstaven x finns i ett ord
 * Egen lab med characters & int?
 * Kika även på de som övergavs i _tohard
 * Kolla även java lab 3
 */
static class Solution
{
    /**
     * Return the string "Hello World!".
     * @return string
     */
    public static string Hello()
    {
        // TODO: Write your code here.
        return "Hello World!";
    }

    /**
     * Return the length of the string str.
     * @return int the length of the string.
     */
    public static int StringLength(string str)
    {
        // TODO: Write your code here.
        return str.Length;
    }

    /**
     * Return the first character from the incoming string, if the incoming
     * string is empty, then return an empty string.
     * @return string with the first character, or empty.
     */
    public static string FirstChar(string str)
    {
        // TODO: Write your code here.
        if (str.Length == 0)
        {
            return "";
        }
        return $"{str[0]}";
    }

    /**
     * Return the last character from the incoming string, if the incoming
     * string is empty, then return an empty string.
     * @return string with the last character, or empty.
     */
    public static string LastChar(string str)
    {
        // TODO: Write your code here.
        if (str.Length == 0)
        {
            return "";
        }
        return $"{str[str.Length - 1]}";
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
        string res = "";
        if (str.Length == 0)
        {
            return res;
        }
        else if (str.Length == 1)
        {
            return str;
        }
        else if (str.Length % 2 == 1)
        {
            return $"{str[str.Length / 2]}";
        }
        int first = str.Length / 2;
        int second = first - 1;
        return $"{str[second]}{str[first]}";
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
        return String.Format("{0} {1} {2:D3} {3:F2}", str, ch, intval, floatval);
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
        string res = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsUpper(str[i]))
            {
                res += Char.ToLower(str[i]);
            }
            else if (Char.IsLower(str[i]))
            {
                res += Char.ToUpper(str[i]);
            }
            else
            {
                res += str[i];
            }
        }

        return res;
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
        string res = "";
        str = str.Trim();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                res += '-';
            }
            else
            {
                res += str[i];
            }
        }

        return res;
    }

    /**
     * Return a substring of str, starting with character at position pos and
     * return len characters. Feel free to use a built-in method Substring().
     * @return string substring of str.
     */
    public static string Substring(string str, int pos, int len)
    {
        // TODO: Write your code here.
        return str.Substring(pos, len);
    }

    /**
     * Count the Swedish vowels (vokaler) in the incoming string.
     * @return int number of vowels.
     */
    public static int CountVowels(string str)
    {
        // TODO: Write your code here.
        int count = 0;
        string vowels = "aeiouåäö";

        foreach (char c in str)
        {
            if (vowels.Contains(char.ToLower(c)))
            {
                count++;
            }
        }

        return count;
    }

    /**
     * Replace all the consonants in the incoming string with a '*' and return
     * the resulting string, leave space as it is.
     * @return string with consonants replaced with '*'.
     */
    public static string ReplaceConsonants(string str)
    {
        // TODO: Write your code here.
        string vowels = "aeiouåäö";
        string res = "";

        foreach (char c in str)
        {
            if (char.IsLetter(c) && !vowels.Contains(char.ToLower(c)))
            {
                res += "*";
            }
            else
            {
                res += c;
            }
        }

        return res;
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
        string res = "";
        str = str.Trim();

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsWhiteSpace(str[i]))
            {
                res += '-';
                while ((i + 1) < str.Length && Char.IsWhiteSpace(str[i + 1]))
                {
                    i++;
                }
                /*
                for (; i < str.Length; i++) {
                    if (!Char.IsWhiteSpace(str[i])) {
                        i--;
                        break;
                    }
                }
                */
            }
            else
            {
                res += str[i];
            }
        }

        return res;
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
    public static bool CheckPasswordConstraints(string pwd)
    {
        // TODO: Write your code here.
        bool hasUpper = false;
        bool hasLower = false;
        bool hasSpecial = false;
        bool hasDigit = false;
        bool hasLength = pwd.Length >= 8;

        for (int i = 0; i < pwd.Length; i++)
        {
            char ch = pwd[i];
            if (char.IsUpper(ch))
            {
                hasUpper = true;
            }
            else if (char.IsLower(ch))
            {
                hasLower = true;
            }
            else if (!char.IsLetterOrDigit(ch))
            {
                hasSpecial = true;
            }
            else if (char.IsDigit(ch))
            {
                hasDigit = true;
            }
        }

        return hasUpper && hasLower && hasSpecial && hasDigit && hasLength;
    }
}
