
using System;

namespace Sample_2
{
    class Program
    {
        void swap(int a,int b)
        {
            int temp = a;
            a=b;
            b=temp;
            Console.WriteLine("------inside swap function------");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
        }
        static void Main()
        {
            Program program1= new Program();
            int a=5, b=6;
            program1.swap(a,b);
            Console.WriteLine("------OUTSIDE swap function------");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= "+b);
            Console.ReadLine();
        }
    }
}