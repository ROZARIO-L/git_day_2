using System.IO;
using System;
namespace Day_2
{
        class Dog
        {
            public void Speak()
            {
                Console.WriteLine("Bark !");
            }
            
        }
        class Class7
        {
            static void Main()
            {
                object o = new Dog();
                Dog dog = o as Dog;
                if(dog != null)
                dog.Speak();
                Console.ReadLine();
            }
        }
    }