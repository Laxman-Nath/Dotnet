using System;
namespace Application{
    public class Employee{
       public  double grossPay;
       public  double allowance;
       public  String name;
        public int id;
        public void set(double grossPay,double allowance ,string name,int id){
            this.grossPay=grossPay;
            this.allowance=allowance;
            this.name=name;
            this.id=id;
        }
        public double calculateSalary(){
            return grossPay-allowance;
        }
        
        
    }

    public class Manager:Employee{
      
        
        public void display(){
            Console.WriteLine("The name of manager is:"+this.name);
            Console.WriteLine("The id of employee is:"+this.id);
            Console.WriteLine("The grosspay is:"+this.grossPay);
            Console.WriteLine("The allowance is:"+this.allowance);
            Console.WriteLine("The salary of employee is:"+base.calculateSalary());
        }
        
    }
    class Program{
    public static void Main(string [] args){
        Manager m=new Manager();
        m.name="Laxman";
        m.id=23;
        m.grossPay=12000;
        m.allowance=10000;
        m.display();
    }
}
}
