//Given an integral number, determine if it's a square number:

//    In mathematics, a square number or perfect square is an integer that is the square of an integer; in other words, it is the product of some integer with itself.

//The tests will always use some integral number, so don't worry about that in dynamic typed languages.
//Examples

//-1  =>  false
// 0  =>  true
// 3  =>  false
// 4  =>  true
//25  =>  true
//26  =>  false

/*
using System;

namespace codewar
{


    public class Kata
    {
        public static bool IsSquare(int n)
        {

            return Math.Sqrt(n) % 1 == 0;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsSquare(2));
             Console.WriteLine(Kata.IsSquare(4));
             Console.WriteLine(Kata.IsSquare(7));
            Console.WriteLine(Kata.IsSquare(9));
        }



    }


}
*/




//Consider an array/list of sheep where some sheep may be missing from their place.
//We need a function that counts the number of sheep present in the array (true means present).

//For example,

//[true, true, true, false,
//  true, true, true, true,
//  true, false, true, false,
//  true, false, false, true,
//  true, true, true, true,
//  false, false, true, true]

//The correct answer would be 17.

//Hint: Don 't forget to check for bad values like null/undefined

/*
using System;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        int numOfSheeps = 0;

        foreach (var sheep in sheeps)
        {
            if (sheep == true) numOfSheeps++;
        }


        return numOfSheeps;

        //
        //
        // return sheeps.Count(s => s == true);
        //
        //

    }

    static void Main(string[] args)
    {
        bool[] sheeps = {true, true, true, false, true, true, true, true, true, 
                         false, true, false, true, false, false, true, true, true,
                         true, true, false, false, true, true };

        Console.WriteLine(Kata.CountSheeps(sheeps));

    }
}
*/






//How good are you really?

//There was a test in your class and you passed it. Congratulations!
//But you're an ambitious person. You want to know if you're better than the average student in your class.

//You receive an array with your peers' test scores. Now calculate the average and compare your score!

//Return True if you're better, else False!
//Note:

//Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!

/*
public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        var classAvg = ClassPoints.Sum() / ClassPoints.Length;

        return YourPoints > classAvg ? true : false ;

        //return YourPoints > ClassPoints.Average() ? true : false;
    }

    static void Main(string[] args)
    {

        Console.WriteLine(Kata.BetterThanAverage(new int[] { 2, 3 }, 5));
        Console.WriteLine(Kata.BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75));
        Console.WriteLine(Kata.BetterThanAverage(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69));

    }
}
*/

//[TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
//[TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
//[TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]






//Basic Mathematical Operations

//Your task is to create a function that does four basic mathematical operations.

//The function should take three arguments - operation(string/char), value1(number), value2(number).
//The function should return result of numbers after applying the chosen operation.
//Examples(Operator, value1, value2) --> output

//('+', 4, 7)-- > 11
//('-', 15, 18)-- > -3
//('*', 5, 5)-- > 25
//('/', 49, 7)-- > 7

//Assert.AreEqual(11, Program.basicOp('+', 4, 7));
//Assert.AreEqual(-3, Program.basicOp('-', 15, 18));
//Assert.AreEqual(25, Program.basicOp('*', 5, 5));
//Assert.AreEqual(7, Program.basicOp('/', 49, 7));


/*
namespace Solution
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            

            var result = operation switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '*' => value1 * value2,
                '/' => value1 / value2,
            };

            return result;





            // return op switch
            // {
            //     '+' => a + b,
            //     '-' => a - b,
            //     '*' => a * b,
            //     '/' => a / b,
            //     _ => throw new ArgumentException("Unknown operation", $"{op}")
            // };

        }

        static void Main(string[] args)
        {

            Console.WriteLine(Program.basicOp('+', 4, 7));
            Console.WriteLine(Program.basicOp('-', 15, 18));
            Console.WriteLine(Program.basicOp('*', 5, 5));
            Console.WriteLine(Program.basicOp('/', 49, 7));

        }
    }
}

*/














// Multiples of 3 or 5
// 
// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
// The sum of these multiples is 23.
// 
// Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number
// passed in. Additionally, if the number is negative, return 0 (for languages that do have them).
// 
// Note: If the number is a multiple of bo

// Assert.AreEqual(23, Kata.Solution(10));

/*
public static class Kata
{
    public static int Solution(int value)
    {
        var sum = 0;

        // for (int i = 1; i < value; i++)
        // {
        //     if (i % 3 == 0) sum += i;
        //     else if(i % 5 == 0) sum += i;
        // }

        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) sum += i;
        }

        return sum;
    }

    static void Main(string[] args)
    {

        Console.WriteLine(Kata.Solution(10));

    }
}
*/






//
//              *********
//


// 6 kyu
// Stop gninnipS My sdroW!
// 
// Write a function that takes in a string of one or more words, and returns the same string,
// but with all five or more letter words reversed (Just like the name of this Kata).
// Strings passed in will consist of only letters and spaces. Spaces will be included
// only when more than one word is present.
// 
// Examples:
// 
// spinWords("Hey fellow warriors") => returns "Hey wollef sroirraw"
// spinWords("This is a test") => returns "This is a test"
// spinWords("This is another test")=> returns "This is rehtona test"
// 
//     Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
//     Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
//     Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
//     Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
//     Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
//     Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));

