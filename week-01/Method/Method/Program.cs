using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("1. CheckEvenOdd(7): " + CheckEvenOdd(7));

        Console.WriteLine("2. GetMax(10, 25, 15): " + GetMax(10, 25, 15));

        Console.WriteLine("3. Reverse(\"hello\"): " + Reverse("hello"));

        Console.WriteLine("4. GetSum(5): " + GetSum(5));

        Console.WriteLine("5. MultiTable(5):");
        MultiTable(5);

        Console.WriteLine("6. GetFactorial(4): " + GetFactorial(4));

        int[] MyArray = { 1, 2, 3, 4 };
        Console.WriteLine("7. SumArray(): " + SumArray(MyArray));

        Console.WriteLine("8. IsPalindrome(\"radar\"): " + IsPalindrome("radar"));

        Console.WriteLine("9. CountVowels(\"programming\"): " + CountVowels("programming"));

        Console.WriteLine("10. IsPrime(11): " + IsPrime(11));

        Console.ReadLine();
    }

    public static string CheckEvenOdd(int num)
    {
        if (num % 2 == 0) return "Even";
        else return "Odd";
    }

    public static int GetMax(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    public static string Reverse(string text)
    {
        string result = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            result += text[i];
        }
        return result;
    }

    public static int GetSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    public static void MultiTable(int num)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("   " + num + " x " + i + " = " + (num * i));
        }
    }

    public static int GetFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static int SumArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public static bool IsPalindrome(string text)
    {
        string reversed = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversed += text[i];
        }
        return text == reversed;
    }

    public static int CountVowels(string text)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                count++;
            }
        }
        return count;
    }

    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}