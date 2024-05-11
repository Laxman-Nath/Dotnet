using System;
namespace hw{
    class Program{
        public static void Main(string [] args){
            float percent=0.0f;
            Console.WriteLine("Enter your percentage");
            // percent=Convert.ToFloat32(Console.ReadLine());
            percent=float.Parse(Console.ReadLine());
            if(percent>=80){
                Console.WriteLine("Distinction");
            }
            else if(percent >=60 && percent<80){
                Console.WriteLine("First division");
            }
             else if(percent >=50 && percent<60){
                Console.WriteLine("Second division");
            }
               else if(percent >=40 && percent<50){
                Console.WriteLine("Third division");
            }
            else{
                Console.WriteLine("Failed");
            }
        }
    }
}