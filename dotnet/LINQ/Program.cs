// https://github.com/dotnet/try-samples
// https://github.com/dotnet/try-samples.git

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                        where num < 5
                        select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }


            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits)
            {
                Console.WriteLine($"The word {d} is shorter than its value.");
            }

            int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var texNums =   from n in numbers
                            select strings[n];

            foreach(var s in texNums)
            {
                Console.WriteLine(s);
            }

            QuerySyntax qs = new QuerySyntax();

            qs.TakeNumbers(3);
            qs.TakeWhile(6);
            qs.SelectFromMultiple();
        }
    }
}