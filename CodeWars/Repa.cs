using static Repa;

internal class Repa
{
    // linea 934

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
            var singleChars = str.Distinct().ToList();

            singleChars.ForEach(c => dic.Add(c, str.Count(i => i == c)));



            return dic;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Count("aaaa"));
            Console.WriteLine(Count("aabb"));
        }






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


