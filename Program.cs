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

            Console.WriteLine();
        }

        private static void LocalFunctions()
        {
            Func<double, double> SquareLambda = x => x * x;

            double Square(double x)
            {
                return x * x;
            }

            double Cube(double x) => x * x * x;

            Console.WriteLine("Local functions");

            double number = 5.0;
            Console.WriteLine($"The square of {number} = {SquareLambda(number)}");
            Console.WriteLine($"The square of {number} = {Square(number)}");
            Console.WriteLine($"The cube of {number}   = {Cube(number)}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // C# 7 examples
            Console.WriteLine("C# 7 examples");
            Console.WriteLine("-------------");

            ReadableNumericLiterals();
            HexaAndBinaryLiterals();
            LocalFunctions();
        }
    }
}