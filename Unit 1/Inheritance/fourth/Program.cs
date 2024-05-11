using System;
namespace inheritanceApplication{
    public class Animal{
        public Animal(){
            Console.WriteLine("This is Animal class");
        }
        public void eat(){
            Console.WriteLine("Eating.....");
        }
    }

    // Single level inheritance example
    public class Dog : Animal{
        public Dog(){
            Console.WriteLine("This is dog class");
        }
        public void bark(){
            Console.WriteLine("Barking.....");
        }
    }

    // Multilevel inheritance example
    public class BabyDog : Dog{
        public BabyDog(){
            Console.WriteLine("This is babydog class");
        }
        public void weep(){
            Console.WriteLine("Weeping.......");
        }
    }
    public class Program{
        public static void Main(string [] args){
            BabyDog b=new BabyDog();
            b.weep();
            b.bark();
            b.eat();
        }
    }
}
