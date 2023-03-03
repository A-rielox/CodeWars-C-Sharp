internal class Repa
{
    //     6 kyu   Ka Ka Ka cypher - words only vol 1
    // Ka ka ka cypher is a cypher used by small children in some country.
    // When a girl wants to pass something to the other girls and there are
    // some boys nearby, she can use Ka cypher.So only the other girls are
    // able to understand her.
    // She speaks using KA, ie.:
    // ka thi ka s ka bo ka y ka i ka s ka u ka gly what simply means this
    // boy is ugly.
    // 
    // Task
    // Write a function that accepts a string word and returns encoded
    // message using ka cypher.
    // 
    // Our rules:
    // 
    // The encoded word should start from ka.
    // The ka goes after vowel (a, e, i, o, u)
    // When there is multiple vowels together, the ka goes only after the
    // last vowel
    // When the word is finished by a vowel, do not add the ka after
    // Input/Output
    // The word string consists of only lowercase and uppercase characters.
    // There is only 1 word to convert - no white spaces.
    // 
    // Example
    // "a" => "kaa"
    // "ka" => "kaka"
    // "aa" => "kaaa"  
    // "Abbaa" => "kaAkabbaa"
    // "maintenance" => "kamaikantekanakance"
    // "Woodie" => "kaWookadie"
    // "Incomprehensibilities" => "kaIkancokamprekahekansikabikalikatiekas"




    public static class Kata2
    {


        public static string KaCokadekaMe(string word)
        {
            

            return "kawokard";
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(KaCokadekaMe("a"));
            //Console.WriteLine(KaCokadekaMe("ka"));
            //Console.WriteLine(KaCokadekaMe("aa"));
            Console.WriteLine(KaCokadekaMe("Abbaa"));
            Console.WriteLine(KaCokadekaMe("maintenance"));
            Console.WriteLine(KaCokadekaMe("Woodie"));
            Console.WriteLine(KaCokadekaMe("Incomprehensibilities"));
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


