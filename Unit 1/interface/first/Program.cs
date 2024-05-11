
using System;
namespace interfaceApplication{
    interface Shape{
        public double area(double r);
        public double circumference(double r);
       
    }
    class Circle:Shape{
       
        public double area(double r){
            return Math.PI * r * r;
        }
        public double circumference(double r){
            return 2 * Math.PI * r;
        }
    }
    class Program{
        public static void Main(string [] args){
            Circle c=new Circle();
            Console.WriteLine("Enter radius of a circle:");
            double r;
            double.TryParse(Console.ReadLine(),out r);
            Console.WriteLine("The area is:"+new Circle().area(r));
            Console.WriteLine("The perimeter is:"+c.circumference(r));

        }
    }
}