using System;
namespace sum{
    class Program{
        public static void Main(string [] args){
            // Program p=new Program();
            Console.WriteLine(sum());

        }
     public static int sum(){
            Console.WriteLine("Enter two numbers:");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            return a+b;
        }
    }
}
