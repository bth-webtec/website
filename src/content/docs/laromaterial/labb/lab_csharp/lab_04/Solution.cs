/**
 * This module contains the methods you should implement.
 */

/*

TODO

* More advanced
    * Sortera
    * En tärningsserie till histogram
    * Serie med temperatur, returnera high, low, snitt på natten och snitt på dagen
    * Tärningar kontrollera om det är en stege, kåk eller fyrtal
    * Array av tal, kontrollera hur många gånger talet finns i arrayen

* Built in functions
    * Abs
    * Pow
    * Exp

* More advanced
    * array av array, GetLEngth
    * Summera tal i en matris
    * Räkna delsummav av varje array i en matris
    * Sänka skepp
    * Celler med grannar (minsweep)
*/

static class Solution
{
    /**
     * Return the string "Hello World!".
     * @return String the string with the message.
     */
    public static String Hello()
    {
        // @TODO: Write your code here.
        return "Hello World!";
    }

    // Number basics

    /**
     * Return the square root of 2, rounded to 4 decimals. Use built in methods.
     * @return double the square root of two.
     */
    public static double SquareOfTwo()
    {
        // @TODO: Write your code here.
        return Math.Round(Math.Sqrt(2), 4);
    }

    /**
     * Return the sum of a and b, rounded to two decimals.
     * @return double sum of the two numbers, rounded 2 decimals.
     */
    public static double Addition(double a, double b)
    {
        // @TODO: Write your code here.
        return Math.Round(a + b, 2);
    }

    /**
     * Return the integer value of the incoming string str.
     * @return int value of string.
     */
    public static Int32 IntValString(String str)
    {
        // @TODO: Write your code here.
        return int.Parse(str);
    }

    /**
     * Use string formatting to create a string with Math.PI and present it with
     * 5 decimals.
     * @return String with the value of pi with 5 decimals.
     */
    public static string FormatPiAsString()
    {
        // @TODO: Write your code here.
        return $"{Math.PI:F5}";
    }

    /**
     * Round the incoming value val to it closest higher integer.
     * @return int as the rounded value.
     */
    public static int RoundUp(double val)
    {
        // @TODO: Write your code here.
        return (int) Math.Ceiling(val);
    }

    /**
     * Round the incoming value val to it closest lower integer.
     * @return int as the rounded value.
     */
    public static int RoundDown(double val)
    {
        // @TODO: Write your code here.
        return (int) Math.Floor(val);
    }

    // Numbers in an array

    /**
     * Return the length of the incoming array arr.
     * @return int length of array.
     */
    public static int LengthOfArray(int[] arr)
    {
        // @TODO: Write your code here.
        return arr.Length;
    }

    /**
     * Return the first item in the array.
     * @return int first item in the array.
     */
    public static int FirstItemInArray(int[] arr)
    {
        // @TODO: Write your code here.
        return arr[0];
    }

    /**
     * Return the last item in the array.
     * @return int first item in the array.
     */
    public static int LastItemInArray(int[] arr)
    {
        // @TODO: Write your code here.
        return arr[arr.Length - 1];
    }

    /**
     * Return the middle item in the array, if the middle has two values, then
     * return the average of the two values and round the result.
     * @return int mid item or average of mid items.
     */
    public static int MidItemInArray(int[] arr)
    {
        // @TODO: Write your code here.
        int midValue;
        if (arr.Length % 2 == 1) {
            midValue = arr[(arr.Length / 2)];
        } else {
            int mid = arr.Length / 2;
            midValue = (int) Math.Round((double) arr[mid - 1] + arr[mid]) / 2;
        }
        return midValue;
    }

    /**
     * Sum all items in the array.
     * @return int sum of the items in the array.
     */
    public static int SumArray(int[] arr)
    {
        // @TODO: Write your code here.
        int sum = 0;
        foreach (int i in arr) {
            sum += i;
        }
        return sum;
    }

    /**
     * Find the largest value in the array.
     * @return int the largest value in the array.
     */
    public static int Max(int[] arr)
    {
        // @TODO: Write your code here.
        int max = arr[0];
        foreach (int i in arr) {
            if (i > max) {
                max = i;
            }
        }
        return max;
    }

    /**
     * Check if the array is sorted in ascending order.
     * @return boolean true if sorted array else false.
     */
    public static Boolean IsSorted(int[] arr)
    {
        // @TODO: Write your code here.
        int last = arr[0];
        foreach (int i in arr) {
            if (last > i) {
                return false;
            }
         }
        return true;
    }

    /**
     * Count the average of the items in the array, round up to the nearest
     * integer.
     * @return int average of the array items, rounded up.
     */
    public static int Average(int[] arr)
    {
        // @TODO: Write your code here.
        int sum = SumArray(arr);
        int average = (int) Math.Ceiling((double) sum / arr.Length);
        return average;
    }

    // BELOW CURRENTLY NOT USED

    // "reverse", int[].class), new Object[]{arr1}, rev1, 2));
    // "reverse", int[].class), new Object[]{arr2}, rev2));

    // "sort", int[].class), new Object[]{sort1}, sorted1, 2));
    // "sort", int[].class), new Object[]{sort2}, sorted2));

    // "median", int[].class), new Object[]{arr1}, 4, 2));
    // "median", int[].class), new Object[]{sort2}, 17));

    /**
     * Clone the incoming array and reverse the items in the clone (change its
     * order and reverse all items in it).
     * @return int[] cloned array with reversed content.
     */
    // public static int[] reverse(int[] arr)
    // {
    //     // @TODO: Write your code here.
    //     int[] res = {};
    //     return res;
    // }

    /**
     * Clone the incoming array into a new array and the sort it, return the 
     * cloned and sorted array.
     * @return int[] cloned array with sorted content.
     */
    // public static int[] sort(int[] arr)
    // {
    //     // @TODO: Write your code here.
    //     int[] res = {};
    //     return res;
    // }

    /**
     * Find the median value in the array arr, but do not modify the incoming
     * array.
     * @return int mean value in the array.
     */
    // public static int median(int[] arr)
    // {
    //     // @TODO: Write your code here.
    //     return 42;
    // }

}
