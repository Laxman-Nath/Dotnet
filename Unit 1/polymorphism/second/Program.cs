// dynamic polymorphism using abstract class
using System;
namespace program{
    abstract class shape{
        abstract public void getData();
        abstract public void area();
        
    }
    class Rectangle:shape{
        private int length;
        private int breadth;
        public Rectangle(int length,int breadth){
            this.length=length;
            this.breadth=breadth;
        }
        public override void area(){
            Console.WriteLine("The area of a rectangle is:"+this.length*this.breadth);
        }
        public override void getData(){
            Console.WriteLine("Length:"+this.length);
            Console.WriteLine("Breadth:"+this.breadth);
        }
    }
    class Program{
        public static void Main(string [] args){
            Rectangle r=new Rectangle(2,3);
            r.area();
        }
    }
}
