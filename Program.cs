namespace Csharp7
{
    internal class Program
    {
        private static void ReadableNumericLiterals()
        {
            Console.WriteLine("Readable numeric literals");

            int integer1 = 1_000_000;
            Console.WriteLine(integer1);

            double double1 = 1_234.5_678;
            Console.WriteLine(double1);

            Console.WriteLine();
        }

        private static void HexaAndBinaryLiterals()
        {
            Console.WriteLine("Hexadecimal and binary literals");
            
            int hexa = 0xff;
            Console.WriteLine(hexa);

            int bin = 0b1111_1111;
            Console.WriteLine(bin);
        }

        static void Main(string[] args)
        {
            // C# 7 examples
            Console.WriteLine("C# 7 examples");
            Console.WriteLine("-------------");

            ReadableNumericLiterals();
            HexaAndBinaryLiterals();
        }
    }
}