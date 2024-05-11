using System;
namespace dowhile{
    class Program{
        public static void Main(string [] args){
           int i=1;
           Console.WriteLine("Odd numbers between 1 to 100 are;");
           do{
            if(i % 2!=0){
                Console.WriteLine(i);
            }
            i++;
           } while(i<=100);
        }
    }
}
