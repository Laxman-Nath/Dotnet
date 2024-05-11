using System;
namespace oops{
    class Student{
        int rollno;
        string name;
        public Student(){
            Console.WriteLine("Default constructor is called:");
        }
        public Student(int rollno,string name){
            Console.WriteLine("Parameterized constructor is called:");
            this.rollno=rollno;
            this.name=name;
        }
        public Student(Student s){
            Console.WriteLine("Copy constructor is called:");
            this.rollno=s.rollno;
            this.name=s.name;
        }

       public void display(){
        Console.WriteLine("The rollno of student is:"+rollno);
        Console.WriteLine("The name of student is:"+name);
       }
    }
    
    class Program{
        public static void Main(string [] args){
            Student s1=new Student();
            s1.display();
            Student s2=new Student(4,"laxman");
            s2.display();
            Student s3=new Student(s2);
            s3.display();
        }
    }
}
