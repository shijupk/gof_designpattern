using System;

namespace gof_interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "(3 + 4) * 5";

            Console.WriteLine($"----------------------------------------- INPUT ------------------------------------------");
            Console.WriteLine($"Input: {input}");
            ExpressionParser parser = new ExpressionParser();
            Console.WriteLine($"----------------------------------------- To POSTFIX ------------------------------------------");
            var postFix = parser.InfixToPostFix(input);

            Console.WriteLine(postFix);
            Console.WriteLine($"----------------------------------------- INTERPRETER ------------------------------------------");
            var result = parser.Parse(postFix);
            Console.WriteLine($"----------------------------------------- RESULT ------------------------------------------");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"-------------------------------------------------------------------------------------------");
        }
    }
}
