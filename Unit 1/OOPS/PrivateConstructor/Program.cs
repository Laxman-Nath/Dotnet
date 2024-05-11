/*
The constructor created with private specifier is called private constructor.
*/
using System;
namespace cons{
    class Program{
        int a;
        private Program(){
            Console.WriteLine("This is private constructor.This class object cannot be created and it also cannot be inherited");
        }
        public Program(int i){
          a=i;
        }
        public void display(){
            Console.WriteLine("a="+a);
        }
    }
    class main{
        public static void Main(string [] args){
          Program p1=new Program(); //here it is not accessible 
        }
    }
}

