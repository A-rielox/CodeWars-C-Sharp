//Given an integral number, determine if it's a square number:

//    In mathematics, a square number or perfect square is an
//    integer that is the square of an integer; in other words,
//    it is the product of some integer with itself.

//The tests will always use some integral number, so don't worry
//about that in dynamic typed languages.
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




//Consider an array/list of sheep where some sheep may be missing
//from their place.
//We need a function that counts the number of sheep present in the
//array (true means present).

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
//But you're an ambitious person. You want to know if you're better
//than the average student in your class.

//You receive an array with your peers' test scores. Now calculate the
//average and compare your score!

//Return True if you're better, else False!
//Note:

//Your points are not included in the array of your class's points. For
//calculating the average point you may add your point to the given array!

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

        var spinedArr = arr.Select(word => word.Length >= 5 ?
                                        String.Concat(word.Reverse()) : word);

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
//     The first century spans from the year 1 up to and including the year 100,
// the second century - from the year 101 up to and including the year 200, etc.
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


/*
public static class Kata2
{
    // 6 kyu    Counting Duplicates
    // Write a function that will return the count of distinct case-insensitive
    // alphabetic characters and numeric digits that occur more than once in the
    // input string. The input string can be assumed to contain only alphabets(both
    // uppercase and lowercase) and numeric digits.
    // 
    // Example
    // "abcde" -> 0 # no characters repeats more than once
    // "aabbcde" -> 2 # 'a' and 'b'
    // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    // "indivisibility" -> 1 # 'i' occurs six times
    // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    // "aA11" -> 2 # 'a' and '1'
    // "ABBA" -> 2 # 'A' and 'B' each occur twice


    public static int DuplicateCount(string str)
    {
        // int nume = 0;

        // var distinctsssss = str.ToLower().Distinct().ToList();

        // distinctsssss.ForEach(i => nume = str.ToLower().Count(c => c == i) > 1 ?
        //                                             nume + 1 : nume + 0);

        // return nume;


        var ggs = str.ToLower().GroupBy(c => c).Count(i => i.Count() > 1);

        return ggs;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(DuplicateCount("abcde"));
        Console.WriteLine(DuplicateCount("aabbcde"));
        Console.WriteLine(DuplicateCount("aabBcde"));
        Console.WriteLine(DuplicateCount("indivisibility"));
        Console.WriteLine(DuplicateCount("Indivisibilities"));
        Console.WriteLine(DuplicateCount("aA11"));
        Console.WriteLine(DuplicateCount("ABBA"));
    }
}
*/





/*
public static class Kata2
{
    //         6 kyu   Are they the "same"?
    // Given two arrays a and b write a function comp(a, b) (orcompSame(a, b))
    // that checks whether the two arrays have the "same" elements, with the same
    // multiplicities(the multiplicity of a member is the number of times it appears).
    // "Same" means, here, that the elements in b are the elements in a squared,
    // regardless of the order.
    //         Examples
    //         Valid arrays
    // a = [121, 144, 19, 161, 19, 144, 19, 11]
    // b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
    //         comp(a, b) returns true because in b 121 is the square of 11, 14641
    //         is the square of 121, 20736 the square of 144, 361 the square of 19,
    //         25921 the square of 161, and so on.It gets obvious if we write b's
    //         elements in terms of squares:
    // 
    // a = [121, 144, 19, 161, 19, 144, 19, 11]
    //         b = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19]
    //               fd        pp       kk     fk       yy     kf       fj      hh          
    //         Invalid arrays
    // If, for example, we change the first number to something else, comp is not
    // returning true anymore:
    // 
    // a = [121, 144, 19, 161, 19, 144, 19, 11]
    //         b = [132, 14641, 20736, 361, 25921, 361, 20736, 361]
    //         comp(a, b) returns false because in b 132 is not the square of any
    //         number of a.
    //         a = [121, 144, 19, 161, 19, 144, 19, 11]
    // b = [121, 14641, 20736, 36100, 25921, 361, 20736, 361]
    //         comp(a, b) returns false because in b 36100 is not the square of any
    //         number of a.
    // 
    // 
    //         Remarks
    //         a or b might be [] or { }
    //         (all languages except R, Shell).
    // a or b might be nil or null or None or nothing(except in C++, COBOL, Crystal,
    // D, Dart, Elixir, Fortran, F#, Haskell, Nim, OCaml, Pascal, Perl, PowerShell,
    // Prolog, PureScript, R, Racket, Rust, Shell, Swift).
    // If a or b are nil (or null or None, depending on the language), the problem
    // doesn't make sense so return false.




    public static bool comp(int[] a, int[] b)
    {
        if ((a == null) || (b == null)) return false;


        var res = a.Select(i => i * i).OrderBy(i => i).SequenceEqual(b.OrderBy(n => n));

        return res;
    }

    static void Main(string[] args)
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };

        int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
        int[] c = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        int[] d = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
        int[] e = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };


        Console.WriteLine(comp(a, b));
        Console.WriteLine(comp(a, c));
        Console.WriteLine(comp(a, d));
        Console.WriteLine(comp(a, e));
    }
}
*/


