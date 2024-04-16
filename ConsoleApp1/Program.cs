using System;

public class Functions
{
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
            return;

        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    public static bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        str = str.ToLower().Replace(" ", "");

        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    public static long Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал не определен для отрицательных чисел");
        }
        else if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

    public static int CalculateFibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Число Фибоначчи не определено для отрицательных индексов");
        }
        else if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int a = 0;
            int b = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }

    public static int Search(string text, string pattern)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(pattern))
            return -1;

        int textLength = text.Length;
        int patternLength = pattern.Length;

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            int j;
            for (j = 0; j < patternLength; j++)
            {
                if (text[i + j] != pattern[j])
                    break;
            }
            if (j == patternLength)
                return i;
        }

        return -1;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    public static int Reverse(int x)
    {
        int reversed = 0;

        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && digit > 7))
                return 0;
            if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && digit < -8))
                return 0;

            reversed = reversed * 10 + digit;
        }

        return reversed;
    }

    public static string IntToRoman(int num)
    {
        if (num < 1 || num > 3999)
        {
            throw new ArgumentException("Число должно быть в диапазоне от 1 до 3999.");
        }

        string[] thousands = { "", "M", "MM", "MMM" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return thousands[num / 1000] +
               hundreds[(num % 1000) / 100] +
               tens[(num % 100) / 10] +
               ones[num % 10];
    }
}