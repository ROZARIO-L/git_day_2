using System;
class Class1
{
  static void Main()
  {
    Console.WriteLine("Enter any word");
     string inputstr= Console.ReadLine();
     char []revstr=new char[inputstr.Length];
     
     for(int i= inputstr.Length-1; i>=0; i--)
     {
         revstr[i]= inputstr[i];
     }
     string revstring= new string(revstr);
     if(revstring==inputstr)
     {
          Console.WriteLine("it's a pallindrome");
     }
     else
     {
        Console.WriteLine("it's not a pallindrome"); 
     }
  }