/*
using System.Collections.Generic;
using System.Linq;
using System;
using System.Runtime.CompilerServices;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        // var arr = sentence.Split(' ');
        // var arrSpinned = new List<string>();

        // foreach (var word in arr)
        // {
        //     if (word.Length >= 5)
        //     {

        //         var tempSpined = "";
        //         for (int i = word.Length - 1; i >= 0; i--)
        //         {
        //             tempSpined += word[i];
        //         }

        //         arrSpinned.Add(tempSpined);
        //     }
        //     else
        //     {
        //         arrSpinned.Add(word);
        //     }
        // }

        // return String.Join(" ", arrSpinned).Trim();

        var arr = sentence.Split(" ");

        var spinedArr = arr.Select(word => word.Length >= 5 ? String.Concat(word.Reverse()) : word);

        return String.Join(" ", spinedArr);
    }

    static void Main(string[] args)
    {

        Console.WriteLine(Kata.SpinWords("Welcome"));
        Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));
        Console.WriteLine(Kata.SpinWords("This is a test"));
        Console.WriteLine(Kata.SpinWords("This is another test"));

    }
}
*/



/*
// 6 kyu
// Convert string to camel case
// Complete the method/function so that it converts dash/underscore delimited words into camel casing.
// The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
// Examples
//     "the-stealth-warrior" gets converted to "theStealthWarrior"
//     "The_Stealth_Warrior" gets converted to "TheStealthWarrior"


namespace codewar
{

    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            var words = str.Split(new[] { '-', '_' }).ToList();
            var final = new List<string>() { words[0] };

            for (int i = 1; i < words.Count; i++)
            {
                var first = words[i].Substring(0, 1).ToUpper();
                var rest = words[i].Substring(1).ToLower();

                var word = first + rest;
                final.Add(word);
            }

            return string.Join("", final);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-mtealth-warrior"));
            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
        }
    }
}
*/




/*
namespace codewar;

//     8 kyu
// Convert boolean values to strings 'Yes' or 'No'.
// Instructions
// Output
// Complete the method that takes a boolean value and return a "Yes" string for true,
// or a "No" string for false.


public static class Kata
{
    public static string boolToWord(bool word)
    {
        return word == true ? "Yes" : "No";
    }


    static void Main(string[] args)
    {
        Console.WriteLine(boolToWord(true));
        Console.WriteLine(boolToWord(false));
    }


}
*/


/*
namespace codewar;


//    7 kyu Exes and Ohs
// DESCRIPTION:
// Check to see if a string has the same amount of 'x's and 'o's.The method must return
// a boolean and be case insensitive.The string can contain any char.
// 
// Examples input/output:
// 
// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

public static class Kata
{
    public static bool XO(string input)
    {
        var oses = 0;
        var xses = 0;
        var other = 0;

        foreach (var c in input.ToLower())
        {
            if (c == 'o')
            {
                oses++;
            }
            else if (c == 'x')
            {
                xses++;
            }
            else
            {
                other++;
            }
        }

        if (other == input.Length) return true;

        return oses == xses ? true : false;


        //
        //
        // return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        //
        //
    }


    static void Main(string[] args)
    {
        Console.WriteLine(XO("ooxx"));
        Console.WriteLine(XO("xooxx"));
        Console.WriteLine(XO("ooxXm"));
        Console.WriteLine(XO("zpzpzpp"));
        Console.WriteLine(XO("zzoo"));
    }
}
*/



/*
namespace codewar;


//     7 kyu   Two to One
// Instructions
// Take 2 strings s1 and s2 including only letters from a to z.Return a new sorted string,
// the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
// 
// Examples:
// a = "xyaabbbccccdefww"
// b = "xxxxyyyyabklmopq"
// longest(a, b) -> "abcdefklmopqwxy"
// 
// a = "abcdefghijklmnopqrstuvwxyz"
// longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"


public static class Kata
{
    public static string Longest(string s1, string s2)
    {
        var final = s1.Union(s2).OrderBy(c => c);
        var str = string.Join("", final);

        return str;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
        Console.WriteLine(Longest("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz"));
    }


}
*/



