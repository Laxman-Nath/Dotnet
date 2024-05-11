// If we didn't mention any access modifer,then by default method is private.
using System;
namespace method{
    
    class Program{
        static void myMethod(){
            Console.WriteLine("This is my first method:");
        }
         int sum(int a,int b){
            return a+b;
        }
        static int multiply(int a,int b){
            return a*b;
        }
        public static void Main(string [] args){
            // myMethod();
            // Program p=new Program();
            // Console.WriteLine("The sum is:"+p.sum(2,3));
            // Console.WriteLine("The product is:"+multiply(2,3));
            // Console.WriteLine("The cube is:"+GetCube(3));
            // Console.WriteLine("The details of user are:"+p.GetUserDetails("Laxman",15));
            PrintMultiplication(5);
        }
        public string GetUserDetails(string name,int age){
            // string info=string.Format("Name :{0},Age:{1}",name,age);
               string info="Name:"+name+" and Age:"+age;
               return info;
        }
        public static int GetCube(int number){
            return number*number*number;
        }

        public static void PrintMultiplication(int n){
            for(int i=1;i<=10;i++){
            Console.WriteLine(n+" X "+i+" = "+n*i);
            }
        }
    }
}
