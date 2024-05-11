using System;
 namespace WhileLoop{
    class Program{
        public static void Main(string [] args){
           int i=1;
           Console.WriteLine("Odd numbers between 1 to 100 are;");
           while(i<=100){
            if(i % 2!=0){
                Console.WriteLine(i);
            }
            i++;
           } 
        }
    }
 }
