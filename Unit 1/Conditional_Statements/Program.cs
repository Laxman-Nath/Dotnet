using System;
namespace Conditionals{
    class Program{
        public static void Main(string [] args){
            int age,number1,number2;
            // Console.WriteLine("Enter your age");
            // age=Convert.ToInt32(Console.ReadLine());
            // if(age>18){
            //     Console.WriteLine("You can vote");
            // }
            // else{
            //     Console.WriteLine("You cannot vote");
            // }
            Console.WriteLine("Enter a number");
            number1=Convert.ToInt32(Console.ReadLine());
            number2=Convert.ToInt32(Console.ReadLine());
            if(number1%2==0){
                Console.WriteLine(number1+" is even");
            }
            else{
               Console.WriteLine(number1+" is odd");
            }
            if(number2%2==0){
                Console.WriteLine(number2+" is even");
            }
            else{
               Console.WriteLine(number2+" is odd");
            }
        }
    }
}
