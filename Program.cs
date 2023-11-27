using System;


namespace Assignment21
{
    public delegate int ArithmeticOperation(int num1, int num2);

    class Program
    {

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Cannot divide by zero. Returning 0.");
                return 0;
            }
        }

        static void Main()
        {
          
            ArithmeticOperation addDel = Add;
            ArithmeticOperation subtractDel = Subtract;
            ArithmeticOperation multiplyDel = Multiply;
            ArithmeticOperation divideDel = Divide;

           
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

         
            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

         
            int choice = int.Parse(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = addDel(num1, num2);
                    break;
                case 2:
                    result = subtractDel(num1, num2);
                    break;
                case 3:
                    result = multiplyDel(num1, num2);
                    break;
                case 4:
                    result = divideDel(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}