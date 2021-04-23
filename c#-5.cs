using System.IO;
using System;
namespace Day_2
{
        public struct Person
        {
            public String Name{get; set;}
            public Person(string _name)
            {
                Name=_name;
            }
        }
                public struct Dog
                {
                   public String Breed{get; set;}
            public Dog(string _breed) 
            {
                Breed=_breed;
            }
                }
        class Program
{
         public static void showvalue(Object o)
    {
       if(o is Person p) 
       {
           Console.WriteLine(p.Name);
       }
       else if(o is Dog d)
       {
           Console.WriteLine(d.Breed);
       }
     }
    static void Main()
    {
        Object o = new Person("Rozario");
        showvalue(o);
        o = new Dog("Husky");
        showvalue(o);
        Console.ReadLine();
    }
}
}