	using System;
class Class1
{
  static void Main()
  {
    Console.WriteLine("Enter any word");
     int vowel=0;
     string inputstring = Console.ReadLine();
     for (int index =0; index< inputstring.Length; index++)
     {
         if(inputstring[index]=='a'||inputstring[index]=='e'||inputstring[index]=='i'||inputstring[index]=='o'||inputstring[index]=='u')
         {
             vowel++;
            
         }
     }
     Console.WriteLine("total no of vowels in the string is : "+vowel);
     Console.ReadLine();
     
  }
}