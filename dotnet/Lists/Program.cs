// https://youtu.be/oIQdb93xewE?list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN
// Lists of Other Types | C# 101 [14 of 19]
namespace Lists 
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "México", "Rusia", "China", "Estados Unidos"};

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            names.Remove("Estados Unidos");
            Console.WriteLine();

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"The list has {names.Count} elements");
        }
    }
}