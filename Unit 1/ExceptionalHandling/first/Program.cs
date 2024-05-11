using System;
namespace Application{
    class Program{
        public static void Main(string [] args){
            int x=0;
            int div=0;
            try{
                div=100/x;
                Console.WriteLine("This line is not executed!");
            }
            catch(DivideByZeroException e){
                Console.WriteLine("Exception Occured!");
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("Finally block!");
            }
        }
    }
}
