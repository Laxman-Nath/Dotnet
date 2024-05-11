// Inheritance in c#
// Method overriding in c#
using System;
namespace inheritance{
    class Vehicle{
        public string brand;
        public string horn;
        public int capacity;
       
        public virtual void getData(){
            Console.WriteLine("This is the parent class getdata method");
           Console.WriteLine("Brand:"+this.brand);
           Console.WriteLine("Horn:"+this.horn);
           Console.WriteLine("Capacity:"+this.capacity);
        }
    }
    class Car:Vehicle{
        public int speed;
         public void setData(string brand,string horn,int capacity,int speed){
            this.brand=brand;
            this.horn=horn;
            this.capacity=capacity;
            this.speed=speed;
        }
        public void getData(){
           Console.WriteLine("This is the child class getdata method:");
           Console.WriteLine("Brand:"+this.brand);
           Console.WriteLine("Horn:"+this.horn);
           Console.WriteLine("Capacity:"+this.capacity);
           Console.WriteLine("Speed:"+this.speed);
        }
    }
    class Program{
        public static void Main(string [] args){
             Vehicle v1=new Vehicle();
            v1.brand="bmw";
            v1.horn="po po po";
            v1.capacity=8;
            v1.getData();
            Car c1=new Car();
            c1.setData("Audi","pi pi pi",4,60);
            c1.getData();
        }
    }
}
