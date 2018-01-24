using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int FirstNum;
            FirstNum = ReadUserInput("Enter a number to find the factorial.");

            Console.WriteLine("Factorial of {0} is {1}", FirstNum, GetFactorial(FirstNum));
        }
        public static int ReadUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            int Input = int.Parse(Console.ReadLine());
            return Input;
        }
        public static long GetFactorial (int FirstNum)
        {
            long FactorialNum = 1;
            for (int i = 1; i <= FirstNum; i++)
            {
                FactorialNum = FactorialNum * i;                                
            }
            Console.WriteLine("Number entered: {0}", FactorialNum);
            return FactorialNum;
        }
    }
}
