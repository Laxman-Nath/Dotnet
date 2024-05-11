// Write a simple program to create generic class with generic constructor,generic member variable,generic property
//and generic method (asked in 2080)
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
namespace program { 
    class Student<T>
    {
        T data;
        public Student()
        {
            Console.WriteLine("Empty constructor!");
        }
        public Student(T data)
        {
            this.data = data;
        }
        public void add (T data)
        {
            this.data = data;
        }
        public void Show()
        {
            Console.WriteLine($"Data is :{this.data}");
        }
        public void method1<U> (U argument)
        {
            Console.WriteLine($"Generic method called with argument:{argument}");

        }
    }
    class Program {
        public static void Main(string[] args) {
            //List <int> list = new List<int>();
            //list .Add (1);
            //list .Add (2);
            //list .Add (3);
            //list .Add (4);
            //list.Remove(0);
            //Console.WriteLine(list.ToArray());
            //Console.WriteLine (list.Capacity);
            //Console.WriteLine (list.Count);

            Student<int> id = new Student<int>(1);   
            id.Show();
            id.method1("Laxman");

            Student<string> name = new Student<string>();
            name.add("Laxman");
            name.Show();
            name.method1(2);


        }
    }

}

