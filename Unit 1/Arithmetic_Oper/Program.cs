using System;
namespace Arithmetic{
    class Program{
        public static void Main(string [] args){
            int add,sub,mul,div,a,b;
            Console.WriteLine("Enter first number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b=Convert.ToInt32(Console.ReadLine());
            add=a+b;
            sub=a-b;
            mul=a*b;
            div=a/b;
            Console.WriteLine("The sum is :"+add + "\n" +"The difference is :"+sub+"\n"+"The product is :"+mul
            +"\n"+"The division is :"+div);
            // Console.WriteLine("The difference is :"+sub);
            // Console.WriteLine("The product is :"+mul);
            // Console.WriteLine("The division is :"+div);
        }
    }

}
