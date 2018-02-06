using System;

namespace MathStatClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the number");
                var numb = Console.ReadLine();
                Calculations calculations = new Calculations(numb);
                calculations.MainCalculationMethod();
                Console.WriteLine(calculations);
           
                Console.WriteLine("Continue?\n(input \"nope\" for exit, or press any other key for continue)");
                var contSymb = Console.ReadLine();
               
                if (contSymb != "nope")
                {
                    continue;
                }
                
                break;
            }
            

           
        }
    }
}