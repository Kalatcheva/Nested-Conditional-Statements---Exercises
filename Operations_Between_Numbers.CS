namespace NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            decimal result = 0;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                        return;
                    }
                    result = a % b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine($"Cannot divide {a} by zero");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{a} {operation} {b} = {Math.Round(result, 2)} - {(result % 2 == 0 ? "even" : "odd")}");

        }
    }
}
