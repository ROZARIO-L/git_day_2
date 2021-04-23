using System;

namespace Sample_2
{
    class Program
    {
        void even(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("The entered number is even");
            else
                Console.WriteLine("The entered number is odd");
        }
        static void Main(string[] arge)
        {
            int b;
            Console.WriteLine("Enter a number");
            b = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            program.even(b);
            Console.ReadLine();
        }
    }
}