namespace Csharp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# 7 examples
            Console.WriteLine("C# 7 examples");
            Console.WriteLine("-------------");

            ReadableNumericLiterals();
        }

        private static void ReadableNumericLiterals()
        {
            Console.WriteLine("Readable numeric literals");

            int integer1 = 1_000_000;
            Console.WriteLine(integer1);

            double double1 = 1_234.5_678;
            Console.WriteLine(double1);

            Console.WriteLine();
        }
    }
}