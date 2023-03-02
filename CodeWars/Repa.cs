

internal class Repa
{
    //public static class Kata2
    //{

    //    //         6 kyu   Build a pile of Cubes
    //    // Instructions
    //    // Your task is to construct a building which will be a pile of n cubes.The cube
    //    // at the bottom will have a volume of n^3, the cube above will have volume of
    //    // ( n - 1 ) ^3 and so on until the top which will have a volume of 1^3

    //    // You are given the total volume m of the building. Being given m can you find the
    //    // number n of cubes you will have to build?

    //    // The parameter of the function findNb (find_nb, find-nb, findNb, ...)
    //    // will be an integer m and you have to return the integer n such as
    //    // n^3 + ( n - 1 )^3 + ( n - 2 )^3 + ... + 1^3 = m  if such a n exists or -1 if there is no such n.

    //    //         Examples:
    //    // findNb(1071225) --> 45
    //    // 
    //    // findNb(91716553919377) --> -1

    //    // Assert.AreEqual(2022, ASum.findNb(4183059834009));
    //    //  Assert.AreEqual(-1, ASum.findNb(24723578342962));
    //    // Assert.AreEqual(4824, ASum.findNb(135440716410000));
    //    //  Assert.AreEqual(3568, ASum.findNb(40539911473216));

    //    public static long findNb(long m)
    //    {
    //        int times = 1;
    //        long suma = 0;

    //        while (suma < m)
    //        {
    //            suma += (long)Math.Pow(times, 3);
    //            times++;
    //        }

    //        return suma != m ? -1 : times - 1;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(findNb(4183059834009));
    //        Console.WriteLine(findNb(24723578342962));
    //        Console.WriteLine(findNb(135440716410000));
    //        Console.WriteLine(findNb(40539911473216));
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


