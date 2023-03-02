
internal class Repa
{




    //public static class Kata2
    //{
    //    // 6 kyu    Counting Duplicates
    //    // Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.
    //    // 
    //    // Example
    //    // "abcde" -> 0 # no characters repeats more than once
    //    // "aabbcde" -> 2 # 'a' and 'b'
    //    // "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    //    // "indivisibility" -> 1 # 'i' occurs six times
    //    // "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    //    // "aA11" -> 2 # 'a' and '1'
    //    // "ABBA" -> 2 # 'A' and 'B' each occur twice




    //    public static int DuplicateCount(string str)
    //    {
    //        // int nume = 0;

    //        // var distinctsssss = str.ToLower().Distinct().ToList();

    //        // distinctsssss.ForEach(i => nume = str.ToLower().Count(c => c == i) > 1 ?
    //        //                                             nume + 1 : nume + 0);

    //        // return nume;


    //        var ggs = str.ToLower().GroupBy(c => c).Count(i => i.Count() > 1);

    //        return ggs;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(DuplicateCount("abcde"));
    //        Console.WriteLine(DuplicateCount("aabbcde"));
    //        Console.WriteLine(DuplicateCount("aabBcde"));
    //        Console.WriteLine(DuplicateCount("indivisibility"));
    //        Console.WriteLine(DuplicateCount("Indivisibilities"));
    //        Console.WriteLine(DuplicateCount("aA11"));
    //        Console.WriteLine(DuplicateCount("ABBA"));
    //    }
    //}



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