/*
public static class Kata2
{

    //         6 kyu   Build a pile of Cubes
    // Instructions
    // Your task is to construct a building which will be a pile of n cubes.The cube
    // at the bottom will have a volume of n^3, the cube above will have volume of
    // ( n - 1 ) ^3 and so on until the top which will have a volume of 1^3

    // You are given the total volume m of the building. Being given m can you find the
    // number n of cubes you will have to build?

    // The parameter of the function findNb (find_nb, find-nb, findNb, ...)
    // will be an integer m and you have to return the integer n such as
    // n^3 + ( n - 1 )^3 + ( n - 2 )^3 + ... + 1^3 = m  if such a n exists or -1 if there is no such n.

    //         Examples:
    // findNb(1071225) --> 45
    // 
    // findNb(91716553919377) --> -1

    // Assert.AreEqual(2022, ASum.findNb(4183059834009));
    //  Assert.AreEqual(-1, ASum.findNb(24723578342962));
    // Assert.AreEqual(4824, ASum.findNb(135440716410000));
    //  Assert.AreEqual(3568, ASum.findNb(40539911473216));

    public static long findNb(long m)
    {
        int times = 1;
        long suma = 0;

        while (suma < m)
        {
            suma += (long)Math.Pow(times, 3);
            times++;
        }

        return suma != m ? -1 : times - 1;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(findNb(4183059834009));
        Console.WriteLine(findNb(24723578342962));
        Console.WriteLine(findNb(135440716410000));
        Console.WriteLine(findNb(40539911473216));
    }
}

*/




// ----------------------------------------------------------------------------------------





//     6 kyu  Jungerstein's Math Training Room: 1. How many zeros are at
//     the end of n!! ?
// Instructions
// Define n!! as
// 
// n!! = 1 * 3 * 5 * ... * n if n is odd,
// 
// n!! = 2 * 4 * 6 * ... * n if n is even.
// 
// Hence 8!! = 2 * 4 * 6 * 8 = 384, there is no zero at the end.
//
// 30!! has 3 zeros at the end.
// 
// For a positive integer n, please count how many zeros are there at the
// end of n!!.
// 
// Example:
// 
// 30!! = 2 * 4 * 6 * 8 * 10 * ... * 22 * 24 * 26 * 28 * 30 
// 30!! = 42849873690624000 (3 zeros at the end)

//Act(0, 8);
//Act(1, 14);
//Act(3, 30);



/*
using System.Numerics;

public static class Kata2
{


    public static int CountZeros(int n)
    {
        var allFactors = Enumerable.Range(1, n).Where(i => n % 2 == 0 ? i % 2 == 0 : i % 2 != 0).ToArray();

        BigInteger result = 1;
        for (int i = 0; i <= allFactors.Count() - 1; i++)
        {
            result *= allFactors[i];
        }


        return string.Concat(result.ToString().Reverse()).TakeWhile(n => n == '0').Count();
    }


    static void Main(string[] args)
    {
        Console.WriteLine(CountZeros(8));
        Console.WriteLine(CountZeros(14));
        Console.WriteLine(CountZeros(30));
        Console.WriteLine(CountZeros(500));
    }
}
*/




//              ***************


/*
//     6 kyu  Does my number look big in this?
// DESCRIPTION:
// A Narcissistic Number(or Armstrong Number) is a positive number
// which is the sum of its own digits, each raised to the power of
// the number of digits in a given base. In this Kata, we will restrict
// ourselves to decimal (base 10).
// 
// For example, take 153 (3 digits), which is narcissistic:
// 
//     1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
// and 1652 (4 digits), which isn't:
// 
//     1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
// The Challenge:
// 
// Your code must return true or false (not 'true' and 'false') depending
// upon whether the given number is a Narcissistic number in base 10.
// 
// This may be True and False in your language, e.g.PHP.
//     Error checking for text strings or other invalid inputs is not
//     required, only valid positive non-zero integers will be passed
//     into the function.

// "1 is narcissitic" --> true
// "371 is narcissitic" --> true


public static class Kata2
{


    public static bool Narcissistic(int value)
    {
        var arr = value.ToString().Select(i => int.Parse(i.ToString())).ToList();

        double tot = 0;

        arr.ForEach(i => tot += Math.Pow(i, arr.Count()));

        return tot == value ? true : false;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(Narcissistic(153));
        Console.WriteLine(Narcissistic(371));
        Console.WriteLine(Narcissistic(1652));
    }
}
*/





/*
//     6 kyu
// Is a number prime?
// Define a function that takes an integer argument and returns a
// logical value true or false depending on if the integer is a prime.
//     Per Wikipedia, a prime number (or a prime) is a natural number
// greater than 1 that has no positive divisors other than 1 and itself.
// 
// Requirements
// You can assume you will be given an integer input.
// You can not assume that the integer will be only positive.You may be
// given negative numbers as well (or 0 ).

// Example
// is_prime(1)   false
// is_prime(2)   true 
// is_prime(-1)  false
// yield return new TestCaseData(0).Returns(false);
// yield return new TestCaseData(1).Returns(false);
// yield return new TestCaseData(2).Returns(true);

public static class Kata2
{


    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;

        var lessArr = Enumerable.Range(2, n - 2).ToList();

        var isPrime = true;

        for (int i = 0; i < lessArr.Count(); i++)
        {
            if (n % lessArr[i] == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;

        //if(n > 1)
        //{
        //    return Enumerable.Range(1, n).Where(i => n % i == 0).SequenceEqual(new[] {1, n});
        //}
        //else
        //{
        //    return false;
        //}
    }


    static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(0));
        Console.WriteLine(IsPrime(1));
        Console.WriteLine(IsPrime(2));
        Console.WriteLine(IsPrime(7));
        Console.WriteLine(IsPrime(11));
        Console.WriteLine(IsPrime(20));
        Console.WriteLine(IsPrime(-5));
    }
}
*/
















