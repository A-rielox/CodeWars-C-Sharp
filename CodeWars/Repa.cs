using System.Numerics;
using static Repa;

internal class Repa
{
    // linea 934

    public static class Kata2
    {
        //     6 kyu   Replace With Alphabet Position
        // 
        // In this kata you are required to, given a string, replace every
        // letter with its position in the alphabet.
        // 
        // If anything in the text isn't a letter, ignore it and don't return it.
        // 
        // "a" = 1, "b" = 2, etc.
        // 
        // Example
        // Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
        // Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15
        // 3 12 15 3 11" ( as a string )

        //     ("The sunset sets at twelve o' clock."));
        // ("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", 
        // 
        //     ("The narwhal bacons at midnight."));
        // ("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", 

        public static string AlphabetPosition(string text)
        {
            var alph = "abcdefghijklmnopqrstuvwxyz";
            var justLett = text.ToLower().Where(c => char.IsLetter(c));

            var idxs = justLett.Select(c => alph.IndexOf(c) + 1);



            return string.Join(" ",idxs);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));
            // Console.WriteLine( AlphabetPosition( ) );
        }









        // ---------------------------------------------
        // ---------------------------------------------








        //     6 kyu   Find The Parity Outlier
        // You are given an array(which will have a length of at least 3, but could be very large)
        // containing integers.The array is either entirely comprised of odd integers or entirely
        // comprised of even integers except for a single integer N. Write a method that takes
        // the array as an argument and returns this "outlier" N.

        //     Examples
        //     [2, 4, 0, 100, 4, 11, 2602, 36]
        //     Should return: 11 (the only odd number)
        // 
        // [160, 3, 1719, 19, 11, 13, -21]
        //     Should return: 160 (the only even number)

        //public static int Find(int[] integers)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Find(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }));
        //    Console.WriteLine(Find(new int[] { 160, 3, 1719, 19, 11, 13, -21 }));
        //    //Console.WriteLine(Find(new int[] { }));
        //}








        // ---------------------------------------------
        // ---------------------------------------------








        //     6 kyu  Pair of gloves
        // Winter is coming, you must prepare your ski holidays.The
        // objective of this kata is to determine the number of pair
        // of gloves you can constitute from the gloves you have in your
        // drawer.
        // 
        // Given an array describing the color of each glove, return the
        // number of pairs you can constitute, assuming that only gloves of
        // the same color can form pairs.
        // 
        // Examples:
        // input = ["red", "green", "red", "blue", "blue"]
        // result = 2(1 red pair + 1 blue pair)
        // 
        // input = ["red", "red", "red", "red", "red", "red"]
        // result = 3(3 red pairs)

        // Assertion(0, new string[] {"Green", "Blue", "Purple", "Gray"});
        // Assertion(0, new string[] { });

        //public static int NumberOfPairs(string[] gloves)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(NumberOfPairs(new string[] { "red", "green", "red", "blue", "blue" }));
        //    Console.WriteLine(NumberOfPairs(new string[] { "red", "red", "red", "red", "red", "red" }));
        //    Console.WriteLine(NumberOfPairs(new string[] { "Green", "Blue", "Purple", "Gray" }));
        //    Console.WriteLine(NumberOfPairs(new string[] { }));
        //}








        // ---------------------------------------------
        // ---------------------------------------------








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

        //public static bool IsPrime(int n)
        //{
        //    if(n <= 1) return false;

        //    var primesUnder = Enumerable.Range(1, n).Where(i => n % i == 0).ToArray();

        //    var isIt = primesUnder.SequenceEqual(new int[] { 1, n });

        //    return isIt;
        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(IsPrime(0));
        //    Console.WriteLine(IsPrime(1));
        //    Console.WriteLine(IsPrime(2));
        //    Console.WriteLine(IsPrime(7));
        //    Console.WriteLine(IsPrime(11));
        //    Console.WriteLine(IsPrime(20));
        //    Console.WriteLine(IsPrime(-5));
        //}






        // ---------------------------------------------
        // ---------------------------------------------








        //     6 kyu  Does my number look big in this?
        // DESCRIPTION:
        // A Narcissistic Number(or Armstrong Number) is a positive number
        // which is the sum of its own digits, each raised to the power of
        // the number of digits in a given base. In this Kata, we will restrict
        // ourselves to decimal (base 10).
        // 
        // For example, take 153 (3 digits), which is narcissistic:
        //     1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        //
        // and 1652 (4 digits), which isn't:
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

        //public static bool Narcissistic(int value)
        //{
        //    var singles = value.ToString().Select(c => int.Parse(c.ToString()));

        //    var sumXd = singles.Sum(n => Math.Pow(n,singles.Count()));

        //    return sumXd == value;
        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Narcissistic(153));
        //    Console.WriteLine(Narcissistic(371));
        //    Console.WriteLine(Narcissistic(1652));
        //}





        // ---------------------------------------------
        // ---------------------------------------------









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

        //public static int CountZeros(int n)
        //{
        //    var nums = Enumerable.Range(1,n).Where(i => n % 2 == 0 ? i % 2 == 0 : i % 2 != 0 );

        //    BigInteger mult = 1;

        //    foreach (var i in nums)
        //    {
        //        mult = mult * i;
        //    }

        //    var zeroessss = mult.ToString()
        //                        .Select(c => (int)int.Parse(c.ToString()))
        //                        .Reverse()
        //                        .TakeWhile(n => n == 0)
        //                        .Count();

        //    return 2;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(CountZeros(8));
        //    Console.WriteLine(CountZeros(14));
        //    Console.WriteLine(CountZeros(30));
        //    Console.WriteLine(CountZeros(500));
        //}





        // ---------------------------------------------
        // ---------------------------------------------









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

        //public static bool comp(int[] a, int[] b)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };

        //    int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
        //    int[] c = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        //    int[] d = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
        //    int[] e = new int[] { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };


        //    Console.WriteLine(comp(a, b)); // t
        //    Console.WriteLine(comp(a, c)); // t
        //    Console.WriteLine(comp(a, d)); // f
        //    Console.WriteLine(comp(a, e)); // f
        //}






        // ---------------------------------------------
        // ---------------------------------------------










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

        //public static int DuplicateCount(string str)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(DuplicateCount("abcde"));
        //    Console.WriteLine(DuplicateCount("aabbcde"));
        //    Console.WriteLine(DuplicateCount("aabBcde"));
        //    Console.WriteLine(DuplicateCount("indivisibility"));
        //    Console.WriteLine(DuplicateCount("Indivisibilities"));
        //    Console.WriteLine(DuplicateCount("aA11"));
        //    Console.WriteLine(DuplicateCount("ABBA"));
        //}






        // ---------------------------------------------
        // ---------------------------------------------










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

        //public static Dictionary<char, int> Count(string str)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Count("aaaa"));
        //    Console.WriteLine(Count("aabb"));
        //}






        // ---------------------------------------------
        // ---------------------------------------------










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

        //public static bool ValidParentheses(string input)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ValidParentheses("()"));
        //    Console.WriteLine(ValidParentheses(")(()))"));
        //    Console.WriteLine(ValidParentheses("("));
        //    Console.WriteLine(ValidParentheses("(())((()())())"));
        //}






        // ---------------------------------------------
        // ---------------------------------------------








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

        //public static int СenturyFromYear(int year)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(СenturyFromYear(1705));
        //    Console.WriteLine(СenturyFromYear(1900));
        //    Console.WriteLine(СenturyFromYear(1601));
        //    Console.WriteLine(СenturyFromYear(2000));
        //}






        // ---------------------------------------------
        // ---------------------------------------------








        //public static int SumMix(object[] x)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(SumMix(new object[] { 9, 3, "7", "3" })); // 22
        //    Console.WriteLine(SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 })); // 42
        //    Console.WriteLine(SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" })); // 41
        //}






        // ---------------------------------------------
        // ---------------------------------------------








        //     7 kyu   Vowel Count
        // Return the number(count) of vowels in the given string.
        // 
        // We will consider a, e, i, o, u as vowels for this Kata(but not y).
        // 
        // The input string will only consist of lower case letters and/or spaces.
        // Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");

        //public static int GetVowelCount(string str)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetVowelCount("abracadabra"));
        //}







        // ---------------------------------------------
        // ---------------------------------------------









        //     8 kyu    Reversed sequence
        // Instructions 
        // Build a function that returns an array of integers from n to 1 where n>0.
        // 
        // Example : n=5 --> [5,4,3,2,1]

        //public static int[] ReverseSeq(int n)
        //{
        //    return Enumerable.Range(1,n).Reverse().ToArray();
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(string.Join(" ", ReverseSeq(5)));
        //}







        // ---------------------------------------------
        // ---------------------------------------------











        // 7 kyu    Printer Errors
        // Instructions

        // LETRAS CORRECTAS SON a --> m , EL RESTO SON ERRORES
        // ENCONTRAR EL RATIO ERRORES (FUERA DE A - M) / TOTAL DE CHARS

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

        //public static string PrinterError(String s)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(PrinterError("aaabbbbhaijjjm"));
        //    Console.WriteLine(PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
        //    Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
        //}








        // ---------------------------------------------
        // ---------------------------------------------














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

        //public static string Longest(string s1, string s2)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
        //    Console.WriteLine(Longest("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz"));
        //}









        // ---------------------------------------------
        // ---------------------------------------------











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

        //public static bool XO(string input)
        //{

        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(XO("ooxx"));
        //    Console.WriteLine(XO("xooxx"));
        //    Console.WriteLine(XO("ooxXm"));
        //    Console.WriteLine(XO("zpzpzpp"));
        //    Console.WriteLine(XO("zzoo"));
        //}













        // ---------------------------------------------
        // ---------------------------------------------











        // 6 kyu
        // Convert string to camel case
        // Complete the method/function so that it converts dash/underscore delimited words into camel casing.
        // The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.
        // Examples
        //     "the-stealth-warrior" gets converted to "theStealthWarrior"
        //     "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

        //public static string ToCamelCase(string str)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ToCamelCase("the-stealth-warrior"));
        //    Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
        //}











        // ---------------------------------------------
        // ---------------------------------------------










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

        //public static string SpinWords(string sentence)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(SpinWords("Welcome"));
        //    Console.WriteLine(SpinWords("Hey fellow warriors"));
        //    Console.WriteLine(SpinWords("This is a test"));
        //    Console.WriteLine(SpinWords("This is another test"));
        //}











        // ---------------------------------------------
        // ---------------------------------------------









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

        //public static int Solution(int value)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Solution(10));
        //}










        // ---------------------------------------------
        // ---------------------------------------------










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

        //public static double basicOp(char operation, double value1, double value2)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(basicOp('+', 4, 7));
        //    Console.WriteLine(basicOp('-', 15, 18));
        //    Console.WriteLine(basicOp('*', 5, 5));
        //    Console.WriteLine(basicOp('/', 49, 7));
        //}







        // ---------------------------------------------
        // ---------------------------------------------







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

        //[TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        //[TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        //[TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]

        //public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        //{

        //}

        //static void Main(string[] args)
        //{

        //    Console.WriteLine(BetterThanAverage(new int[] { 2, 3 }, 5));
        //    Console.WriteLine(BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75));
        //    Console.WriteLine(BetterThanAverage(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69));

        //}




        // ---------------------------------------------
        // ---------------------------------------------




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


        //public static int CountSheeps(bool[] sheeps)
        //{

        //}

        //static void Main(string[] args)
        //{
        //    bool[] sheeps = {
        //        true, true, true, false, true, true, true, true, true,
        //        false, true, false, true, false, false, true, true, true,
        //        true, true, false, false, true, true 
        //    };

        //    Console.WriteLine(Kata2.CountSheeps(sheeps));
        //}




        // ---------------------------------------------
        // ---------------------------------------------




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

        //public static bool IsSquare(int n)
        //{
        //    return Math.Sqrt(n) % 1 == 0;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Kata2.IsSquare(2));
        //    Console.WriteLine(Kata2.IsSquare(4));
        //    Console.WriteLine(Kata2.IsSquare(7));
        //    Console.WriteLine(Kata2.IsSquare(9));
        //}


    }

    //static void Main()
    //{
    //    // Console.WriteLine(string.Join(" ", toIntArr("1 2 3 4 5 6 7")));

    //    var rnd = new Random();

    //    var xd = Enumerable.Range(0,26).Select(n => (char)(n + 'a'));

    //    Console.WriteLine(string.Join(" ",xd));

    //}

    //public static int[] toIntArr(string str)
    //{


    //    return new int[] { };
    //}




    // int index = char.ToUpper(c) - 64;

    public static int Count(string str)
    {

        //  var result = operation switch
        //  {
        //      '+' => a + b,
        //      '-' => a - b,
        //      '*' => a * b,
        //      '/' => a / b,
        //      _ => throw new ArgumentException("Unknown operation", $"{op}")
        //  };

        ////////////////////////////
        //  (string str)
        //  {
        //      var words = str.Split(new[] { '-', '_' }).ToList();
        //      var final = new List<string>() { words[0] };


        // var arr = sentence.Split(" ");


        // ************
        // ************
        // ************


        // var spinedArr = arr.Select(word => word.Length >= 5 ?
        //                                    String.Concat(word.Reverse()) :
        //                                    word);

        // return String.Join(" ", spinedArr);

        ////////////////////////////

        //  for (int i = 1; i < words.Count; i++)
        //  {
        //      var first = words[i].Substring(0, 1).ToUpper();
        //      var rest = words[i].Substring(1).ToLower();

        //      var word = first + rest;
        //      final.Add(word);
        //  }



        ////////////////////////////



        // (string input)
        //
        //
        // return input.ToLower().Count(i => i == 'x') ==
        //        input.ToLower().Count(i => i == 'o');
        //
        //


        ////////////////////////////




        //public static string Longest(string s1, string s2)
        //{
        //    var final = s1.Union(s2).OrderBy(c => c);
        //    var str = string.Join("", final);

        //    return str;
        //}






        ////////////////////////////


        // (String s)
        //
        //
        //  return s.Where(c => c > 'm').Count() + "/" + s.Length;
        //
        //



        ////////////////////////////



        // (string str)
        //
        //
        // return str.Count(i => "aeiou".Contains(i));
        //
        //






        ////////////////////////////


        //   (object[] x)
        //  int sum = 0;

        //  foreach (var i in x)
        //  {
        //      sum += Convert.ToInt32(i);
        //  }

        //  return sum;

        //   return x.Sum(i => Convert.ToInt32(i));








        ////////////////////////////

        // "abcde" -> 0 # no characters repeats more than once
        // "aabbcde" -> 2 # 'a' and 'b'
        // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
        // "indivisibility" -> 1 # 'i' occurs six times
        // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
        // "aA11" -> 2 # 'a' and '1'
        // "ABBA" -> 2 # 'A' and 'B' each occur twice


        // (string str)
        // int nume = 0;

        // var distinctsssss = str.ToLower().Distinct().ToList();

        // distinctsssss.ForEach(i => nume = str.ToLower().Count(c => c == i) > 1 ?
        //                                             nume + 1 : nume + 0);

        // return nume;

        // oooooo

        // var ggs = str.ToLower().GroupBy(c => c).Count(i => i.Count() > 1);








        ////////////////////////////



        return 1;
    }
}


