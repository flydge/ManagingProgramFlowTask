using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ManagingProgramFlowTask
{
    public class MathOperations
    {
        private static readonly Dictionary<int,string> _operators = new Dictionary<int, string>()
        {
            [1] = "+",
            [2] = "-",
            [3] = "*",
            [4] = "/"
        };
        
        static double  Calculation(int numb4menu ,  double numb1,  double numb2 )
        {
            double outnumb = 0;
            switch (numb4menu)
            {
                case 1:
                {
                    outnumb = numb1 + numb2;
                    break;
                }
                case 2:
                {
                    outnumb = numb1 - numb2;
                    break;
                }
                case 3:
                {
                    outnumb = numb1 * numb2;
                    break;
                }
                case 4:
                {
                    outnumb = numb1 - numb2;
                    break;
                }
                    
            }

            return outnumb;
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("what operation do you want to perform?(press the numb)" + "\n 1 - Addition" + "\n 2 - Decrease" + "\n 3 - Multiplication" + "\n 4 - Division");

                int numb4Menu = Convert.ToInt32(Console.ReadLine());

                if (numb4Menu == 1 || numb4Menu == 2 || numb4Menu == 3 || numb4Menu == 4)
                {
                    Console.WriteLine("enter 2 numbers for operation:");
                    double numb1 = Convert.ToDouble(Console.ReadLine());
                    double numb2 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("{0} {1} {2} = {3}", numb1, _operators[numb4Menu], numb2, Calculation(numb4Menu, numb1, numb2));
                    Console.WriteLine("Continue?\n(input \"nope\" for exit, or press any other key for continue)");

                    var contSymb = Console.ReadLine();

                    if (contSymb != "nope") continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again\n");
                    continue;
                }


                break;
            }
        }
    }
}