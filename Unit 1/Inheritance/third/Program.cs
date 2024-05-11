// Method hiding using new keyword in c#
using System;
namespace hiding{
    class Parent{
        public void display(){
            Console.WriteLine("This is parent class display method:");
        }
    }
    class Child:Parent{
        public new void display(){
            Console.WriteLine("This is child class display method:");
        }
    }
    class Program{
        public static void Main(string[] args){
            Child c=new Child();
            c.display();
        }
    }
}
