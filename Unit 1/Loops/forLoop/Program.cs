using System;
namespace forLoop{
    class Program{
        public static void Main(string [] args){

            for(int i=1; i<=100; i++){
                if(i % 2 == 0){
                    Console.WriteLine("The even number is:"+i);
                }
            }
        }
    }
}
