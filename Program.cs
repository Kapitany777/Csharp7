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

        static void ExpressionBodiedPerson()
        {
            Console.WriteLine("Expression bodied person");

            // Creating a valid person object
            var john = new Person("John Smith");
            Console.WriteLine(john);
            Console.WriteLine();

            // Creating an invalid person object
            try
            {
                var nobody = new Person(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        static void OutVariables()
        {
            Console.WriteLine("Out variables");

            // The old way
            string numStr1 = "700";
            int number1;

            if (int.TryParse(numStr1, out number1))
            {
                Console.WriteLine(number1);
            }

            // The new C# 7 way
            string numStr2 = "800";

            if (int.TryParse(numStr2, out int number2))
            {
                Console.WriteLine(number2);
            }

            // The new C# 7 way using var
            string numStr3 = "900";

            if (int.TryParse(numStr3, out var number3))
            {
                Console.WriteLine(number3);
            }

            Console.WriteLine();
        }

        static void ByReferenceLocalVariables()
        {
            Console.WriteLine("By-reference local variables");

            int a1 = 100;
            int b1 = a1;
            a1 = 200;

            Console.WriteLine($"a1 = {a1}, b1 = {b1}");
            Console.WriteLine();

            int a2 = 300;
            ref int b2 = ref a2;
            a2 = 400;
            Console.WriteLine($"a2 = {a2}, b2 = {b2}");
            b2 = 500;
            Console.WriteLine($"a2 = {a2}, b2 = {b2}");
            Console.WriteLine();
        }

        static void NullChecking()
        {
            Console.WriteLine("Null checking");

            Person person = null;

            // The old way
            if (person == null)
            {
                Console.WriteLine("person == null");
            }

            // The new C# 7 way
            if (person is null)
            {
                Console.WriteLine("person is null");
            }

            Console.WriteLine();
        }

        static void PatternMatchingWithTypes()
        {
            Console.WriteLine("Pattern matching with types");

            Person conan = new Fighter("Conan");

            if (conan is Fighter fighter)
            {
                Console.WriteLine($"{fighter.Name} has {fighter.HitPoints} hit points.");
            }

            Person gandalf = new Wizard("Gandalf");

            if (gandalf is Wizard wizard1)
            {
                Console.WriteLine($"{wizard1.Name} has {wizard1.ManaPoints} mana points.");
            }

            Person skandar = new Fighter("Skandar Graun");

            if (skandar is Wizard wizard2)
            {
                Console.WriteLine($"{wizard2.Name} has {wizard2.ManaPoints} mana points.");
            }

            Console.WriteLine();
        }

        static void PatternMatchingInSwitch()
        {
            Console.WriteLine("Pattern matching in switch statement");

            Person harry = new Wizard("Harry");

            switch (harry)
            {
                case Fighter fighter:
                    Console.WriteLine($"{fighter.Name} is a fighter.");
                    break;

                case Wizard wizard:
                    Console.WriteLine($"{wizard.Name} is a wizard.");
                    break;

                default:
                    Console.WriteLine("Unknown class.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            // C# 7 examples
            Console.WriteLine("C# 7 examples");
            Console.WriteLine("-------------");

            ReadableNumericLiterals();
            HexaAndBinaryLiterals();
            LocalFunctions();
            ExpressionBodiedPerson();
            OutVariables();
            ByReferenceLocalVariables();
            NullChecking();
            PatternMatchingWithTypes();
            PatternMatchingInSwitch();
        }
    }
}