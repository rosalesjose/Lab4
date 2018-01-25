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
            bool RunProgram = true;
            while (RunProgram)
            {
                int FirstNum;
                FirstNum = ReadUserInput("Enter a number to find the factorial.");

                //For Loop
                Console.WriteLine("For Loop: Factorial of {0} is {1}", FirstNum, GetFactorial(FirstNum));

                //Recursive
                Console.WriteLine("Recursive: Factorial of {0} is {1}", FirstNum, Recursive(FirstNum));

                Console.WriteLine("\nRun again (Y/N)?");
                char DoAgain = char.Parse(Console.ReadLine());

                if (DoAgain == 'y' || DoAgain == 'Y')
                {
                    Console.Clear();
                }
                else
                {
                    RunProgram = false;
                }
            }
        }

        public static int ReadUserInput(string UserPrompt)
        {
            Console.WriteLine(UserPrompt);
            int Input = int.Parse(Console.ReadLine());
            return Input;
        }

        public static long GetFactorial(int FirstNum)
        {
            if (FirstNum == 0)
            {
                return 1;
            }

            long FactorialNum = 1;

            for (long i = 1; i <= FirstNum; i++)
            {
                FactorialNum = FactorialNum * i;
            }
             
            return FactorialNum;
        }

        public static long Recursive (int FirstNum)
        {
            if (FirstNum == 0)
            {
                return 1;
            }
            return FirstNum * Recursive(FirstNum - 1);
        }
    }
}
