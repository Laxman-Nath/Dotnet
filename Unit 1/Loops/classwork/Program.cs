using System;
namespace table{
    class Program{
        public static void Main(string [] args){
            int n;
            Console.WriteLine("Enter number:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++){
                Console.WriteLine(n+" X "+i+"="+n*i);
            }
        }
    }
}
