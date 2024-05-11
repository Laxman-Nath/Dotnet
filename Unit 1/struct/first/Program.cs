// struct in c# 
using System;
namespace Struct{
    struct Point{
        public int x;
        public int y;
        public Point(int x,int y){
            this.x=x;
            this.y=y;
        }
        public void display(){
            Console.WriteLine("X="+this.x+",Y="+this.y);
        }
    }
    class Program{
    //       struct Point{
    //     public int x;
    //     public int y;
    //     public Point(int x,int y){
    //         this.x=x;
    //         this.y=y;
    //     }
    //     public void display(){
    //         Console.WriteLine("X="+this.x+",Y="+this.y);
    //     }
    // }
        public static void Main(string [] args){
            Point p=new Point(2,3);
            p.display();
        }
    }
}
