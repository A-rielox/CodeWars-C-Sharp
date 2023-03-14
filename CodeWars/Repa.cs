internal class Repa
{

    //     6 kyu    Sort the odd
    // You will be given an array of numbers.You have to sort the odd
    // numbers in ascending order while leaving the even numbers at their
    // original positions.
    // 
    // Examples
    // [7, 1]  =>  [1, 7]
    // [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
    // [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]


    public static class Kata2
    {
        public static int[] SortArray(int[] array)
        {
            var odds = array.Where(i => i % 2 != 0).OrderBy(n => n).ToList();

            var oddIdx = 0;

            var ordered = array.Select(i => (i % 2 == 0) ? i : odds[oddIdx++] );
           
            return ordered.ToArray();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(SortArray(new int[] { 7, 1 }));
            //Console.WriteLine(SortArray(new int[] { 5, 8, 6, 3, 4 }));
            Console.WriteLine(SortArray(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
            Console.WriteLine(SortArray(new int[] { 15, 17, 43, 20, 17, 21, 23, 43, 43, 48, 47, 61, 17, 38, 67, 63, 28 }));
        }
    }




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


