namespace LINQ
{
    class QuerySyntax
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public void TakeNumbers(int number)
        {

            var first3Numbers = numbers.Take(3);
            
            Console.WriteLine($"First {number} numbers");

            foreach(var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
        }

        public void TakeWhile(int number)
        {
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < number);

            Console.WriteLine($"First numbers less than {number}:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
        }

        public void SelectFromMultiple()
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select(a, b);

            Console.WriteLine("Pairs where a < b");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }
        }
    }
}