/*
namespace codewar;


// 7 kyu    Printer Errors
// Instructions
// In a factory a printer prints labels for boxes.For one kind of boxes the
// printer has to use colors which, for the sake of simplicity, are named with
// letters from a to m.
//     The colors used by the printer are recorded in a control string. For example
//     a "good" control string would be aaabbbbhaijjjm meaning that the printer used
//     three times color a, four times color b, one time color h then one time color a...
// 
// Sometimes there are problems: lack of colors, technical malfunction and a "bad"
// control string is produced e.g.aaaxbbbbyyhwawiwjjjwwm with letters not from a to m.
// 
// You have to write a function printer_error which given a string will return the error
// rate of the printer as a string representing a rational whose numerator is the number
// of errors and the denominator the length of the control string. Don't reduce this
// fraction to a simpler expression.
// 
// The string has a length greater or equal to one and contains only letters from ato z.
// 
// Examples:
// s= "aaabbbbhaijjjm"
// printer_error(s) => "0/14"
// 
// s= "aaaxbbbbyyhwawiwjjjwwm"
// printer_error(s) => "8/22"

// aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz  3/56


public static class Kata
{
    public static string PrinterError(String s)
    {
        var err = 0;

        foreach (var c in s)
        {
            if (c > 'm') err++;
        }

        return err.ToString() + '/' + s.Length.ToString();



        //
        //
        //  return s.Where(c => c > 'm').Count() + "/" + s.Length;
        //
        //
    }


    static void Main(string[] args)
    {
        Console.WriteLine(PrinterError("aaabbbbhaijjjm"));
        Console.WriteLine(PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
        Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
    }


}

*/



/*
namespace codewar;



//     8 kyu    Reversed sequence
// Instructions 
// Build a function that returns an array of integers from n to 1 where n>0.
// 
// Example : n=5 --> [5,4,3,2,1]

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        var listilla = Enumerable.Range(1, n).Reverse().ToArray();

        return listilla;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(ReverseSeq(5));

    }


}

*/


/*
namespace CodeWars;

//     7 kyu   Vowel Count
// Return the number(count) of vowels in the given string.
// 
// We will consider a, e, i, o, u as vowels for this Kata(but not y).
// 
// The input string will only consist of lower case letters and/or spaces.
// Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");


public static class Kata2
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        var vow = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        foreach (var c in str)
        {
            if (vow.Contains(c)) vowelCount++;
        }

        return vowelCount;

        //
        //
        // return str.Count(i => "aeiou".Contains(i));
        //
        //
    }


    static void Main(string[] args)
    {
        Console.WriteLine(GetVowelCount("abracadabra"));

    }


}
*/

/*
namespace CodeWars;

public static class Kata
{
    public static int SumMix(object[] x)
    {
        //int sum = 0;

        //foreach (var i in x)
        //{
        //    sum += Convert.ToInt32(i);
        //}

        //return sum;

        return x.Sum(i => Convert.ToInt32(i));
    }


    static void Main(string[] args)
    {
        Console.WriteLine(SumMix(new object[] { 9, 3, "7", "3" }));
        Console.WriteLine(SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
        Console.WriteLine(SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));

    }
}
*/



/*
// 8 kyu   Century From Year
// Introduction
//     The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.
// 
// Task
// Given a year, return the century it is in.
// 
// Examples
// 1705 --> 18
// 1900 --> 19
// 1601 --> 17
// 2000 --> 20


public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        return year % 100 == 0 ? year / 100 : (year / 100) + 1;

    }


    static void Main(string[] args)
    {
        Console.WriteLine(СenturyFromYear(1705));
        Console.WriteLine(СenturyFromYear(1900));
        Console.WriteLine(СenturyFromYear(1601));
        Console.WriteLine(СenturyFromYear(2000));

    }
}
*/



/*
//     5 kyu   Valid Parentheses
// Write a function that takes a string of parentheses, and determines if
// the order of the parentheses is valid.The function should return true if
// the string is valid, and false if it's invalid.
// 
// Examples
// "()"              =>  true
// ")(()))"          =>  false
// "("               =>  false
// "(())((()())())"  =>  true
//
// Constraints
// 0 <= input.length <= 100
// 
// Along with opening(() and closing ()) parenthesis, input may contain
// any valid ASCII characters.Furthermore, the input string may be empty
// and/or not contain any parentheses at all.Do not treat other forms of
// brackets as parentheses(e.g. [], { }, <>).


public static class Kata2
{
    public static bool ValidParentheses(string input)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (c == '(')
            {
                count++;
                if (count < 0) return false;
            }
            else
            {
                if (c == ')')
                {
                    count--;
                    if (count < 0) return false;
                }
            }
        }

        return count == 0 ? true : false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ValidParentheses("()"));
        Console.WriteLine(ValidParentheses(")(()))"));
        Console.WriteLine(ValidParentheses("("));
        Console.WriteLine(ValidParentheses("(())((()())())"));
    }
}
*/



/*
public static class Kata2
{

    //         6 kyu      Count characters in your string
    // The main idea is to count all the occurring characters in a string.
    // If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
    // 
    // What if the string is empty? Then the result should be empty object
    // literal, {}.

    // d.Add('a', 4);
    // Assert.AreEqual(d, Kata.Count("aaaa"));
    // 
    // d.Add('a', 2);
    // d.Add('b', 2);
    // Assert.AreEqual(d, Kata.Count("aabb"));

    // IDictionary<int, string> numberNames = new Dictionary<int, string>();
    // numberNames.Add(1,"One"); //adding a key/value using the Add() method



    public static Dictionary<char, int> Count(string str)
    {
        var dic = new Dictionary<char, int>();

        var lett = str.Distinct().ToList();

        lett.ForEach(i => dic.Add(i, str.Count(c => c == i)));

        return dic;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Count("aaaa"));
        Console.WriteLine(Count("aabb"));
    }
}
*/






