// Static polymorphism using method overloading in c# 
using System;
namespace poly{
    class Program{
        static int sum(int a,int b){
            return a+b;
        }
        static int sum(int a){
            return a;
        }
        static string sum(string a){
            return a;
        }
        static string sum(string a,string b){
            return a+b;
        }
        public static void Main(string [] args){
            Console.WriteLine(sum(2));
            Console.WriteLine(sum(2,3));
            Console.WriteLine(sum("laxman"));
            Console.WriteLine(sum("laxman","nath"));
        }
    }
}
