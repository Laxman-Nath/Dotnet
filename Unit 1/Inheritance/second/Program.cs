// Constructor in Inheritance in c#
using System;
namespace constructs{
    class ParentClass{
       public int x=10;
       public int y;
       public int z;
        public ParentClass(){
            Console.WriteLine("Parent constructor!");
        }
        public ParentClass(int y,int z){
            Console.WriteLine("Parent parameterized constructor");
            this.y=y;
            this.z=z;
            

        }
        public void print(){
            Console.WriteLine("Parent class!");
        }
    }
    class ChildClass:ParentClass{
        public int a;
        public ChildClass():base(2,3){
            Console.WriteLine("Child Constructor:");
            // base.print();
            // Console.WriteLine(base.x);
        }
        public ChildClass(int a):base(2,3){
            this.a=a;
            Console.WriteLine(this.a);
            // Console.WriteLine(base.y);
            // Console.WriteLine(base.z);
        }
    }
    class Program{
        public static void Main(string [] args){
            // ParentClass c=new ChildClass(1);
                ChildClass c=new ChildClass();
        }
    }
}
