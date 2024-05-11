using System;
namespace csharp{
class Program{
    public static void Main(string [] args){
Console.WriteLine("Hello, World!");
// This is single line comment
 /*
 This is multiple line comment
 This is multiple line comment
 */

 Console.WriteLine("This message is afer comments");
 // Data types example below
 int i=22;
 double d=3.14159;
 Console.WriteLine("The integer data type value is {0}",i);
 Console.WriteLine("The double data type value is {0}",d);
 // size of different data types
 Console.WriteLine("The size of int is "+ sizeof(int)+" bytes");
 Console.WriteLine("The size of float is "+sizeof(float)+" bytes");
 Console.WriteLine("The size of double is "+sizeof(double)+" bytes");
 Console.WriteLine("The size of char is "+sizeof(char)+" bytes");
 
    }
}
}
