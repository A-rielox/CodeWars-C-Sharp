
internal class Repa
{
    //     6 kyu    Your order, please
    // Your task is to sort a given string. Each word in the string will
    // contain a single number.This number is the position the word should
    // have in the result.
    // 
    // Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
    // 
    // If the input string is empty, return an empty string. The words in
    // the input String will only contain valid consecutive numbers.
    // 
    // Examples
    // "is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
    // "4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
    // ""  -->  ""


    public static class Kata2
    {
        public static string Order(string words)
        {
            if (words.Equals("")) return "";

            var wordsArr = words.Split(' ').ToList();
            var final = new string[wordsArr.Count()];

            foreach (var word in wordsArr)
            {
                var strNum = word.Where(c => !char.IsLetter(c));
                var num = int.Parse(strNum.First().ToString());

                final[num - 1] = word;
            }

            return string.Join(" ",final);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
            Console.WriteLine(Order("4of Fo1r pe6ople g3ood th5e the2"));
            Console.WriteLine(Order(""));
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


