namespace Calculator
{
    /// <summary>
    /// CALCULATOR V.1
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //test comments
            Console.WriteLine("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter mathematical operator; for addition (+), for subtraction (-), multiplication (*), division(/): ");
            string @operator = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());



            double result;

            if (@operator == "+") 
            { 
                result = num1 + num2;
                Console.WriteLine("Result: {0} + {1} = {2}", num1,num2,num1 + num2);
            }
            else if (@operator == "-") 
            { 
                result = num1 - num2;
                Console.WriteLine("Result: {0} - {1} = {2}", num1, num2, num1 - num2);
            }
            else if (@operator == "*") 
            { 
                result = num1 * num2;
                Console.WriteLine("Result: {0} * {1} = {2}", num1, num2, num1 * num2);
            }
            else if (@operator == "/") 
            { 
                result = num1 / num2;
                Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, num1 / num2);
            }

            


            Console.ReadLine();
        }

    }
}

