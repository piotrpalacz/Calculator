using System.Text.RegularExpressions;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Regex regexCheck = new Regex(@"^[a-zA-Z][1-4]");
            ConsoleKeyInfo status;

            while (true)
            {
                Console.WriteLine("**** Welcome to the Calculator App! ****");
                Console.WriteLine();
                Console.WriteLine("1. Addition\n" +
                    "2. Subtraction\n" +
                    "3. Multiplication\n" +
                    "4. Division");

                Console.Write("ENTER THE ACTION TO BE PERFORMED: ");
                int action = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 1st number: ");
                int input1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 2nd number: ");
                int input2 = Convert.ToInt32(Console.ReadLine());

                float result = 0;
                string text = "";

                switch (action)
                {
                    case 1:
                        result = Addition(input1, input2);
                        text = "addition";
                        break;
                    case 2:
                        result = Subtraction(input1, input2);
                        text = "subtraction";
                        break;
                    case 3:
                        result = Multiply(input1, input2);
                        text = "multiply";
                        break;
                    case 4:
                        while (input2 == 0)
                        {
                            Console.Write("You cannot divide by zero. Type different number: ");
                            input2 = Convert.ToInt32(Console.ReadLine());
                        }
                        result = Division(input1, input2);
                        text = "division";
                        break;
                }

                

                Console.WriteLine($"The result of {text} is: {result}");
                Console.Write("\n\nDo you want to stop the program? (y/n): ");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\nThank you for using my Calculator :)");
                    Console.ReadKey();
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static float Addition(float input1, float input2)
        {
            return input1 + input2;
        }

        public static float Subtraction(float input1, float input2)
        {
            return input1 - input2;
        }

        public static float Multiply(float input1, float input2)
        {
            return input1 * input2;
        }

        public static float Division(float input1, float input2)
        {
            return input1 / input2;
        }
    }
}