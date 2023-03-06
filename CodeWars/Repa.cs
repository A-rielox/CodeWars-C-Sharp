
using static Repa;
using System.Diagnostics.Metrics;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Security.Cryptography;
using System;

internal class Repa
{
    //     6 kyu   Sum of Digits / Digital Root
    // Digital root is the recursive sum of all the
    // digits in a number.
    // 
    // Given n, take the sum of the digits of n. If that
    // value has more than one digit, continue reducing in
    // this way until a single-digit number is produced.The
    // input will be a non-negative integer.
    // 
    // Examples
    //     16  -->  1 + 6 = 7
    //    942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
    // 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
    // 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2



    // int index = char.ToUpper(c) - 64;

    public static class Kata2
    {
        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(0)); // 0
            Console.WriteLine(DigitalRoot(10)); // 1
            Console.WriteLine(DigitalRoot(17)); // 8
            Console.WriteLine(DigitalRoot(942); // 6
            Console.WriteLine(DigitalRoot(132189)); // 6
            Console.WriteLine(DigitalRoot(493193); // 2
            
        }
    }


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


